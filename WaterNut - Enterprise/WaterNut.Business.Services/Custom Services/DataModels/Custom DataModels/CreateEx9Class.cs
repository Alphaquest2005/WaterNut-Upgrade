using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using AllocationDS.Business.Entities;
using AllocationDS.Business.Services;
using Core.Common.UI;
using DocumentDS.Business.Entities;
using DocumentDS.Business.Services;
using TrackableEntities;
using WaterNut.Business.Entities;
using WaterNut.Interfaces;
using EntryDataDetails = AllocationDS.Business.Entities.EntryDataDetails;
using xBondAllocations = DocumentItemDS.Business.Entities.xBondAllocations;
using xcuda_Weight = DocumentDS.Business.Entities.xcuda_Weight;
using xcuda_Weight_itm = DocumentItemDS.Business.Entities.xcuda_Weight_itm;
using System.Data.Entity;
using DocumentItemDS.Business.Entities;
using MoreLinq;

//using xcuda_Item = AllocationDS.Business.Entities.xcuda_Item;
//using xcuda_PreviousItem = AllocationDS.Business.Entities.xcuda_PreviousItem;

namespace WaterNut.DataSpace
{
    public class CreateEx9Class
    {
        private static readonly CreateEx9Class _instance;

        static CreateEx9Class()
        {
            _instance = new CreateEx9Class();
        }

        public static CreateEx9Class Instance
        {
            get { return _instance; }
        }

        public bool ApplyCurrentChecks { get; set; }


        public bool PerIM7 { get; set; }


        public bool Process7100 { get; set; }


        public async Task CreateEx9(string filterExpression, bool perIM7, bool process7100, bool applyCurrentChecks,
            AsycudaDocumentSet docSet)
        {

            try
            {
                PerIM7 = perIM7;
                Process7100 = process7100;
                ApplyCurrentChecks = applyCurrentChecks;

                await ProcessEx9(docSet, filterExpression).ConfigureAwait(false);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<PiSummary> docSetPi = null;
        private async Task ProcessEx9(AsycudaDocumentSet docSet, string filterExp)
        {
           
            docSetPi = new List<PiSummary>();
            //var dutylst = CreateDutyList(slst);
            var dutylst = new List<string>(){"Duty Paid", "Duty Free"};
            if (!filterExp.Contains("InvoiceDate"))
            {
                throw new ApplicationException("Filter string dose not contain 'Invoice Date'");
                
            }
            var realStartDate = DateTime.Parse(filterExp.Substring(filterExp.IndexOf("InvoiceDate >= ")+ "InvoiceDate >= ".Length + 1, 10));
            var realEndDate = DateTime.Parse(filterExp.Substring(filterExp.IndexOf("InvoiceDate <= ") + "InvoiceDate <= ".Length + 1, 19));
            DateTime startDate = realStartDate;

            while (startDate <= realEndDate)
            {

                DateTime firstOfNextMonth = new DateTime(startDate.Year, startDate.Month, 1).AddMonths(1);
                DateTime endDate = firstOfNextMonth.AddDays(-1).AddHours(23);

                var currentFilter = filterExp.Replace($@"InvoiceDate >= ""{realStartDate:MM/dd/yyyy}""",
                        $@"InvoiceDate >= ""{startDate:MM/dd/yyyy}""")
                    .Replace($@"InvoiceDate <= ""{realEndDate:MM/dd/yyyy HH:mm:ss}""",
                        $@"InvoiceDate <= ""{endDate:MM/dd/yyyy HH:mm:ss}""");

              //  var salesSummary = GetSalesSummary(startDate, endDate);
              //  var piSummary = GetPiSummary(startDate, endDate);
                var itemSalesPiSummarylst = GetItemSalesPiSummary(startDate, endDate);
                if(Process7100) itemSalesPiSummarylst.AddRange(Get7100SalesPiSummaryLst(startDate,endDate));


                foreach (var dfp in dutylst)
                {
                    var exPro = " && (PreviousDocumentItem.AsycudaDocument.Extended_customs_procedure == \"7000\" || PreviousDocumentItem.AsycudaDocument.Extended_customs_procedure == \"7400\")";
                    var slst =
                        (await CreateAllocationDataBlocks(currentFilter + exPro).ConfigureAwait(false)).Where(
                            x => x.Allocations.Count > 0);
                    if (slst != null && slst.ToList().Any())
                    {
                        await CreateDutyFreePaidDocument(dfp, slst.Where(x => x.DutyFreePaid == dfp), docSet, "7000",
                                itemSalesPiSummarylst.Where(x => x.DutyFreePaid == dfp).ToList())
                            .ConfigureAwait(false);
                    }
                    if (Process7100)
                    {
                        exPro = " && PreviousDocumentItem.AsycudaDocument.Extended_customs_procedure == \"7100\"";
                        slst =
                            (await CreateAllocationDataBlocks(currentFilter + exPro).ConfigureAwait(false)).Where(
                                x => x.Allocations.Count > 0);
                        if (slst != null && slst.ToList().Any())
                        {
                            await CreateDutyFreePaidDocument(dfp, slst.Where(x => x.DutyFreePaid == dfp), docSet,
                                    "7100",
                                    itemSalesPiSummarylst.Where(x => x.DutyFreePaid == dfp).ToList())
                                .ConfigureAwait(false);
                        }
                    }

                }
                startDate = new DateTime(startDate.Year, startDate.Month, 1).AddMonths(1);
            }

            StatusModel.StopStatusUpdate();
        }

        private List<ItemSalesPiSummary> Get7100SalesPiSummaryLst(DateTime startDate, DateTime endDate)
        {
            var res =  Historic7100ItemSalesPi(endDate);
            res.AddRange(Current7100ItemSalesPi(startDate,endDate));
            return res;
        }

        private static List<ItemSalesPiSummary> Historic7100ItemSalesPi(DateTime endDate)
        {
            using (var ctx = new AllocationDSContext())
            {
                var res = ctx.Database.SqlQuery<x7100SalesPi>(
                    $@"SELECT        AllocationsItemNameMapping.ItemNumber, SIM.ItemQuantity, ISNULL(SEX.PiQuantity, 0) AS PiQuantity, SIM.DPQtyAllocated, ISNULL(SEX.DPPi, 0) AS DPPi, SIM.DFQtyAllocated, ISNULL(SEX.DFPi, 0) AS DFPi
FROM            (SELECT        ItemNumber, SUM(ItemQuantity) AS ItemQuantity, SUM(DPQtyAllocated) AS DPQtyAllocated, SUM(DFQtyAllocated) AS DFQtyAllocated
                          FROM            (SELECT        AsycudaDocumentItem.ItemNumber, AsycudaDocumentItem.DPQtyAllocated, AsycudaDocumentItem.DFQtyAllocated, AsycudaDocumentItem.ItemQuantity, AsycudaDocument.AssessmentDate, 
                                                                              AsycudaDocument.ExpiryDate, AsycudaDocument.CNumber, AsycudaDocumentItem.LineNumber
                                                    FROM            AsycudaDocumentBasicInfo AS AsycudaDocument INNER JOIN
                                                                              AsycudaItemBasicInfo AS AsycudaDocumentItem ON AsycudaDocument.ASYCUDA_Id = AsycudaDocumentItem.ASYCUDA_Id
                                                    WHERE        (AsycudaDocument.Extended_customs_procedure = '7100')
                                                    GROUP BY AsycudaDocumentItem.ItemNumber, AsycudaDocumentItem.DPQtyAllocated, AsycudaDocumentItem.DFQtyAllocated, AsycudaDocumentItem.ItemQuantity, AsycudaDocument.AssessmentDate, 
                                                                              AsycudaDocument.ExpiryDate, AsycudaDocument.CNumber, AsycudaDocumentItem.LineNumber) AS IM
                          WHERE        (AssessmentDate <= CONVERT(DATETIME, '{endDate.Date.ToShortDateString()}', 102)) AND (ExpiryDate >= CONVERT(DATETIME, '{endDate.Date.ToShortDateString()}', 102))
                          GROUP BY ItemNumber) AS SIM INNER JOIN
                         AllocationsItemNameMapping ON SIM.ItemNumber = AllocationsItemNameMapping.Precision_4 LEFT OUTER JOIN
                             (SELECT        ItemNumber, SUM(ISNULL(ItemQuantity, 0)) AS PiQuantity, ISNULL(SUM(DPPiQuantity), 0) AS DPPi, ISNULL(SUM(DFPiQuantity), 0) AS DFPi
                               FROM            (SELECT        AsycudaDocumentItem_1.ItemNumber, AsycudaDocumentItem_1.ItemQuantity, CAST(CASE WHEN Extended_customs_procedure = '4071' THEN itemquantity ELSE 0 END AS float) AS DPPiQuantity, 
                                                                                   CAST(CASE WHEN Extended_customs_procedure = '9071' THEN itemquantity ELSE 0 END AS float) AS DFPiQuantity, AsycudaDocument_1.AssessmentDate, AsycudaDocument_1.ExpiryDate, 
                                                                                   AsycudaDocument_1.CNumber
                                                         FROM            AsycudaItemBasicInfo AS AsycudaDocumentItem_1 INNER JOIN
                                                                                   AsycudaDocumentBasicInfo AS AsycudaDocument_1 ON AsycudaDocumentItem_1.ASYCUDA_Id = AsycudaDocument_1.ASYCUDA_Id
                                                         GROUP BY AsycudaDocumentItem_1.ItemNumber, AsycudaDocumentItem_1.ItemQuantity, AsycudaDocument_1.AssessmentDate, AsycudaDocument_1.ExpiryDate, AsycudaDocument_1.CNumber, 
                                                                                   AsycudaDocument_1.Extended_customs_procedure
                                                         HAVING         (AsycudaDocument_1.Extended_customs_procedure = '9071' OR
                                                                                   AsycudaDocument_1.Extended_customs_procedure = '4071')) AS Ex
                               WHERE        (AssessmentDate <= CONVERT(DATETIME, '{endDate.Date.ToShortDateString()}', 102))
                               GROUP BY ItemNumber) AS SEX ON SIM.ItemNumber = SEX.ItemNumber
GROUP BY AllocationsItemNameMapping.ItemNumber, SIM.ItemQuantity, ISNULL(SEX.PiQuantity, 0), SIM.DPQtyAllocated, ISNULL(SEX.DPPi, 0), SIM.DFQtyAllocated, ISNULL(SEX.DFPi, 0)").ToList();

                var lst = res.Where(x => x.DPQtyAllocated > 0).Select(x => new ItemSalesPiSummary()
                {
                    DutyFreePaid = "Duty Paid",
                    ItemNumber = x.ItemNumber,
                    PiQuantity = x.DPPi,
                    QtyAllocated = x.DPQtyAllocated,
                    Type = "Historic"
                }).ToList();

                lst.AddRange(res.Where(x => x.DFQtyAllocated > 0).Select(x => new ItemSalesPiSummary()
                {
                    DutyFreePaid = "Duty Free",
                    ItemNumber = x.ItemNumber,
                    PiQuantity = x.DFPi,
                    QtyAllocated = x.DFQtyAllocated,
                    Type = "Historic"
                }).ToList());

                return lst;
            }
        }

        private static List<ItemSalesPiSummary> Current7100ItemSalesPi(DateTime startDate, DateTime endDate)
        {
            using (var ctx = new AllocationDSContext())
            {
                var res = ctx.Database.SqlQuery<x7100SalesPi>(
                    $@"SELECT        AllocationsItemNameMapping.ItemNumber, SIM.QtySold AS ItemQuantity, ISNULL(SEX.PiQuantity, 0) AS PiQuantity, SIM.DPQtyAllocated, ISNULL(SEX.DPPi, 0) AS DPPi, SIM.DFQtyAllocated, ISNULL(SEX.DFPi, 0) AS DFPi
FROM            (SELECT        ItemNumber, SUM(SalesQuantity) AS QtySold, SUM(QtyAllocated) AS QtyAllocated, SUM(DPQtyAllocated) AS DPQtyAllocated, SUM(DPSalesQuantity) AS DPSalesQuantity, SUM(DFQtyAllocated) AS DFQtyAllocated, 
                         SUM(DFSalesQuantity) AS DFSalesQuantity
FROM            (SELECT        TOP (100) PERCENT AsycudaItemBasicInfo.ItemNumber, EntryDataDetails.Quantity AS SalesQuantity, AsycudaSalesAllocations.QtyAllocated, EntryDataDetails.EntryDataId AS Invoice, EntryData.EntryDataDate AS InvoiceDate, 
                         EntryDataDetails.EntryDataDetailsId, CASE WHEN taxamount > 0 THEN AsycudaSalesAllocations.qtyallocated ELSE 0 END AS DPQtyAllocated, CASE WHEN taxamount > 0 THEN quantity ELSE 0 END AS DPSalesQuantity, 
                         CASE WHEN taxamount = 0 THEN AsycudaSalesAllocations.qtyallocated ELSE 0 END AS DFQtyAllocated, CASE WHEN taxamount = 0 THEN quantity ELSE 0 END AS DFSalesQuantity
FROM            AsycudaSalesAllocations INNER JOIN
                         AsycudaItemBasicInfo ON AsycudaSalesAllocations.PreviousItem_Id = AsycudaItemBasicInfo.Item_Id INNER JOIN
                         AsycudaDocumentBasicInfo ON AsycudaItemBasicInfo.ASYCUDA_Id = AsycudaDocumentBasicInfo.ASYCUDA_Id INNER JOIN
                         EntryDataDetails ON AsycudaSalesAllocations.EntryDataDetailsId = EntryDataDetails.EntryDataDetailsId INNER JOIN
                         EntryData ON EntryDataDetails.EntryDataId = EntryData.EntryDataId INNER JOIN
                         EntryData_Sales ON EntryData.EntryDataId = EntryData_Sales.EntryDataId
WHERE        (AsycudaDocumentBasicInfo.Extended_customs_procedure = '7100')
GROUP BY AsycudaItemBasicInfo.ItemNumber, EntryDataDetails.Quantity, EntryData_Sales.TaxAmount, AsycudaSalesAllocations.QtyAllocated, EntryDataDetails.EntryDataId, EntryData.EntryDataDate, 
                         EntryDataDetails.EntryDataDetailsId
ORDER BY InvoiceDate) AS sales
WHERE        (InvoiceDate <= CONVERT(DATETIME, '{endDate.Date.ToShortDateString()}', 102)) AND (InvoiceDate >= CONVERT(DATETIME, '{startDate.Date.ToShortDateString()}', 102))
GROUP BY ItemNumber) AS SIM INNER JOIN
                         AllocationsItemNameMapping ON SIM.ItemNumber = AllocationsItemNameMapping.Precision_4 LEFT OUTER JOIN
                             (SELECT        ItemNumber, SUM(ISNULL(ItemQuantity, 0)) AS PiQuantity, ISNULL(SUM(DPPiQuantity), 0) AS DPPi, ISNULL(SUM(DFPiQuantity), 0) AS DFPi
                               FROM            (SELECT        AsycudaDocumentItem_1.ItemNumber, AsycudaDocumentItem_1.ItemQuantity, CAST(CASE WHEN Extended_customs_procedure = '4071' THEN itemquantity ELSE 0 END AS float) AS DPPiQuantity, 
                                                                                   CAST(CASE WHEN Extended_customs_procedure = '9071' THEN itemquantity ELSE 0 END AS float) AS DFPiQuantity, AsycudaDocument_1.AssessmentDate, AsycudaDocument_1.ExpiryDate, 
                                                                                   AsycudaDocument_1.CNumber
                                                         FROM            AsycudaItemBasicInfo AS AsycudaDocumentItem_1 INNER JOIN
                                                                                   AsycudaDocumentBasicInfo AS AsycudaDocument_1 ON AsycudaDocumentItem_1.ASYCUDA_Id = AsycudaDocument_1.ASYCUDA_Id
                                                         GROUP BY AsycudaDocumentItem_1.ItemNumber, AsycudaDocumentItem_1.ItemQuantity, AsycudaDocument_1.AssessmentDate, AsycudaDocument_1.ExpiryDate, AsycudaDocument_1.CNumber, 
                                                                                   AsycudaDocument_1.Extended_customs_procedure
                                                         HAVING         (AsycudaDocument_1.Extended_customs_procedure = '9071') OR
                                                                                   (AsycudaDocument_1.Extended_customs_procedure = '4071')) AS Ex
                               WHERE        (AssessmentDate <= CONVERT(DATETIME, '{endDate.Date.ToShortDateString()}', 102)) AND (AssessmentDate >= CONVERT(DATETIME, '{startDate.Date.ToShortDateString()}', 102))
                               GROUP BY ItemNumber) AS SEX ON SIM.ItemNumber = SEX.ItemNumber
GROUP BY AllocationsItemNameMapping.ItemNumber, SIM.QtySold, ISNULL(SEX.PiQuantity, 0), SIM.DPQtyAllocated, ISNULL(SEX.DPPi, 0), SIM.DFQtyAllocated, ISNULL(SEX.DFPi, 0)").ToList();

                var lst = res.Where(x => x.DPQtyAllocated > 0).Select(x => new ItemSalesPiSummary()
                {
                    DutyFreePaid = "Duty Paid",
                    ItemNumber = x.ItemNumber,
                    PiQuantity = x.DPPi,
                    QtyAllocated = x.DPQtyAllocated,
                    Type = "Current"
                }).ToList();

                lst.AddRange(res.Where(x => x.DFQtyAllocated > 0).Select(x => new ItemSalesPiSummary()
                {
                    DutyFreePaid = "Duty Free",
                    ItemNumber = x.ItemNumber,
                    PiQuantity = x.DFPi,
                    QtyAllocated = x.DFQtyAllocated,
                    Type = "Current"
                }).ToList());

                return lst;
            }
        }


        private List<PiSummary> GetPiSummary(DateTime startDate,DateTime endDate)
        {
            
            using (var ctx = new AllocationDSContext())
            {
              
                var piSummaryHistoric = ctx.xcuda_PreviousItem
                                .Where(x => x.xcuda_Item.AsycudaDocument.Cancelled != true
                                          //  && x.xcuda_Item.IsAssessed == true --- did not force assesed so that system checks potential ex-warehouse too
                                            && (x.xcuda_Item.AsycudaDocument.Extended_customs_procedure == "9070" || x.xcuda_Item.AsycudaDocument.Extended_customs_procedure == "4070")
                                            && x.xcuda_Item.AsycudaDocument.AssessmentDate != null 
                                            && x.xcuda_Item.AsycudaDocument.AssessmentDate >= (BaseDataModel.Instance.CurrentApplicationSettings.OpeningStockDate ?? DateTime.MinValue)
                                            //  && x.xcuda_Item.AsycudaDocument.AssessmentDate >= startDate
                                            && x.xcuda_Item.AsycudaDocument.AssessmentDate.Value <= endDate)
                    .GroupBy(x => new { ItemNumber = x.xcuda_Item.xcuda_Tarification.xcuda_HScode.Precision_4, DutyFreePaid = (x.xcuda_Item.AsycudaDocument.Extended_customs_procedure == "9070" ? "Duty Free" : "Duty Paid"), pCNumber = x.Prev_reg_nbr, pLineNumber = x.Previous_item_number, pOffice = x.Prev_reg_cuo, pAssessmentDate = x.xcuda_Item.AsycudaDocument.AssessmentDate, pItemQuantity = x.Preveious_suplementary_quantity })
                    .Select(g => new PiSummary
                    {
                        ItemNumber = g.Key.ItemNumber,
                        pItemQuantity = g.Key.pItemQuantity,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        TotalQuantity = g.Sum(z => z.Suplementary_Quantity),
                        Type = "Historic",
                        pCNumber = g.Key.pCNumber,
                        pLineNumber = g.Key.pLineNumber,
                        pOffice = g.Key.pOffice,
                        pAssessmentDate = g.Key.pAssessmentDate.Value
                    }).ToList();

                var piSummaryCurrent = ctx.xcuda_PreviousItem
                    .Where(x => x.xcuda_Item.AsycudaDocument.Cancelled != true
                                //  && x.xcuda_Item.IsAssessed == true --- did not force assesed so that system checks potential ex-warehouse too
                                && (x.xcuda_Item.AsycudaDocument.Extended_customs_procedure == "9070" || x.xcuda_Item.AsycudaDocument.Extended_customs_procedure == "4070")
                                && x.xcuda_Item.AsycudaDocument.AssessmentDate != null
                                && x.xcuda_Item.AsycudaDocument.AssessmentDate >= (BaseDataModel.Instance.CurrentApplicationSettings.OpeningStockDate ?? DateTime.MinValue)
                                && x.xcuda_Item.AsycudaDocument.AssessmentDate >= startDate
                                && x.xcuda_Item.AsycudaDocument.AssessmentDate.Value <= endDate)
                    .GroupBy(x => new { ItemNumber = x.xcuda_Item.xcuda_Tarification.xcuda_HScode.Precision_4, DutyFreePaid = (x.xcuda_Item.AsycudaDocument.Extended_customs_procedure == "9070" ? "Duty Free" : "Duty Paid"), pCNumber = x.Prev_reg_nbr, pLineNumber = x.Previous_item_number, pOffice = x.Prev_reg_cuo, pAssessmentDate = x.xcuda_Item.AsycudaDocument.AssessmentDate, pItemQuantity = x.Preveious_suplementary_quantity })
                    .Select(g => new PiSummary
                    {
                        ItemNumber = g.Key.ItemNumber,
                        pItemQuantity = g.Key.pItemQuantity,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        TotalQuantity = g.Sum(z => z.Suplementary_Quantity),
                        Type = "Current",
                        pCNumber = g.Key.pCNumber,
                        pLineNumber = g.Key.pLineNumber,
                        pOffice = g.Key.pOffice,
                        pAssessmentDate = g.Key.pAssessmentDate.Value
                    }).ToList();
                piSummaryHistoric.AddRange(piSummaryCurrent);
                return piSummaryHistoric;
            }
        }

        private List<ItemSalesPiSummary> GetItemSalesPiSummary(DateTime startDate, DateTime endDate)
        {
            using (var ctx = new AllocationDSContext())
            {
                var resHistoric = ctx.AsycudaSalesAllocations.Where(x => x.EntryDataDetails.Sales.EntryDataDate <= endDate)
                    .Where(x => x.PreviousItem_Id != null)
                    .GroupBy(g => new {PreviousDocumentItem = new
                    {
                        PiQuantity = g.PreviousDocumentItem.EntryPreviousItems.Where(z => z.xcuda_PreviousItem.xcuda_Item.AsycudaDocument.AssessmentDate <=  endDate).Select(z => z.xcuda_PreviousItem.Suplementary_Quantity).DefaultIfEmpty(0).Sum(),
                        pCNumber = g.PreviousDocumentItem.AsycudaDocument.CNumber,
                        pRegistrationDate = g.PreviousDocumentItem.AsycudaDocument.RegistrationDate,
                        pLineNumber = g.PreviousDocumentItem.LineNumber
                    }, ItemNumber = g.EntryDataDetails.ItemNumber,
                        DutyFreePaid = ((g.EntryDataDetails.Sales.TaxAmount ?? 0) == 0 ? "Duty Free" : "Duty Paid")
                    }).ToList();

                 var res1 = resHistoric.Select(x => new ItemSalesPiSummary
                    {
                        ItemNumber = x.Key.ItemNumber,
                        QtyAllocated = x.Select(z => z.QtyAllocated).DefaultIfEmpty(0).Sum(),
                        PiQuantity = x.Key.PreviousDocumentItem.PiQuantity,
                        pCNumber = x.Key.PreviousDocumentItem.pCNumber,
                        pRegistrationDate = x.Key.PreviousDocumentItem.pRegistrationDate,
                        pLineNumber = x.Key.PreviousDocumentItem.pLineNumber,
                        DutyFreePaid = x.Key.DutyFreePaid,
                        Type = "Historic"

                 }).ToList();
                if (ApplyCurrentChecks)
                {
                    var resCurrent = ctx.AsycudaSalesAllocations.Where(x =>
                            x.EntryDataDetails.Sales.EntryDataDate >= startDate &&
                            x.EntryDataDetails.Sales.EntryDataDate <= endDate)
                        .Where(x => x.PreviousItem_Id != null)
                        .GroupBy(g => new
                        {
                            PreviousDocumentItem = new
                            {
                                PiQuantity = g.PreviousDocumentItem.EntryPreviousItems
                                    .Where(z =>
                                        z.xcuda_PreviousItem.xcuda_Item.AsycudaDocument.AssessmentDate >= startDate &&
                                        z.xcuda_PreviousItem.xcuda_Item.AsycudaDocument.AssessmentDate <= endDate)
                                    .Select(z => z.xcuda_PreviousItem.Suplementary_Quantity).DefaultIfEmpty(0).Sum(),
                                pCNumber = g.PreviousDocumentItem.AsycudaDocument.CNumber,
                                pRegistrationDate = g.PreviousDocumentItem.AsycudaDocument.RegistrationDate,
                                pLineNumber = g.PreviousDocumentItem.LineNumber
                            },
                            ItemNumber = g.EntryDataDetails.ItemNumber,
                            DutyFreePaid = ((g.EntryDataDetails.Sales.TaxAmount ?? 0) == 0 ? "Duty Free" : "Duty Paid")
                        }).ToList();

                    var res2 = resCurrent.Select(x => new ItemSalesPiSummary
                    {
                        ItemNumber = x.Key.ItemNumber,
                        QtyAllocated = x.Select(z => z.QtyAllocated).DefaultIfEmpty(0).Sum(),
                        PiQuantity = x.Key.PreviousDocumentItem.PiQuantity,
                        pCNumber = x.Key.PreviousDocumentItem.pCNumber,
                        pRegistrationDate = x.Key.PreviousDocumentItem.pRegistrationDate,
                        pLineNumber = x.Key.PreviousDocumentItem.pLineNumber,
                        DutyFreePaid = x.Key.DutyFreePaid,
                        Type = "Current"

                    }).ToList();

                    res1.AddRange(res2);
                }
                return res1;
            }
        }

        public class ItemSalesPiSummary
        {
            public string ItemNumber { get; set; }
            public double QtyAllocated { get; set; }
            public double PiQuantity { get; set; }
            public string pCNumber { get; set; }
            public int pLineNumber { get; set; }
            public DateTime? pRegistrationDate { get; set; }
            public string DutyFreePaid { get; set; }
            public string Type { get; set; }
        }

        private List<SalesSummary> GetSalesSummary(DateTime startDate, DateTime endDate)
        {
           
            using (var ctx = new AllocationDSContext())
            {
                var salesLstHistoric = ctx.EntryDataDetails.Where(x =>  x.Sales.EntryDataDate <= endDate)//x.Sales.EntryDataDate >= startDate &&
                               .GroupBy(x => new { x.ItemNumber, DutyFreePaid =  (x.Sales.TaxAmount == 0?"Duty Free":"Duty Paid") })
                               .Select(g => new SalesSummary
                               {
                                   ItemNumber = g.Key.ItemNumber,
                                   DutyFreePaid = g.Key.DutyFreePaid,
                                   TotalQuantity = g.Sum(z => z.Quantity),
                                   TotalQtyAllocated = g.Sum(z => z.QtyAllocated),
                                   Type = "Historic"
                               }).ToList();

                var salesLstCurrent = ctx.EntryDataDetails.Where(x => x.Sales.EntryDataDate >= startDate && x.Sales.EntryDataDate <= endDate)//
                    .GroupBy(x => new { x.ItemNumber, DutyFreePaid = (x.Sales.TaxAmount == 0 ? "Duty Free" : "Duty Paid") })
                    .Select(g => new SalesSummary
                    {
                        ItemNumber = g.Key.ItemNumber,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        TotalQuantity = g.Sum(z => z.Quantity),
                        TotalQtyAllocated = g.Sum(z => z.QtyAllocated),
                        Type = "Current"
                    }).ToList();
                salesLstHistoric.AddRange(salesLstCurrent);
                return salesLstHistoric;
            }
        }

        private async Task CreateDutyFreePaidDocument(string dfp, IEnumerable<AllocationDataBlock> slst, AsycudaDocumentSet docSet, string im7Type, List<ItemSalesPiSummary> itemSalesPiSummaryLst)
        {
            try
            {


                var itmcount = 0;


                Document_Type dt;
                dt = await GetDocumentType(dfp).ConfigureAwait(false);
                if (dt == null)
                {
                    throw new ApplicationException(
                        string.Format("Null Document Type for '{0}' Contact your Network Administrator", dfp));
                }
                //TODO: Redo this check
                if (slst.ToList().SelectMany(x => x.Allocations).Select(x => x.InvoiceDate.Month).Distinct().Count() > 1)
                {
                    throw new ApplicationException(
                        string.Format("Data Contains Multiple Months", dfp));
                }

                

                StatusModel.StatusUpdate(string.Format("Creating xBond Entries - {0}", dfp));

                var cdoc = await BaseDataModel.Instance.CreateDocumentCt(docSet).ConfigureAwait(false);

                foreach (var monthyear in slst) //.Where(x => x.DutyFreePaid == dfp)
                {

                    var prevEntryId = "";
                    var prevIM7 = "";
                    var elst = PrepareAllocationsData(monthyear);

                    var effectiveAssessmentDate =
                    monthyear.Allocations.Select(x => x.InvoiceDate).Min();

                    foreach (var mypod in elst)
                    {
                        //itmcount = await InitializeDocumentCT(itmcount, prevEntryId, mypod, cdoc, prevIM7, monthyear, dt, dfp).ConfigureAwait(true);
                        if (!(mypod.EntlnData.Quantity > 0)) continue;
                        if (MaxLineCount(itmcount)
                            || InvoicePerEntry(prevEntryId, mypod)
                            || (cdoc.Document == null || itmcount == 0)
                            || IsPerIM7(prevIM7, monthyear))
                        {
                            if (itmcount != 0)
                            {
                                if (cdoc.Document != null)
                                {
                                    await SaveDocumentCT(cdoc).ConfigureAwait(false);
                                    //}
                                    //else
                                    //{
                                    cdoc = await BaseDataModel.Instance.CreateDocumentCt(docSet).ConfigureAwait(false);
                                }
                            }
                            Ex9InitializeCdoc(dt, dfp, cdoc, docSet, im7Type);
                            if (PerIM7)
                                cdoc.Document.xcuda_Declarant.Number =
                                    cdoc.Document.xcuda_Declarant.Number.Replace(
                                        docSet.Declarant_Reference_Number,
                                        docSet.Declarant_Reference_Number +
                                        "-" +
                                        monthyear.CNumber);
                            InsertEntryIdintoRefNum(cdoc, mypod.EntlnData.EntryDataDetails.First().EntryDataId);

                          //  if (cdoc.Document.xcuda_General_information == null) cdoc.Document.xcuda_General_information = new xcuda_General_information(true) {TrackingState = TrackingState.Added};
                            cdoc.Document.xcuda_General_information.Comments_free_text =
                                    $"EffectiveAssessmentDate:{effectiveAssessmentDate.ToString("MMM-dd-yyyy")}";
                            cdoc.Document.xcuda_ASYCUDA_ExtendedProperties.EffectiveRegistrationDate =
                                effectiveAssessmentDate;
                            itmcount = 0;
                        }

                        
                          var newItms =  await
                                CreateEx9EntryAsync(mypod, cdoc, itmcount, dfp, im7Type, itemSalesPiSummaryLst)
                                    .ConfigureAwait(false);
                       
                            itmcount += newItms;
                        

                        prevEntryId = mypod.EntlnData.EntryDataDetails.Count() > 0
                            ? mypod.EntlnData.EntryDataDetails[0].EntryDataId
                            : "";
                        prevIM7 = PerIM7 == true ? monthyear.CNumber : "";
                        StatusModel.StatusUpdate();
                    }

                }
                await SaveDocumentCT(cdoc).ConfigureAwait(false);
                if (cdoc.Document.ASYCUDA_Id == 0)
                {
                    //clean up
                    docSet.xcuda_ASYCUDA_ExtendedProperties.Remove(cdoc.Document.xcuda_ASYCUDA_ExtendedProperties);
                    cdoc.Document = null;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        private bool IsPerIM7(string prevIM7, AllocationDataBlock monthyear)
        {
            return (PerIM7 == true &&
                    (string.IsNullOrEmpty(prevIM7) || (!string.IsNullOrEmpty(prevIM7) && prevIM7 != monthyear.CNumber)));
        }

        private bool InvoicePerEntry(string prevEntryId, MyPodData mypod)
        {
            return (BaseDataModel.Instance.CurrentApplicationSettings
                .InvoicePerEntry == true &&
                    //prevEntryId != "" &&
                    prevEntryId != mypod.EntlnData.EntryDataDetails[0].EntryDataId);
        }

        public bool MaxLineCount(int itmcount)
        {
            return (itmcount != 0 &&
                    itmcount%
                    BaseDataModel.Instance.CurrentApplicationSettings.MaxEntryLines ==
                    0);
        }

        private async Task SaveDocumentCT(DocumentCT cdoc)
        {
            try
            {

                if (cdoc != null && cdoc.DocumentItems.Any() == true)
                {
                    if (cdoc.Document.xcuda_Valuation == null)
                        cdoc.Document.xcuda_Valuation = new xcuda_Valuation(true)
                        {
                            ASYCUDA_Id = cdoc.Document.ASYCUDA_Id,
                            TrackingState = TrackingState.Added
                        };
                    if (cdoc.Document.xcuda_Valuation.xcuda_Weight == null)
                        cdoc.Document.xcuda_Valuation.xcuda_Weight = new xcuda_Weight(true)
                        {
                            Valuation_Id = cdoc.Document.xcuda_Valuation.ASYCUDA_Id,
                            TrackingState = TrackingState.Added
                        };

                    var xcudaPreviousItems = cdoc.DocumentItems.Select(x => x.xcuda_PreviousItem).Where(x => x != null).ToList();
                    if (xcudaPreviousItems.Any())
                    {
                        cdoc.Document.xcuda_Valuation.xcuda_Weight.Gross_weight =
                            xcudaPreviousItems.Sum(x => x.Net_weight);
                    }


                    await BaseDataModel.Instance.SaveDocumentCT(cdoc).ConfigureAwait(false);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<Document_Type> GetDocumentType(string dfp)
        {
            try
            {

                Document_Type dt;
                using (var ctx = new Document_TypeService())
                {
                    if (dfp == "Duty Free")
                    {
                        dt =
                            (await
                                ctx.GetDocument_TypeByExpression(
                                    "Type_of_declaration + Declaration_gen_procedure_code == \"EX9\"")
                                    .ConfigureAwait(false)).FirstOrDefault();
                    }
                    else
                    {
                        dt =
                            (await
                                ctx.GetDocument_TypeByExpression(
                                    "Type_of_declaration + Declaration_gen_procedure_code == \"IM4\"")
                                    .ConfigureAwait(false)).FirstOrDefault();
                    }
                }
                return dt;

            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        private IEnumerable<string> CreateDutyList(IEnumerable<AllocationDataBlock> slst)
        {
            try
            {
                var dutylst = slst.Where(x => x.Allocations.Count > 0).Select(x => x.DutyFreePaid).Distinct();
                return dutylst;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private async Task<IEnumerable<AllocationDataBlock>> CreateAllocationDataBlocks(string filterExpression)
        {
            try
            {
                StatusModel.Timer("Getting ExBond Data");
                var slstSource = GetEX9Data(filterExpression);
                StatusModel.StartStatusUpdate("Creating xBond Entries", slstSource.Count());
                IEnumerable<AllocationDataBlock> slst;
                //slst = BreakOnMonthYear
                //    ? CreateBreakOnMonthYearAllocationDataBlocks(slstSource)
                //    : CreateWholeAllocationDataBlocks(slstSource);
                slst = CreateWholeAllocationDataBlocks(slstSource);
                return slst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private IEnumerable<EX9SalesAllocations> GetEX9Data(string FilterExpression)
        {
            FilterExpression =
                FilterExpression.Replace("&& (pExpiryDate >= \"" + DateTime.Now.Date.ToShortDateString() + "\")", "");

            FilterExpression += "&& PreviousDocumentItem.DoNotAllocate != true && PreviousDocumentItem.DoNotEX != true && PreviousDocumentItem.WarehouseError == null && (PreviousDocumentItem.AsycudaDocument.DocumentType == \"IM7\" || PreviousDocumentItem.AsycudaDocument.DocumentType == \"OS7\")";

           

            var exp1 = AllocationsModel.Instance.TranslateAllocationWhereExpression(FilterExpression);
            var map = new Dictionary<string, string>()
            {
                {"pIsAssessed", "PreviousDocumentItem.IsAssessed"},
                {"pRegistrationDate", "PreviousDocumentItem.AsycudaDocument.RegistrationDate"},

                // {"pExpiryDate", "(DbFunctions.AddDays(PreviousDocumentItem.AsycudaDocument.RegistrationDate.GetValueOrDefault(),730))"},
                {"Invalid", "EntryDataDetails.InventoryItem.TariffCodes.Invalid"},
                {"xBond_Item_Id == 0", "(xEntryItem_Id == null || xEntryItem_Id == 0)"}//xBondAllocations != null  && xBondAllocations.Any() == false

            };
            var exp = map.Aggregate(exp1, (current, m) => current.Replace(m.Key, m.Value));
            var res = new List<EX9SalesAllocations>();
            using (var ctx = new AllocationDSContext())
            {
                try
                {
                   IQueryable<AsycudaSalesAllocations> pres;
                    if (FilterExpression.Contains("xBond_Item_Id == 0"))
                    {
                        //TODO: use expirydate in asycuda document
                        pres = ctx.AsycudaSalesAllocations.OrderBy(x => x.AllocationId)
                            .Where(
                                x =>
                                    (DbFunctions.AddDays(
                                        ((DateTime) x.PreviousDocumentItem.AsycudaDocument.RegistrationDate), 730)) >
                                    DateTime.Now).Where(x => !x.xBondAllocations.Any());
                    }
                    else
                    {
                        pres = ctx.AsycudaSalesAllocations.OrderBy(x => x.AllocationId)
                            .Where(
                                x =>
                                    (DbFunctions.AddDays(
                                        ((DateTime) x.PreviousDocumentItem.AsycudaDocument.RegistrationDate), 730)) >
                                    DateTime.Now);
                            
                    }
                    //var res11 = pres.Where(exp).ToList();

                    //var res33 = pres.Where(@"(EntryDataDetails.Sales.EntryDataDate >= ""12/01/2017"") 
                    //                            && (EntryDataDetails.Sales.EntryDataDate <= ""12/31/2017"") 
                    //                            && EntryDataDetails.ItemNumber.Contains(""15957665"") 
                    //                            && (EntryDataDetails.Sales.TaxAmount == 0) 
                    //                            && (PreviousItem_Id != null)
                    //                            && (xEntryItem_Id == null || xEntryItem_Id == 0)
                    //                            && (PreviousDocumentItem.IsAssessed == true) 
                    //                            && (QtyAllocated != null && EntryDataDetailsId != null && EntryDataDetails.Cost > 0) 
                    //                            && (PreviousDocumentItem.AsycudaDocument.RegistrationDate != DateTime.MinValue) 
                    //                            && (PreviousDocumentItem.AsycudaDocument.CNumber != null) 
                    //                            && (EntryDataDetails.InventoryItem.TariffCodes.Invalid != true) 
                    //                            && (Status == null || Status == """") 
                    //                            && (PreviousDocumentItem.AsycudaDocument.RegistrationDate >= ""5/22/2015 12:00:00 AM"" )
                    //                            && (PreviousDocumentItem.AsycudaDocument.Extended_customs_procedure == ""7000"" )
                    //                            && (PreviousDocumentItem.DoNotAllocate != true) 
                    //                            && (PreviousDocumentItem.DoNotEX != true )
                    //                            &&( PreviousDocumentItem.WarehouseError == null )
                    //                            && (PreviousDocumentItem.AsycudaDocument.DocumentType == ""IM7"")
                    //                                ").ToList();

                    //var res22 = pres.Where(exp)
                    //    .Where(
                    //        x =>
                    //            x.xEntryItem_Id == null &&
                    //            x.PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit.Any(ss => ss.IsFirstRow == true) &&
                    //            x.PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit.FirstOrDefault(ss => ss.IsFirstRow == true)
                    //                .Suppplementary_unit_quantity != 0).ToList();

                    res = pres.Where(exp)
                        .Where(
                            x =>
                                x.xEntryItem_Id == null &&
                                x.PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit.Any(ss => ss.IsFirstRow == true) &&
                                x.PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit.FirstOrDefault(ss => ss.IsFirstRow == true)
                                    .Suppplementary_unit_quantity != 0)

                        
                        .GroupJoin(ctx.xcuda_Weight_itm, x => x.PreviousItem_Id, q => q.Valuation_item_Id,
                            (x, w) => new {x, w})
                        .Where(g => g.x.PreviousDocumentItem != null && g.w.Any() && g.x.EntryDataDetails.Sales != null)
                        .Select(c => new EX9SalesAllocations
                        {
                            AllocationId = c.x.AllocationId,
                            Commercial_Description =
                                c.x.PreviousDocumentItem == null
                                    ? null
                                    : c.x.PreviousDocumentItem.xcuda_Goods_description.Commercial_Description,
                            DutyFreePaid = c.x.EntryDataDetails.Sales.TaxAmount != 0 ? "Duty Paid" : "Duty Free",
                            EntryDataDetailsId = (int) c.x.EntryDataDetailsId,
                            InvoiceDate = c.x.EntryDataDetails.Sales.EntryDataDate,
                            InvoiceNo = c.x.EntryDataDetails.EntryDataId,
                            ItemDescription = c.x.EntryDataDetails.ItemDescription,
                            ItemNumber = c.x.EntryDataDetails.ItemNumber,
                            pCNumber = c.x.PreviousDocumentItem.AsycudaDocument.CNumber,
                            pItemCost =(double)
                                        (c.x.PreviousDocumentItem.xcuda_Tarification.Item_price/
                                         c.x.PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit
                                             .FirstOrDefault().Suppplementary_unit_quantity),
                            Status = c.x.Status,
                            PreviousItem_Id = c.x.PreviousItem_Id,
                            QtyAllocated = c.x.QtyAllocated,
                            SalesFactor = c.x.PreviousDocumentItem.SalesFactor,
                            SalesQtyAllocated = c.x.EntryDataDetails.QtyAllocated,
                            SalesQuantity = (int) c.x.EntryDataDetails.Quantity,
                            pItemNumber = c.x.PreviousDocumentItem.xcuda_Tarification.xcuda_HScode.Precision_4,
                            pTariffCode = c.x.PreviousDocumentItem.xcuda_Tarification.xcuda_HScode.Commodity_code,
                            DFQtyAllocated = c.x.PreviousDocumentItem.DFQtyAllocated,
                            DPQtyAllocated = c.x.PreviousDocumentItem.DPQtyAllocated,
                            LineNumber = c.x.PreviousDocumentItem.LineNumber,
                            Customs_clearance_office_code = c.x.PreviousDocumentItem.AsycudaDocument.Customs_clearance_office_code,
                            pQuantity =(double) c.x.PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit.FirstOrDefault().Suppplementary_unit_quantity,
                            pRegistrationDate = (DateTime) c.x.PreviousDocumentItem.AsycudaDocument.RegistrationDate,
                            pAssessmentDate = (DateTime) c.x.PreviousDocumentItem.AsycudaDocument.AssessmentDate,
                            Country_of_origin_code =
                                c.x.PreviousDocumentItem.xcuda_Goods_description.Country_of_origin_code,
                            Total_CIF_itm =c.x.PreviousDocumentItem.xcuda_Valuation_item.Total_CIF_itm,
                            Net_weight_itm = c.w.FirstOrDefault().Net_weight_itm ,
                            // Net_weight_itm = c.x.PreviousDocumentItem != null ? ctx.xcuda_Weight_itm.FirstOrDefault(q => q.Valuation_item_Id == x.PreviousItem_Id).Net_weight_itm: 0,
                            previousItems = c.x.PreviousDocumentItem.EntryPreviousItems.Select(y => y.xcuda_PreviousItem)
                                    .Where(y => y.xcuda_Item.AsycudaDocument.CNumber != null && y.xcuda_Item.AsycudaDocument.Cancelled != true)
                                    .Select(z => new previousItems()
                                    {
                                        DutyFreePaid =
                                            z.xcuda_Item.AsycudaDocument.Type_of_declaration == "EX"
                                                ? "Duty Free"
                                                : "Duty Paid",
                                        Net_weight = z.Net_weight,
                                        Suplementary_Quantity = z.Suplementary_Quantity
                                    }).ToList(),
                            TariffSupUnitLkps =
                                c.x.EntryDataDetails.InventoryItem.TariffCodes.TariffCategory.TariffCategoryCodeSuppUnit.Select(x => x.TariffSupUnitLkps).ToList()
                            //.Select(x => (ITariffSupUnitLkp)x)

                        }
                        )
                        //////////// prevent exwarehouse of item whos piQuantity > than AllocatedQuantity//////////
                        
                        .ToList();

                   


                }
                catch (Exception)
                {
                    throw;
                }
            }
            return res;
        }


        public async Task<IEnumerable<EX9AsycudaSalesAllocations>> GetEX9AsycudaSalesAllocations(string FilterExpression)
        {
            try
            {

                //get total count

                using (var ctx = new EX9AsycudaSalesAllocationsService())
                {
                    var tot = await ctx.Count(FilterExpression).ConfigureAwait(false);

                    var res = await ctx.GetEX9AsycudaSalesAllocationsByBatch(FilterExpression, tot, new List<string>()
                    {
                        "PreviousDocumentItem.EntryPreviousItems.xcuda_PreviousItem.xcuda_Item.AsycudaDocument"
                        ,
                        "PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit"

                    }).ConfigureAwait(false); //, plst

                    return res;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private IEnumerable<AllocationDataBlock> CreateWholeAllocationDataBlocks(
            IEnumerable<EX9SalesAllocations> slstSource)
        {
            IEnumerable<AllocationDataBlock> slst;
            if (PerIM7 == true)
            {
                slst = CreateWholeIM7AllocationDataBlocks(slstSource);
            }
            else
            {
                slst = CreateWholeNonIM7AllocationDataBlocks(slstSource);
            }
            return slst;
        }

        private IEnumerable<AllocationDataBlock> CreateWholeNonIM7AllocationDataBlocks(
            IEnumerable<EX9SalesAllocations> slstSource)
        {
            try
            {

                IEnumerable<AllocationDataBlock> slst;
                var source = slstSource.OrderBy(x => x.pTariffCode).ToList();

                slst = from s in source
                    group s by new {s.DutyFreePaid, MonthYear = "NoMTY"}
                    into g
                    select new AllocationDataBlock
                    {
                        MonthYear = g.Key.MonthYear,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        Allocations = g.ToList(),
                    };
                return slst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private IEnumerable<AllocationDataBlock> CreateWholeIM7AllocationDataBlocks(
            IEnumerable<EX9SalesAllocations> slstSource)
        {
            try
            {
                IEnumerable<AllocationDataBlock> slst;
                slst = from s in slstSource.OrderBy(x => x.pTariffCode)
                    group s by
                        new
                        {
                            s.DutyFreePaid,
                            MonthYear = "NoMTY",
                            CNumber = s.pCNumber
                        }
                    into g
                    select new AllocationDataBlock
                    {
                        MonthYear = g.Key.MonthYear,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        Allocations = g.ToList(),
                        CNumber = g.Key.CNumber
                    };
                return slst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private IEnumerable<AllocationDataBlock> CreateBreakOnMonthYearAllocationDataBlocks(
            IEnumerable<EX9SalesAllocations> slstSource)
        {
            try
            {
                IEnumerable<AllocationDataBlock> slst;
                if (PerIM7 == true)
                {
                    slst = CreatePerIM7AllocationDataBlocks(slstSource);
                }
                else
                {
                    slst = CreateAllocationDataBlocks(slstSource);
                }
                return slst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private IEnumerable<AllocationDataBlock> CreateAllocationDataBlocks(
            IEnumerable<EX9SalesAllocations> slstSource)
        {
            try
            {
                IEnumerable<AllocationDataBlock> slst;
                slst = from s in slstSource
                    group s by
                        new
                        {
                            s.DutyFreePaid,
                            MonthYear =
                                Convert.ToDateTime(
                                    s.InvoiceDate)
                                    .ToString("MMM-yy")
                        }
                    into g
                    select new AllocationDataBlock
                    {
                        MonthYear = g.Key.MonthYear,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        Allocations = g.ToList(),
                    };
                return slst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IEnumerable<AllocationDataBlock> CreatePerIM7AllocationDataBlocks(
            IEnumerable<EX9SalesAllocations> slstSource)
        {
            try
            {

                IEnumerable<AllocationDataBlock> slst;
                slst = from s in slstSource
                    group s by
                        new
                        {
                            s.DutyFreePaid,
                            MonthYear =
                                Convert.ToDateTime(
                                    s.InvoiceDate)
                                    .ToString("MMM-yy"),
                            CNumber = s.pCNumber
                        }
                    into g
                    select new AllocationDataBlock
                    {
                        MonthYear = g.Key.MonthYear,
                        DutyFreePaid = g.Key.DutyFreePaid,
                        Allocations = g.ToList(),
                        CNumber = g.Key.CNumber
                    };
                return slst;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private IEnumerable<MyPodData> PrepareAllocationsData(AllocationDataBlock monthyear)
        {
            try
            {
                List<MyPodData> elst;
                //if (BaseDataModel.Instance.CurrentApplicationSettings.GroupEX9 == true)
                //{
                   elst = GroupAllocationsByEx9(monthyear);
                //}
                //else
                //{
                    //elst = GroupAllocations(monthyear);
                //}

                return elst.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //private List<MyPodData> GroupAllocations(AllocationDataBlock monthyear)
        //{
        //    try
        //    {


        //        List<MyPodData> elst;
        //        elst =
        //            (from s in
        //                Enumerable.OrderBy<EX9SalesAllocations, string>(monthyear.Allocations, p => p.pTariffCode)
        //                    .GroupBy(x => x.PreviousItem_Id)
        //                    .Where(z => z.ToList().Any(q => q.SalesQuantity < 0) == false)
        //                    .SelectMany(x => x.ToList())
        //                select new MyPodData
        //                {
        //                    Allocations = new List<AsycudaSalesAllocations>()
        //                    {
        //                        new AsycudaSalesAllocations()
        //                        {
        //                            AllocationId = s.AllocationId,
        //                            EntryDataDetailsId = s.EntryDataDetailsId,
        //                            PreviousItem_Id = s.PreviousItem_Id,
        //                            Status = s.Status,
        //                            SANumber = 0,
        //                            EntryDataDetails = new EntryDataDetails()
        //                            {
        //                                EntryDataDetailsId = s.EntryDataDetailsId,
        //                                EntryDataId = s.InvoiceNo,
        //                            }

        //                        }
        //                    },
        //                    EntlnData = new AlloEntryLineData
        //                    {
        //                        ItemNumber = s.ItemNumber,
        //                        ItemDescription = s.ItemDescription,
        //                        TariffCode = s.pTariffCode,
        //                        Cost = Convert.ToDouble(s.pItemCost),
        //                        Quantity = s.QtyAllocated/s.SalesFactor,
        //                        EntryDataDetails = new List<EntryDataDetailSummary>()
        //                        {
        //                            new EntryDataDetailSummary()
        //                            {
        //                                EntryDataDetailsId = s.EntryDataDetailsId,
        //                                EntryDataId = s.InvoiceNo,
        //                                QtyAllocated = 0,
        //                            }
        //                        },
        //                        PreviousDocumentItemId = s.PreviousItem_Id.ToString(),
        //                        pDocumentItem = new pDocumentItem()
        //                        {
        //                            DFQtyAllocated = s.DFQtyAllocated,
        //                            DPQtyAllocated = s.DPQtyAllocated,
        //                            LineNumber = s.LineNumber,
        //                            previousItems = s.previousItems,
        //                            ItemQuantity = s.pQuantity,
        //                            ItemNumber = s.pItemNumber
        //                        },
        //                        EX9Allocation = new EX9Allocation()
        //                        {
        //                            Country_of_origin_code = s.Country_of_origin_code,
        //                            Customs_clearance_office_code = s.Customs_clearance_office_code,
        //                            pCNumber = s.pCNumber,
        //                            pQtyAllocated = s.DFQtyAllocated + s.DPQtyAllocated,
        //                            pQuantity = s.pQuantity,
        //                            pTariffCode = s.pTariffCode,
        //                            pRegistrationDate = s.pRegistrationDate,
        //                            SalesFactor = s.SalesFactor,
        //                            Net_weight_itm = s.Net_weight_itm,
        //                            Total_CIF_itm = s.Total_CIF_itm
        //                        }
        //                    }
        //                }).ToList();
        //        // group the returns
        //        var returnlst =
        //            (from s in
        //                Enumerable.OrderBy<EX9SalesAllocations, string>(monthyear.Allocations, p => p.pTariffCode)
        //                    .GroupBy(x => x.PreviousItem_Id)
        //                    .Where(z => z.ToList().Any(q => q.SalesQuantity < 0) == true)
        //                select new MyPodData
        //                {
        //                    Allocations =
        //                        s.Select(
        //                            x =>
        //                                new AsycudaSalesAllocations()
        //                                {
        //                                    AllocationId = x.AllocationId,
        //                                    PreviousItem_Id = x.PreviousItem_Id,
        //                                    EntryDataDetailsId = x.EntryDataDetailsId,
        //                                    Status = x.Status,
        //                                    EntryDataDetails = new EntryDataDetails()
        //                                    {
        //                                        EntryDataDetailsId = x.EntryDataDetailsId,
        //                                        EntryDataId = x.InvoiceNo,
        //                                    }
        //                                }).ToList(),
        //                    EntlnData = new AlloEntryLineData
        //                    {
        //                        ItemNumber = s.LastOrDefault().ItemNumber,
        //                        ItemDescription = s.LastOrDefault().ItemDescription,
        //                        TariffCode = s.LastOrDefault().pTariffCode,
        //                        Cost = s.LastOrDefault().pItemCost,
        //                        Quantity = s.Sum(x => x.QtyAllocated/x.SalesFactor),
        //                        EntryDataDetails = new List<EntryDataDetailSummary>()
        //                        {
        //                            new EntryDataDetailSummary()
        //                            {
        //                                EntryDataDetailsId = s.LastOrDefault().EntryDataDetailsId,
        //                                EntryDataId = s.LastOrDefault().InvoiceNo,
        //                                QtyAllocated = s.LastOrDefault().QtyAllocated
        //                            }
        //                        },
        //                        PreviousDocumentItemId = s.Key.ToString(),
        //                        InternalFreight = s.LastOrDefault().InternalFreight,
        //                        Freight = s.LastOrDefault().Freight,
        //                        Weight = s.LastOrDefault().Weight,
        //                        pDocumentItem = new pDocumentItem()
        //                        {
        //                            DFQtyAllocated = s.LastOrDefault().DFQtyAllocated,
        //                            DPQtyAllocated = s.LastOrDefault().DPQtyAllocated,
        //                            ItemQuantity = s.LastOrDefault().pQuantity,
        //                            LineNumber = s.LastOrDefault().LineNumber,
        //                            previousItems = s.LastOrDefault().previousItems
        //                        },
        //                        EX9Allocation = new EX9Allocation()
        //                        {
        //                            SalesFactor = s.LastOrDefault().SalesFactor,
        //                            Net_weight_itm = s.LastOrDefault().Net_weight_itm,
        //                            pQuantity = s.LastOrDefault().pQuantity,
        //                            pCNumber = s.LastOrDefault().pCNumber,
        //                            Customs_clearance_office_code = s.LastOrDefault().Customs_clearance_office_code,
        //                            Country_of_origin_code = s.LastOrDefault().Country_of_origin_code,
        //                            pRegistrationDate = s.LastOrDefault().pRegistrationDate,
        //                            pQtyAllocated = s.LastOrDefault().QtyAllocated,
        //                            Total_CIF_itm = s.LastOrDefault().Total_CIF_itm,
        //                            pTariffCode = s.LastOrDefault().pTariffCode
        //                        },
        //                        TariffSupUnitLkps =
        //                            s.LastOrDefault().TariffSupUnitLkps.Select(x => (ITariffSupUnitLkp) x).ToList()
        //                    }
        //                }).ToList();
        //        elst.AddRange(returnlst);
                
        //        return elst;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        private List<MyPodData> GroupAllocationsByEx9(AllocationDataBlock monthyear)
        {
            try
            {
                var elst = monthyear.Allocations
                              .OrderBy(x => x.pTariffCode)
                              .GroupBy(x => new { x.PreviousItem_Id})
                              .Select(s => new MyPodData
                              {
                                  Allocations = s.OrderByDescending(x => x.AllocationId).Select(x =>
                                     new AsycudaSalesAllocations()
                                     {
                                         AllocationId = x.AllocationId,
                                         PreviousItem_Id = x.PreviousItem_Id,
                                         EntryDataDetailsId = x.EntryDataDetailsId,
                                         Status = x.Status,
                                         QtyAllocated =  x.QtyAllocated,
                                         EntryDataDetails = new EntryDataDetails()
                                         {
                                             EntryDataDetailsId = x.EntryDataDetailsId,
                                             EntryDataId = x.InvoiceNo,
                                             Quantity = x.SalesQuantity,
                                             QtyAllocated = x.SalesQtyAllocated
                                         }
                                     }).ToList(),
                                  EntlnData = new AlloEntryLineData
                                  {
                                      ItemNumber = s.LastOrDefault().ItemNumber,
                                      ItemDescription = s.LastOrDefault().ItemDescription,
                                      TariffCode = s.LastOrDefault().pTariffCode,
                                      Cost = s.LastOrDefault().pItemCost,
                                      Quantity = s.Sum(x => x.QtyAllocated / x.SalesFactor),
                                      EntryDataDetails = s.DistinctBy(z => z.EntryDataDetailsId).Select(z =>  
                                                                new EntryDataDetailSummary()
                                                                {
                                                                    EntryDataDetailsId = z.EntryDataDetailsId,
                                                                    EntryDataId = z.InvoiceNo,
                                                                    QtyAllocated = z.SalesQuantity,
                                                                    EntryDataDate = z.InvoiceDate
                                                                }).ToList(),
                                      PreviousDocumentItemId = s.Key.ToString(),
                                      InternalFreight = s.LastOrDefault().InternalFreight,
                                      Freight = s.LastOrDefault().Freight,
                                      Weight = s.LastOrDefault().Weight,
                                      pDocumentItem = new pDocumentItem()
                                      {
                                          DFQtyAllocated = s.LastOrDefault().DFQtyAllocated,
                                          DPQtyAllocated = s.LastOrDefault().DPQtyAllocated,
                                          ItemQuantity = s.LastOrDefault().pQuantity,
                                          LineNumber = s.LastOrDefault().LineNumber,
                                          ItemNumber = s.LastOrDefault().pItemNumber,
                                          xcuda_ItemId = s.LastOrDefault().PreviousItem_Id,
                                          AssessmentDate = s.LastOrDefault().pAssessmentDate,
                                          previousItems = s.LastOrDefault().previousItems
                                      },
                                      EX9Allocation = new EX9Allocation()
                                      {
                                          SalesFactor = s.LastOrDefault().SalesFactor,
                                          Net_weight_itm = s.LastOrDefault().Net_weight_itm,
                                          pQuantity = s.LastOrDefault().pQuantity,
                                          pCNumber = s.LastOrDefault().pCNumber,
                                          Customs_clearance_office_code = s.LastOrDefault().Customs_clearance_office_code,
                                          Country_of_origin_code = s.LastOrDefault().Country_of_origin_code,
                                          pRegistrationDate = s.LastOrDefault().pRegistrationDate,
                                          pQtyAllocated = s.LastOrDefault().QtyAllocated,
                                          Total_CIF_itm = s.LastOrDefault().Total_CIF_itm,
                                          pTariffCode = s.LastOrDefault().pTariffCode                                         
                                      },
                                      TariffSupUnitLkps = s.LastOrDefault().TariffSupUnitLkps.Select(x => (ITariffSupUnitLkp)x).ToList()

                                  }
                              }).ToList();
               
                //List<MyPodData> elst;
                //elst =
                //    (from s in
                //        Enumerable.OrderBy<EX9SalesAllocations, string>(monthyear.Allocations, p => p.pTariffCode)
                //            .GroupBy(x => x.PreviousItem_Id)
                //            .Where(z => z.ToList().Any(q => q.SalesQuantity < 0) == false)
                //            .SelectMany(x => x.ToList())
                //     select new MyPodData
                //     {
                //         Allocations = new List<AsycudaSalesAllocations>()
                //            {
                //                new AsycudaSalesAllocations()
                //                {
                //                    AllocationId = s.AllocationId,
                //                    EntryDataDetailsId = s.EntryDataDetailsId,
                //                    PreviousItem_Id = s.PreviousItem_Id,
                //                    Status = s.Status,
                //                    SANumber = 0,
                //                    EntryDataDetails = new EntryDataDetails()
                //                    {
                //                        EntryDataDetailsId = s.EntryDataDetailsId,
                //                        EntryDataId = s.InvoiceNo,
                //                    }

                //                }
                //            },
                //         EntlnData = new AlloEntryLineData
                //         {
                //             ItemNumber = s.ItemNumber,
                //             ItemDescription = s.ItemDescription,
                //             TariffCode = s.pTariffCode,
                //             Cost = Convert.ToDouble(s.pItemCost),
                //             Quantity = s.QtyAllocated / s.SalesFactor,
                //             EntryDataDetails = new List<EntryDataDetailSummary>()
                //                {
                //                    new EntryDataDetailSummary()
                //                    {
                //                        EntryDataDetailsId = s.EntryDataDetailsId,
                //                        EntryDataId = s.InvoiceNo,
                //                        QtyAllocated = 0,
                //                    }
                //                },
                //             PreviousDocumentItemId = s.PreviousItem_Id.ToString(),
                //             pDocumentItem = new pDocumentItem()
                //             {
                //                 DFQtyAllocated = s.DFQtyAllocated,
                //                 DPQtyAllocated = s.DPQtyAllocated,
                //                 LineNumber = s.LineNumber,
                //                 previousItems = s.previousItems,
                //                 ItemQuantity = s.pQuantity
                //             },
                //             EX9Allocation = new EX9Allocation()
                //             {
                //                 Country_of_origin_code = s.Country_of_origin_code,
                //                 Customs_clearance_office_code = s.Customs_clearance_office_code,
                //                 pCNumber = s.pCNumber,
                //                 pQtyAllocated = s.DFQtyAllocated + s.DPQtyAllocated,
                //                 pQuantity = s.pQuantity,
                //                 pTariffCode = s.pTariffCode,
                //                 pRegistrationDate = s.pRegistrationDate,
                //                 SalesFactor = s.SalesFactor,
                //                 Net_weight_itm = s.Net_weight_itm,
                //                 Total_CIF_itm = s.Total_CIF_itm
                //             }
                //         }
                //     }).ToList();


                // group the returns by AllocationID

                //var returnlst =
                //    (from s in
                //        Enumerable.OrderBy<EX9SalesAllocations, string>(monthyear.Allocations, p => p.pTariffCode)
                //            .GroupBy(x => x.AllocationId)
                //            .Where(z => z.ToList().Any(q => q.SalesQuantity < 0) == true)
                //     select new MyPodData
                //     {
                //         Allocations =
                //             s.Select(
                //                 x =>
                //                     new AsycudaSalesAllocations()
                //                     {
                //                         AllocationId = x.AllocationId,
                //                         PreviousItem_Id = x.PreviousItem_Id,
                //                         EntryDataDetailsId = x.EntryDataDetailsId,
                //                         Status = x.Status,
                //                         EntryDataDetails = new EntryDataDetails()
                //                         {
                //                             EntryDataDetailsId = x.EntryDataDetailsId,
                //                             EntryDataId = x.InvoiceNo,
                //                         }
                //                     }).ToList(),
                //         EntlnData = new AlloEntryLineData
                //         {
                //             ItemNumber = s.LastOrDefault().ItemNumber,
                //             ItemDescription = s.LastOrDefault().ItemDescription,
                //             TariffCode = s.LastOrDefault().pTariffCode,
                //             Cost = s.LastOrDefault().pItemCost,
                //             Quantity = s.Sum(x => x.QtyAllocated / x.SalesFactor),
                //             EntryDataDetails = new List<EntryDataDetailSummary>()
                //                {
                //                    new EntryDataDetailSummary()
                //                    {
                //                        EntryDataDetailsId = s.LastOrDefault().EntryDataDetailsId,
                //                        EntryDataId = s.LastOrDefault().InvoiceNo,
                //                        QtyAllocated = s.LastOrDefault().QtyAllocated
                //                    }
                //                },
                //             PreviousDocumentItemId = s.Key.ToString(),
                //             InternalFreight = s.LastOrDefault().InternalFreight,
                //             Freight = s.LastOrDefault().Freight,
                //             Weight = s.LastOrDefault().Weight,
                //             pDocumentItem = new pDocumentItem()
                //             {
                //                 DFQtyAllocated = s.LastOrDefault().DFQtyAllocated,
                //                 DPQtyAllocated = s.LastOrDefault().DPQtyAllocated,
                //                 ItemQuantity = s.LastOrDefault().pQuantity,
                //                 LineNumber = s.LastOrDefault().LineNumber,
                //                 previousItems = s.LastOrDefault().previousItems
                //             },
                //             EX9Allocation = new EX9Allocation()
                //             {
                //                 SalesFactor = s.LastOrDefault().SalesFactor,
                //                 Net_weight_itm = s.LastOrDefault().Net_weight_itm,
                //                 pQuantity = s.LastOrDefault().pQuantity,
                //                 pCNumber = s.LastOrDefault().pCNumber,
                //                 Customs_clearance_office_code = s.LastOrDefault().Customs_clearance_office_code,
                //                 Country_of_origin_code = s.LastOrDefault().Country_of_origin_code,
                //                 pRegistrationDate = s.LastOrDefault().pRegistrationDate,
                //                 pQtyAllocated = s.LastOrDefault().QtyAllocated,
                //                 Total_CIF_itm = s.LastOrDefault().Total_CIF_itm,
                //                 pTariffCode = s.LastOrDefault().pTariffCode
                //             },
                //             TariffSupUnitLkps =
                //                 s.LastOrDefault().TariffSupUnitLkps.Select(x => (ITariffSupUnitLkp)x).ToList()
                //         }
                //     }).ToList();
                //elst.AddRange(returnlst);

                return elst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private List<MyPodData> GroupAllocationsByEx9(
        //    AllocationDataBlock monthyear)
        //{
        //    try
        //    {

        //        var elst = monthyear.Allocations.GroupBy(x => x.PreviousItem_Id);
        //        //var elst = from s in monthyear.Allocations

        //        //    //  where s.EntryDataDetails.ItemNumber == "SPG20331"
        //        //    group s by s.PreviousDocumentItem.Item_Id
        //        //    into g ;
        //        var res = new ConcurrentQueue<MyPodData>();
        //        Parallel.ForEach(elst, new ParallelOptions() {MaxDegreeOfParallelism = Environment.ProcessorCount*1},
        //            g =>
        //            {
        //                var itm =
        //                    new MyPodData
        //                    {
        //                        Allocations = g.Select(x => new AsycudaSalesAllocations()
        //                        {
        //                            AllocationId = x.AllocationId,
        //                            PreviousItem_Id = x.PreviousItem_Id,
        //                            EntryDataDetailsId = x.EntryDataDetailsId,
        //                            Status = x.Status,
        //                            QtyAllocated = x.QtyAllocated,
        //                            EntryDataDetails = new EntryDataDetails()
        //                            {
        //                                EntryDataDetailsId = x.EntryDataDetailsId,
        //                                EntryDataId = x.InvoiceNo,
        //                            }
        //                        }).ToList(),
        //                        EntlnData = new AlloEntryLineData
        //                        {
        //                            //ItemNumber = g.Key.ItemNumber,
        //                            ItemNumber = g.LastOrDefault().pItemNumber,
        //                            // InventoryItem = BaseDataModel.Instance.InventoryCache.GetSingle(x => x.ItemNumber == g.LastOrDefault().pItemNumber),
        //                            //ItemDescription = g.Key.ItemDescription,
        //                            ItemDescription = g.LastOrDefault().Commercial_Description,
        //                            //TariffCode = g.Key.TariffCode,
        //                            TariffCode = g.LastOrDefault().pTariffCode,
        //                            Cost = Convert.ToDouble(g.LastOrDefault().pItemCost),
        //                            // InventoryItem = g.Key.InventoryItems,
        //                            Quantity = g.Sum(x => x.QtyAllocated/x.SalesFactor),
        //                            EntryDataDetails =
        //                                g.Select(x => new EntryDataDetailSummary()
        //                                {
        //                                    EntryDataDetailsId = x.EntryDataDetailsId,
        //                                    EntryDataId = x.InvoiceNo,
        //                                    QtyAllocated = x.QtyAllocated
        //                                }).ToList(),
        //                            //g.Select(x => new EntryDataDetails()
        //                            //{
        //                            //    EntryDataDetailsId = x.EntryDataDetailsId,
        //                            //    EntryDataId = x.InvoiceNo,
        //                            //    QtyAllocated = x.SalesQtyAllocated,
        //                            //    Quantity = x.SalesQuantity,
        //                            //    Sales = new Sales() { EntryDataId = x.InvoiceNo, EntryDataDate = x.InvoiceDate }
        //                            //} as IEntryDataDetail).ToList(),
        //                            PreviousDocumentItemId = g.LastOrDefault().PreviousItem_Id.ToString(),
        //                            pDocumentItem = new pDocumentItem()
        //                            {
        //                                DFQtyAllocated = g.LastOrDefault().DFQtyAllocated,
        //                                DPQtyAllocated = g.LastOrDefault().DPQtyAllocated,
        //                                LineNumber = g.LastOrDefault().LineNumber,
        //                                previousItems = g.LastOrDefault().previousItems,
        //                                ItemQuantity = g.LastOrDefault().pQuantity,

        //                            },
        //                            EX9Allocation = new EX9Allocation()
        //                            {
        //                                Country_of_origin_code = g.LastOrDefault().Country_of_origin_code,
        //                                Customs_clearance_office_code = g.LastOrDefault().Customs_clearance_office_code,
        //                                pCNumber = g.LastOrDefault().pCNumber,
        //                                pQtyAllocated =
        //                                    g.LastOrDefault().DFQtyAllocated + g.LastOrDefault().DPQtyAllocated,
        //                                pQuantity = g.LastOrDefault().pQuantity,
        //                                pTariffCode = g.LastOrDefault().pTariffCode,
        //                                pRegistrationDate = g.LastOrDefault().pRegistrationDate,
        //                                Net_weight_itm = g.LastOrDefault().Net_weight_itm,
        //                                SalesFactor = g.LastOrDefault().SalesFactor,
        //                                Total_CIF_itm = g.LastOrDefault().Total_CIF_itm


        //                            },
        //                            Freight = g.LastOrDefault().Freight,
        //                            InternalFreight = g.LastOrDefault().InternalFreight,
        //                            Weight = g.LastOrDefault().Weight,
        //                            TariffSupUnitLkps =
        //                                g.LastOrDefault().TariffSupUnitLkps.Select(x => (ITariffSupUnitLkp) x).ToList()
        //                        }
        //                    };
        //                res.Enqueue(itm);
        //            });
        //        return res.ToList();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        private void InsertEntryIdintoRefNum(DocumentCT cdoc, string entryDataId)
        {
            try
            {
                if (BaseDataModel.Instance.CurrentApplicationSettings.InvoicePerEntry == true)
                {
                    cdoc.Document.xcuda_Declarant.Number = entryDataId;

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<int> CreateEx9EntryAsync(MyPodData mypod, DocumentCT cdoc, int itmcount, string dfp, string im7Type, List<ItemSalesPiSummary> itemSalesPiSummaryLst)
        {
            try
            {

                /////////////// QtyAllocated >= piQuantity cap
                /// 
                if(im7Type == "7000" || im7Type == "7400")
                    if (mypod.EntlnData.pDocumentItem.QtyAllocated < mypod.EntlnData.pDocumentItem.previousItems
                            .Select(x => x.Suplementary_Quantity).DefaultIfEmpty(0).Sum())
                    {
                        return 0;
                    }
                else
                {
                    if (mypod.EntlnData.pDocumentItem.QtyAllocated < itemSalesPiSummaryLst.Select(x => x.PiQuantity).DefaultIfEmpty(0).Sum())
                    {
                        return 0;
                    }
                    }

                //////////////////////////////////////////////////////////////////////////
                ///     Sales Cap/ Sales Bucket historic
                //var totalSalesLst = salesSummary.Where(x => x.ItemNumber == mypod.EntlnData.ItemNumber && x.Type == "Historic").ToList();
                //var piSummaries = piSummary.Where(x => x.Type == "Historic"
                                                       //&& x.pCNumber == mypod.EntlnData.EX9Allocation.pCNumber
                                                       //&& x.pLineNumber == mypod.EntlnData.pDocumentItem.LineNumber.ToString()
                                                       //&& x.pOffice == mypod.EntlnData.EX9Allocation.Customs_clearance_office_code
                                                       //&& x.pItemQuantity.ToString() == mypod.EntlnData.pDocumentItem.ItemQuantity.ToString()
                                                       //&& (x.ItemNumber == mypod.EntlnData.ItemNumber || x.ItemNumber == mypod.EntlnData.pDocumentItem.ItemNumber)).ToList();
                List<ItemSalesPiSummary> salesPiHistoric;
                List<ItemSalesPiSummary> salesPiCurrent;
                if (im7Type == "7100")
                {
                    salesPiHistoric = itemSalesPiSummaryLst.Where(x => x.ItemNumber == mypod.EntlnData.ItemNumber &&
                                                                       string.IsNullOrEmpty(x.pCNumber) &&
                                                                       x.pLineNumber == 0 &&
                                                                       x.Type == "Historic").ToList();
                    salesPiCurrent = itemSalesPiSummaryLst.Where(x => x.ItemNumber == mypod.EntlnData.ItemNumber &&
                                                                      string.IsNullOrEmpty(x.pCNumber) &&
                                                                      x.pLineNumber == 0 &&
                                                                      x.Type == "Current").ToList();

                }
                else
                {
                    salesPiHistoric = itemSalesPiSummaryLst.Where(x => x.ItemNumber == mypod.EntlnData.ItemNumber &&
                                                                       x.pCNumber == mypod.EntlnData.EX9Allocation
                                                                           .pCNumber &&
                                                                       x.pLineNumber == mypod.EntlnData.pDocumentItem
                                                                           .LineNumber &&
                                                                       x.Type == "Historic").ToList();
                    salesPiCurrent = itemSalesPiSummaryLst.Where(x => x.ItemNumber == mypod.EntlnData.ItemNumber &&
                                                                      x.pCNumber == mypod.EntlnData.EX9Allocation
                                                                          .pCNumber &&
                                                                      x.pLineNumber == mypod.EntlnData.pDocumentItem
                                                                          .LineNumber &&
                                                                      x.Type == "Current").ToList();
                }
                
                
                var docPi = docSetPi
                    .Where(x => x.pCNumber == mypod.EntlnData.EX9Allocation.pCNumber && x.pLineNumber == mypod.EntlnData.pDocumentItem.LineNumber.ToString()).Select(x => x.TotalQuantity)
                    .DefaultIfEmpty(0).Sum();

                if (im7Type == "7100")
                {
                    await Ex9Bucket(mypod, dfp, docPi, salesPiCurrent).ConfigureAwait(false);
                }
                else
                {
                    await Ex9Bucket(mypod, dfp, docPi, salesPiHistoric).ConfigureAwait(false);
                }

                var salesFactor = Math.Abs(mypod.EntlnData.EX9Allocation.SalesFactor) < 0.0001
                    ? 1
                    : mypod.EntlnData.EX9Allocation.SalesFactor;

                mypod.EntlnData.Quantity = Math.Round(mypod.EntlnData.Quantity, 2);
                if (mypod.EntlnData.Quantity <= 0) return 0;

                ////////////////////////----------------- Cap to prevent xQuantity > Sales Quantity
                double qtyAllocated = 0;
                foreach (var allocation in mypod.Allocations)
                {
                    qtyAllocated += allocation.QtyAllocated /
                                    (Math.Abs(mypod.EntlnData.EX9Allocation.SalesFactor) < 0.0001
                                        ? 1
                                        : mypod.EntlnData.EX9Allocation.SalesFactor);
                }
                // todo: ensure allocations are marked for investigation
                double qty = mypod.EntlnData.Quantity;
                if (Math.Abs(qty - Math.Round(qtyAllocated,2)) > 0.0001)
                {
                    return 0;
                }
                //////////////////////////////////////////////////////////////////////////
                ///     Sales Cap/ Sales Bucket historic

                var totalSalesHistoric = salesPiHistoric.Select(x => x.QtyAllocated).DefaultIfEmpty(0).Sum(); //salesSummary.Where(x => x.ItemNumber == mypod.EntlnData.ItemNumber && x.Type == "Historic").Select(x => x.TotalQuantity).DefaultIfEmpty(0).Sum();
                
                var totalPiHistoric = salesPiHistoric.Select(x => x.PiQuantity).DefaultIfEmpty(0).Sum();//piSummaries.Select(x => x.TotalQuantity).DefaultIfEmpty(0).Sum();

                if (totalSalesHistoric == 0) return 0; // no sales found
                if (Math.Round(totalSalesHistoric,2) < Math.Round((totalPiHistoric + docPi + mypod.EntlnData.Quantity) * salesFactor, 2))
                {
                    return 0;
                }
                ////////////////////////////////////////////////////////////////////////

                if (ApplyCurrentChecks)
                {
                    //////////////////////////////////////////////////////////////////////////
                    ///     Sales Cap/ Sales Bucket Current
                    var totalSalesCurrent = salesPiCurrent.Select(x => x.QtyAllocated).DefaultIfEmpty(0).Sum();

                    var totalPiCurrent = salesPiCurrent.Select(x => x.PiQuantity).DefaultIfEmpty(0).Sum();

                    if (totalSalesCurrent == 0) return 0; // no sales found
                    if (Math.Round(totalSalesCurrent, 2) < Math.Round((totalPiCurrent + mypod.EntlnData.Quantity) * salesFactor, 2))
                    {
                        return 0;
                    }
                }
                ////////////////////////////////////////////////////////////////////////
                //// Cap to prevent over creation of ex9 vs Item Quantity espectially if creating Duty paid and Duty Free at same time

                if (mypod.EntlnData.pDocumentItem.ItemQuantity < Math.Round((totalPiHistoric + docPi + mypod.EntlnData.Quantity) ,2))
                {
                    return 0;
                }
                //////////////////// can't delump allocations because of returns and 1kg weights issue too much items wont be able to exwarehouse
                var itmsToBeCreated = 1;
                var itmsCreated = 0;

                //itmsToBeCreated = BaseDataModel.Instance.CurrentApplicationSettings.GroupEX9 == false && mypod.EntlnData.EX9Allocation.SalesFactor == 1
                //    ? mypod.Allocations.Count()
                //    : 1;

                

                for (int i = 0; i < itmsToBeCreated; i++)
                {

                    var lineData = mypod.EntlnData; ///itmsToBeCreated == 1 ? mypod.EntlnData : CreateLineData(mypod, i);

                    global::DocumentItemDS.Business.Entities.xcuda_PreviousItem pitm = CreatePreviousItem(
                        lineData,
                        itmcount + i, dfp);
                    if (pitm.Net_weight < 0.01)
                    {
                        return 0;
                    }
                    pitm.ASYCUDA_Id = cdoc.Document.ASYCUDA_Id;


                    global::DocumentItemDS.Business.Entities.xcuda_Item itm =
                        BaseDataModel.Instance.CreateItemFromEntryDataDetail(lineData, cdoc);

                    itm.xcuda_Tarification.xcuda_HScode.Precision_4 = lineData.pDocumentItem.ItemNumber;
                    itm.IsAssessed = false;
                    itm.SalesFactor = lineData.EX9Allocation.SalesFactor;
                    //TODO:Refactor this dup code
                    if (mypod.Allocations != null)
                    {
                        var itmcnt = 1;
                        foreach (
                            var allo in (mypod.Allocations as List<AsycudaSalesAllocations>)) //.Distinct()
                        {
                            itm.xBondAllocations.Add(new xBondAllocations(true)
                            {
                                AllocationId = allo.AllocationId,
                                xcuda_Item = itm,
                                TrackingState = TrackingState.Added
                            });

                            itmcnt = AddFreeText(itmcnt, itm, allo.EntryDataDetails.EntryDataId);
                        }
                    }


                    if (im7Type == "7000" || im7Type == "7400")
                    {
                        itm.xcuda_PreviousItem = pitm;
                        pitm.xcuda_Item = itm;
                        itm.xcuda_Previous_doc.Summary_declaration =
                            $"{pitm.Prev_reg_cuo} {pitm.Prev_reg_dat} C {pitm.Prev_reg_nbr} art. {pitm.Previous_item_number}";

                        if (cdoc.DocumentItems.Select(x => x.xcuda_PreviousItem).Count() == 1 || itmcount == 0)
                        {
                            pitm.Packages_number = "1"; //(i.Packages.Number_of_packages).ToString();
                            pitm.Previous_Packages_number = pitm.Previous_item_number == "1" ? "1" : "0";
                        }
                        else
                        {
                            if (pitm.Packages_number == null)
                            {
                                pitm.Packages_number = (0).ToString(CultureInfo.InvariantCulture);
                                pitm.Previous_Packages_number = (0).ToString(CultureInfo.InvariantCulture);
                            }
                        }
                        if (pitm.Previous_Packages_number != null && pitm.Previous_Packages_number != "0")
                        {
                            var pkg = itm.xcuda_Packages.FirstOrDefault();
                            if (pkg == null)
                            {
                                pkg = new xcuda_Packages(true)
                                {
                                    Item_Id = itm.Item_Id,
                                    TrackingState = TrackingState.Added
                                };
                                itm.xcuda_Packages.Add(pkg);
                            }
                            pkg.Number_of_packages =
                                Convert.ToDouble(pitm.Previous_Packages_number);
                        }
                    }




                    itm.xcuda_Tarification.xcuda_HScode.Commodity_code = pitm.Hs_code;
                    itm.xcuda_Goods_description.Country_of_origin_code = pitm.Goods_origin;



                    itm.xcuda_Valuation_item.xcuda_Weight_itm = new xcuda_Weight_itm(true)
                    {
                        TrackingState = TrackingState.Added
                    };
                    itm.xcuda_Valuation_item.xcuda_Weight_itm.Gross_weight_itm = pitm.Net_weight;
                    itm.xcuda_Valuation_item.xcuda_Weight_itm.Net_weight_itm = pitm.Net_weight;
                    // adjusting because not using real statistical value when calculating
                    itm.xcuda_Valuation_item.xcuda_Item_Invoice.Amount_foreign_currency =
                        Convert.ToDouble(Math.Round((pitm.Current_value * pitm.Suplementary_Quantity), 2));
                    itm.xcuda_Valuation_item.xcuda_Item_Invoice.Amount_national_currency =
                        Convert.ToDouble(Math.Round(pitm.Current_value * pitm.Suplementary_Quantity, 2));
                    itm.xcuda_Valuation_item.xcuda_Item_Invoice.Currency_code = "XCD";
                    itm.xcuda_Valuation_item.xcuda_Item_Invoice.Currency_rate = 1;

                    docSetPi.Add(new PiSummary()
                    {
                        ItemNumber = mypod.EntlnData.ItemNumber,
                        DutyFreePaid = dfp,
                        TotalQuantity = mypod.EntlnData.Quantity,
                        pCNumber = mypod.EntlnData.EX9Allocation.pCNumber,
                        pLineNumber = mypod.EntlnData.pDocumentItem.LineNumber.ToString()
                    });

                    itmsCreated += 1;

                }



                return itmsCreated;
            }
            catch (Exception Ex)
            {
                throw;
            }


        }

        private static pDocumentItem oldPDocumentItem = null;
        static List<previousItems> existingPreviousItems = new List<previousItems>(); 
        private List<previousItems> Get7100PreviousItems(AlloEntryLineData entlnDataPDocumentItem, string dfp)
        {
            if(oldPDocumentItem.xcuda_ItemId == entlnDataPDocumentItem.PreviousDocumentItemId) return existingPreviousItems;
            oldPDocumentItem = entlnDataPDocumentItem.pDocumentItem;
            using (var ctx = new AllocationDSContext())
            {

            }
                return existingPreviousItems;
        }

        

        private int AddFreeText(int itmcnt, global::DocumentItemDS.Business.Entities.xcuda_Item itm, string entryDataId)
        {
            if (BaseDataModel.Instance.CurrentApplicationSettings.GroupEX9 == true) return itmcnt;
            if (itm.Free_text_1 == null) itm.Free_text_1 = "";
            itm.Free_text_1 = $"{entryDataId}|{itmcnt}";
            itmcnt += 1;

            if (itm.Free_text_1 != null && itm.Free_text_1.Length > 1)
            {
                itm.Free_text_1 = itm.Free_text_1.Length < 31 ? itm.Free_text_1.Substring(0) 
                                                              : itm.Free_text_1.Substring(0, 30);
            }


            if (itm.Free_text_2 != null && itm.Free_text_2.Length > 1)
            {
                itm.Free_text_2 = itm.Free_text_2.Length < 21 ? itm.Free_text_2.Substring(0) 
                                                              : itm.Free_text_2.Substring(0, 20);
            }
            return itmcnt;
        }
    

    private  async Task Ex9Bucket(MyPodData mypod, string dfp,  double docPi, List<ItemSalesPiSummary> itemSalesPiSummaryLst)
        {
            // prevent over draw down of pqty == quantity allocated
            try
            {
                var salesFactor = Math.Abs(mypod.EntlnData.EX9Allocation.SalesFactor) < 0.0001
                    ? 1
                    : mypod.EntlnData.EX9Allocation.SalesFactor;
                var entryLine = mypod.EntlnData;
                var asycudaLine = mypod.EntlnData.pDocumentItem;
                var allocations = mypod.Allocations;
                
                if (asycudaLine == null) throw new ApplicationException("Allocation Previous Document is Null");
                //var itemAllocated = (dfp == "Duty Free" ? asycudaLine.DFQtyAllocated : asycudaLine.DPQtyAllocated);
                //var allocationsAllocated = allocations.Sum(x => x.QtyAllocated);
               // var totalSalesQtyAllocatedHistoric = salesSummary.Select(x => x.TotalQtyAllocated).DefaultIfEmpty(0).Sum() / salesFactor; // down to run levels
                var allocationSales = itemSalesPiSummaryLst.Select(x => x.QtyAllocated).DefaultIfEmpty(0).Sum();
                var allocationPi = itemSalesPiSummaryLst.Select(x => x.PiQuantity).DefaultIfEmpty(0).Sum();
                //var totalPiQtyHistoric = piSummaries.Where(x => x.DutyFreePaid == dfp).Select(x => x.TotalQuantity).DefaultIfEmpty(0).Sum();
                var dutyFreePaidAllocated = allocationSales;//totalSalesQtyAllocatedHistoric;// itemAllocated < allocationsAllocated ? itemAllocated : allocationsAllocated;


                if (dutyFreePaidAllocated > asycudaLine.ItemQuantity) dutyFreePaidAllocated = asycudaLine.ItemQuantity;
                //if (previousItem.QtyAllocated == 0) return;

                var asycudaTotalQuantity = asycudaLine.ItemQuantity;//PdfpAllocated;//


                //if (asycudaLine.previousItems.Any() == false && entryLine.Quantity > asycudaTotalQuantity)
                //{
                //    entryLine.Quantity = asycudaTotalQuantity;
                //    return;
                //}

                var alreadyTakenOutItemsLst = asycudaLine.previousItems;
                var alreadyTakenOutDFPQty = alreadyTakenOutItemsLst.Any()? alreadyTakenOutItemsLst.Where(x => x.DutyFreePaid == dfp).Sum(xx => xx.Suplementary_Quantity):0;
                var alreadyTakenOutTotalQuantity = alreadyTakenOutItemsLst.Sum(xx => xx.Suplementary_Quantity);

                 var remainingQtyToBeTakenOut = Math.Round(allocationSales - (allocationPi + docPi) , 3); //Math.Round(dutyFreePaidAllocated - alreadyTakenOutDFPQty,3);

                if ((Math.Abs(asycudaTotalQuantity - alreadyTakenOutTotalQuantity) < 0.01) 
                    //|| (Math.Abs(dutyFreePaidAllocated - alreadyTakenOutDFPQty) < 0.01)  //////////////Allow historical adjustment
                    || (Math.Abs(remainingQtyToBeTakenOut) < .01)
                    || allocationSales < allocationPi)
                {
                    allocations.Clear();
                    entryLine.EntryDataDetails.Clear();
                    entryLine.Quantity = 0;
                    return;
                }
                //if (dutyFreePaidAllocated - (alreadyTakenOutDFPQty + entryLine.Quantity) < 0)
                //{
                
                   
                    
                    if (remainingQtyToBeTakenOut + alreadyTakenOutTotalQuantity + docPi>= asycudaTotalQuantity) remainingQtyToBeTakenOut = asycudaTotalQuantity - alreadyTakenOutTotalQuantity - docPi;
                    var salesLst = entryLine.EntryDataDetails.OrderBy(x => x.EntryDataDate).ThenBy(x => x.EntryDataDetailsId).ToList();

                    var totalAllocatedQty = allocations.Sum(x => x.QtyAllocated) / salesFactor;
                    var totalGottenOut = 0;
                        var salesrow = 0;
                    while (remainingQtyToBeTakenOut < totalAllocatedQty )
                    {

                        if (entryLine.Quantity <= 0.001) break;
                        if (Math.Abs(remainingQtyToBeTakenOut) < 0.001) break;
                        if (salesLst.Any() == false) break;

                        EntryDataDetailSummary saleItm = salesLst.ElementAtOrDefault(salesrow);
                        if (saleItm == null) break;
                        var saleAllocationsLst = allocations.Where(x => x.EntryDataDetailsId == saleItm.EntryDataDetailsId).OrderBy(x => x.AllocationId).ToList();
                        foreach (var allocation in saleAllocationsLst)
                        {
                            if (remainingQtyToBeTakenOut == totalAllocatedQty) break;
                            var wantToTakeOut = totalAllocatedQty - remainingQtyToBeTakenOut;
                            var takeOut = allocation.QtyAllocated / salesFactor;
                            if (takeOut > wantToTakeOut) takeOut = wantToTakeOut;
                            
                            if (remainingQtyToBeTakenOut > totalAllocatedQty) takeOut = totalAllocatedQty;
                            totalAllocatedQty -= takeOut;
                            allocation.QtyAllocated -= takeOut * salesFactor;
                            saleItm.QtyAllocated -= takeOut * salesFactor;
                            entryLine.Quantity -= takeOut;

                            if (Math.Abs(allocation.QtyAllocated) < 0.001)
                            {
                                allocations.Remove(allocation);
                            }
                            else
                            {
                                var sql = "";

                                // Create New allocation
                                sql +=
                                    $@"Insert into AsycudaSalesAllocations(QtyAllocated, EntryDataDetailsId, PreviousItem_Id, EANumber, SANumber)
                                           Values ({takeOut * salesFactor},{allocation.EntryDataDetailsId},{
                                            allocation.PreviousItem_Id
                                        },{allocation.EANumber + 1},{allocation.SANumber + 1})";
                                // update existing allocation
                                sql += $@" UPDATE       AsycudaSalesAllocations
                                                            SET                QtyAllocated =  QtyAllocated{(takeOut >= 0 ? $"-{takeOut * salesFactor}" : $"+{takeOut * -1 * salesFactor}")}
                                                            where	AllocationId = {allocation.AllocationId}";
                                using (var ctx = new AllocationDSContext())
                                {
                                    ctx.Database.CommandTimeout = 5;
                                    ctx.Database
                                        .ExecuteSqlCommand(TransactionalBehavior.EnsureTransaction, sql);
                                }
                            }
                            

                        }

                        if (Math.Abs(saleItm.QtyAllocated) < 0.001)
                        {
                            entryLine.EntryDataDetails.Remove(saleItm);
                           // salesLst.RemoveAt(0);
                        }
                        salesrow += 1;

                    }


                   // entryLine.Quantity = remainingQtyToBeTakenOut;
                   
                //}
                //if (entryLine.Quantity + alreadyTakenOutTotalQuantity > asycudaTotalQuantity) entryLine.Quantity = asycudaTotalQuantity - alreadyTakenOutTotalQuantity;


            }
            catch (Exception Ex)
            {
                throw;
            }

        }

        private global::DocumentItemDS.Business.Entities.xcuda_PreviousItem CreatePreviousItem(AlloEntryLineData pod, int itmcount, string dfp)
        {

            try
            {
                var previousItem = pod.pDocumentItem;

                var pitm = new global::DocumentItemDS.Business.Entities.xcuda_PreviousItem(true) { TrackingState = TrackingState.Added };
                if (previousItem == null) return pitm;

                pitm.Hs_code = pod.EX9Allocation.pTariffCode;
                pitm.Commodity_code = "00";
                pitm.Current_item_number = (itmcount + 1).ToString(); // piggy back the previous item count
                pitm.Previous_item_number = previousItem.LineNumber.ToString();


                SetWeights(pod, pitm, dfp);


                pitm.Previous_Packages_number = "0";


                pitm.Suplementary_Quantity = Convert.ToDouble(pod.Quantity);
                pitm.Preveious_suplementary_quantity = Convert.ToDouble(pod.EX9Allocation.pQuantity);


                pitm.Goods_origin = pod.EX9Allocation.Country_of_origin_code;
                double pval = pod.EX9Allocation.Total_CIF_itm;//previousItem.xcuda_Valuation_item.xcuda_Item_Invoice.Amount_national_currency;
                pitm.Previous_value = Convert.ToDouble((pval / pod.EX9Allocation.pQuantity));
                pitm.Current_value = Convert.ToDouble((pval) / Convert.ToDouble(pod.EX9Allocation.pQuantity));
                pitm.Prev_reg_ser = "C";
                pitm.Prev_reg_nbr = pod.EX9Allocation.pCNumber;
                pitm.Prev_reg_dat = pod.EX9Allocation.pRegistrationDate.Year.ToString();
                pitm.Prev_reg_cuo = pod.EX9Allocation.Customs_clearance_office_code;

                return pitm;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetWeights(AlloEntryLineData pod, global::DocumentItemDS.Business.Entities.xcuda_PreviousItem pitm, string dfp)
        {
            try
            {
                var previousItem = pod.pDocumentItem;
                if (previousItem == null) return;
                var plst = previousItem.previousItems;
                var pw = Convert.ToDouble(pod.EX9Allocation.Net_weight_itm);
                
                var iw = Convert.ToDouble((pod.EX9Allocation.Net_weight_itm
                                           / pod.EX9Allocation.pQuantity) * Convert.ToDouble(pod.Quantity));

                //var ppdfpqty =
                //        plst.Where(x => x.DutyFreePaid != dfp)
                //        .Sum(x => x.Suplementary_Quantity);
                //var pi = pod.EX9Allocation.pQuantity -
                //         plst.Where(x => x.DutyFreePaid == dfp)
                //             .Sum(x => x.Suplementary_Quantity);
                //var pdfpqty = (dfp == "Duty Free"
                //    ? previousItem.DPQtyAllocated
                //    : previousItem.DFQtyAllocated);
                var rw = plst.ToList().Sum(x => x.Net_weight);

                if ((pod.EX9Allocation.pQuantity - (plst.Sum(x => x.Suplementary_Quantity) + pod.Quantity))  <= 0)
                {

                    pitm.Net_weight = Math.Round(Convert.ToDouble(pw - rw), 2, MidpointRounding.ToEven);
                }
                else
                {
                    pitm.Net_weight = Convert.ToDouble(Math.Round(iw, 2));
                }

                pitm.Prev_net_weight = pw; //Convert.ToDouble((pw/pod.EX9Allocation.SalesFactor) - rw);
                if (pitm.Net_weight > pitm.Prev_net_weight) pitm.Net_weight = pitm.Prev_net_weight;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Ex9InitializeCdoc(Document_Type dt, string dfp, DocumentCT cdoc, AsycudaDocumentSet ads, string im7Type)
        {
            try
            {

                cdoc.Document.xcuda_ASYCUDA_ExtendedProperties.AutoUpdate = false;
                BaseDataModel.Instance.IntCdoc(cdoc, dt, ads);

                switch (dfp)
                {
                    case "Duty Free":
                        var Exp = BaseDataModel.Instance.ExportTemplates.FirstOrDefault(y => y.Description.ToUpper() == "EX9".ToUpper());
                        if (Exp.Customs_Procedure == null || string.IsNullOrEmpty(Exp.Customs_Procedure))
                        {
                            throw new ApplicationException("Export Template default Customs Procedures not Configured!");
                        }
                        cdoc.Document.xcuda_ASYCUDA_ExtendedProperties.Description = "Duty Free Entries";
                        var df =
                            BaseDataModel.Instance.Customs_Procedures.AsEnumerable()
                                .FirstOrDefault(x => x.DisplayName == (im7Type == "7000" ? "9070-DIS" : "9071-000") || x.DisplayName == (im7Type == "7400" ? "9074-000" : "9074-000"));
                                        //((Exp == null || string.IsNullOrEmpty(Exp.Customs_Procedure))
                                        //    ? "9070-000"
                                        //    : Exp.Customs_Procedure));

                            BaseDataModel.Instance.AttachCustomProcedure(cdoc, df);
                        
                        break;
                    case "Duty Paid":
                        var Exp1 = BaseDataModel.Instance.ExportTemplates.FirstOrDefault(y => y.Description == "IM4");
                        if (Exp1.Customs_Procedure == null || string.IsNullOrEmpty(Exp1.Customs_Procedure))
                        {
                            throw new ApplicationException("Export Template default Customs Procedures not Configured!");
                        }
                        cdoc.Document.xcuda_ASYCUDA_ExtendedProperties.Description = "Duty Paid Entries";
                        var dp =
                            BaseDataModel.Instance.Customs_Procedures.AsEnumerable()
                                .FirstOrDefault(
                                    x =>
                                        x.DisplayName == (im7Type == "7000" ? "4070-000" : "4071-000") || x.DisplayName == (im7Type == "7400" ? "4074-000" : "4074-000"));
                        //((Exp1 == null || string.IsNullOrEmpty(Exp1.Customs_Procedure))
                        //    ? "4070-000"
                        //    : Exp1.Customs_Procedure));
                        BaseDataModel.Instance.AttachCustomProcedure(cdoc, dp);
                        break;
                    default:
                        break;
                }

                AllocationsModel.Instance.AddDutyFreePaidtoRef(cdoc, dfp, ads);

            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public class AlloEntryLineData: BaseDataModel.IEntryLineData //: AllocationsModel.AlloEntryLineData
        {
            public double Cost { get; set; }
            public List<EntryDataDetailSummary> EntryDataDetails { get; set; }
            public double Weight { get; set; }
            public double InternalFreight { get; set; }
            public double Freight { get; set; }
            public List<ITariffSupUnitLkp> TariffSupUnitLkps { get; set; }
            public string ItemDescription { get; set; }
            public string ItemNumber { get; set; }
            public string PreviousDocumentItemId { get; set; }
            public double Quantity { get; set; }
            public string TariffCode { get; set; }
            public pDocumentItem pDocumentItem { get; set; }
            public EX9Allocation EX9Allocation { get; set; }
            
        }

        public class pDocumentItem
        {
            public int LineNumber { get; set; }
            public double DPQtyAllocated { get; set; }
            public List<previousItems> previousItems { get; set; }
            public double DFQtyAllocated { get; set; }

            public double QtyAllocated => DFQtyAllocated + DPQtyAllocated;
            public DateTime AssessmentDate { get; set; }
            public double ItemQuantity { get; set; }
            public string ItemNumber { get; set; }
            public object xcuda_ItemId { get; set; }
        }

        public class EX9Allocation
        {
            public string pTariffCode { get; set; }
            public double pQuantity { get; set; }
            public string Country_of_origin_code { get; set; }
            public double Total_CIF_itm { get; set; }
            public string pCNumber { get; set; }
            public DateTime pRegistrationDate { get; set; }
            public string Customs_clearance_office_code { get; set; }
            public double Net_weight_itm { get; set; }
            public double pQtyAllocated { get; set; }
            public double SalesFactor { get; set; }
        }

        public class SalesSummary
        {
            public string ItemNumber { get; set; }
            public string DutyFreePaid { get; set; }
            public double TotalQuantity { get; set; }
            public double TotalQtyAllocated { get; set; }
            public string Type { get; set; }
        }
    }

    internal class x7100SalesPi
    {
        public string ItemNumber { get; set; }
        public double ItemQuantity { get; set; }
        public double PiQuantity { get; set; }
        public double DPQtyAllocated { get; set; }
        public double DPPi { get; set; }
        public double DFQtyAllocated { get; set; }
        public double DFPi { get; set; }
    }

    public class PiSummary
    {
        public string ItemNumber { get; set; }
        public string DutyFreePaid { get; set; }
        public double TotalQuantity { get; set; }
        public string Type
        { get; set; }

        public string pCNumber { get; set; }
        public string pLineNumber { get; set; }
        public string pOffice { get; set; }
        public double pItemQuantity { get; set; }
        public DateTime pAssessmentDate { get; set; }
    }

    public class previousItems
    {
        public string DutyFreePaid { get; set; }
        public double Suplementary_Quantity { get; set; }
        public double Net_weight { get; set; }
    }


    public class EX9SalesAllocations
    {
        public string pTariffCode { get; set; }
        public string DutyFreePaid { get; set; }
        public string pCNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? PreviousItem_Id { get; set; }
        public int SalesQuantity { get; set; }
        public int AllocationId { get; set; }
        public int EntryDataDetailsId { get; set; }
        public string Status { get; set; }
        public string InvoiceNo { get; set; }
        public string ItemNumber { get; set; }
        public string pItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public double pItemCost { get; set; }
        public double QtyAllocated { get; set; }
        public string Commercial_Description { get; set; }
        public double SalesQtyAllocated { get; set; }
        public double DFQtyAllocated { get; set; }
        public double DPQtyAllocated { get; set; }
        public int LineNumber { get; set; }
        public List<previousItems> previousItems { get; set; }
        public string Country_of_origin_code { get; set; }
        public string Customs_clearance_office_code { get; set; }
        public double pQuantity { get; set; }
        public DateTime pRegistrationDate { get; set; }
        public double Net_weight_itm { get; set; }
        public double Total_CIF_itm { get; set; }
        public double Freight { get; set; }
        public double InternalFreight { get; set; }
        public double Weight { get; set; }
        public List<TariffSupUnitLkps> TariffSupUnitLkps { get; set; }
        public double SalesFactor { get; set; }
        public DateTime pAssessmentDate { get; set; }
    }

    public class AllocationDataBlock
    {
        public string MonthYear { get; set; }
        public string DutyFreePaid { get; set; }
        public List<EX9SalesAllocations> Allocations { get; set; }
        public string CNumber { get; set; }
    }

    public class MyPodData
    {
        public List<AsycudaSalesAllocations> Allocations { get; set; }
        public CreateEx9Class.AlloEntryLineData EntlnData { get; set; }
    }

    public class AlloEntryLineData
    {
    }
}