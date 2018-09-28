﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data.Entity;
using Core.Common.Converters;
using DocumentDS.Business.Entities;
using System.Threading.Tasks;
using AllocationDS.Business.Entities;

using Core.Common.UI;
using AllocationDS.Business.Services;
using TrackableEntities;
using TrackableEntities.Common;
using WaterNut.Business.Entities;
using WaterNut.Interfaces;
using xcuda_Item = AllocationDS.Business.Entities.xcuda_Item;
using xcuda_ItemService = DocumentItemDS.Business.Services.xcuda_ItemService;


namespace WaterNut.DataSpace
{
    public class AllocationsModel
    {
        
        
        private readonly CreateOPSClass _createOpsClassClass = new CreateOPSClass();
       // private readonly CreateIncompOPSClass _createIncompOpsClass = new CreateIncompOPSClass();
        private readonly BuildSalesReportClass _buildSalesReportClass = new BuildSalesReportClass();

        private static readonly AllocationsModel _instance;
        static AllocationsModel()
        {
            _instance = new AllocationsModel();
        }

        public static AllocationsModel Instance
        {
            get { return _instance; }
        }
        
       

        public class MyPodData
        {
            public List<AsycudaSalesAllocations> Allocations { get; set; }
            public AlloEntryLineData EntlnData { get; set; }
        }


        //TODO: Refactor this
        private  string CleanText(string p)
        {
            p = Regex.Replace(p, @"[\-0]+", "");
            return p;
        }


        public void AddDutyFreePaidtoRef(DocumentCT cdoc, string dfp, AsycudaDocumentSet docSet)
        {
            try
            {


                switch (dfp)
                {
                    case "Duty Free":

                        cdoc.Document.xcuda_Declarant.Number = docSet.Declarant_Reference_Number
                                                                + "-F" +//+ "-DF"
                                                               cdoc.Document.xcuda_ASYCUDA_ExtendedProperties.FileNumber
                                                                   .ToString();
                        break;
                    case "Duty Paid":
                        cdoc.Document.xcuda_Declarant.Number = docSet.Declarant_Reference_Number
                                                               + "-P" +// + "-DP"
                                                               cdoc.Document.xcuda_ASYCUDA_ExtendedProperties.FileNumber
                                                                   .ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<AsycudaSalesAllocations>> GetAsycudaSalesAllocations(string FilterExpression)
        {
            try
            {
                // create dictionary map and run replace
                var exp = TranslateAllocationWhereExpression(FilterExpression);


                using (var ctx = new AsycudaSalesAllocationsService())
                {
                       
                       var res =  await ctx.GetAsycudaSalesAllocationsByExpression(exp, 
                            new List<string>()
                            {
                                "xBondAllocations",
                               // "EntryDataDetails",
                               // "EntryDataDetails.EntryDataDetailsEx",
                               // "EntryDataDetails.InventoryItem",
                                "EntryDataDetails.InventoryItem.TariffCodes.TariffCategory.TariffSupUnitLkps",
                                "EntryDataDetails.Sales",
                               // "PreviousDocumentItem",
                                //"PreviousDocumentItem.EX",
                                "PreviousDocumentItem.xcuda_Goods_description",
                                "PreviousDocumentItem.xcuda_Tarification.xcuda_HScode",
                                "PreviousDocumentItem.xcuda_Tarification.xcuda_Supplementary_unit",
                                "PreviousDocumentItem.xcuda_Taxation.xcuda_Taxation_line",
                                "PreviousDocumentItem.xcuda_Valuation_item.xcuda_Item_Invoice",
                                "PreviousDocumentItem.xcuda_Valuation_item.xcuda_Weight_itm",
                                "PreviousDocumentItem.AsycudaDocument",
                                //"PreviousDocumentItem.xcuda_PreviousItems",
                                "PreviousDocumentItem.EntryPreviousItems.xcuda_PreviousItem.xcuda_Item.AsycudaDocument"
                               // "PreviousDocumentItem.xcuda_PreviousItems.xcuda_Item"
                            }).ConfigureAwait(false);

                    return res;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public string TranslateAllocationWhereExpression(string FilterExpression)
        {
            var map = new Dictionary<string, string>()
            {
                {"InvoiceDate", "EntryDataDetails.Sales.EntryDataDate"},
                {"InvoiceNo", "EntryDataDetails.EntryDataId"},
                {"SalesQtyAllocated", "EntryDataDetails.QtyAllocated"},
                {"SalesQuantity", "EntryDataDetails.Quantity"},
                {"Cost", "EntryDataDetails.Cost"},
                {"TaxAmount", "EntryDataDetails.Sales.TaxAmount"},
                {"ItemNumber", "EntryDataDetails.ItemNumber"},
                {"ItemDescription", "EntryDataDetails.ItemDescription"},
                {"TariffCode", "EntryDataDetails.InventoryItem.TariffCode"},
                {"pCNumber", "PreviousDocumentItem.AsycudaDocument.CNumber"},
                {"pLineNumber", "PreviousDocumentItem.LineNumber"},
                {"PreviousItem_Id == 0", "PreviousItem_Id == null"}
            };


            var exp = map.Aggregate(FilterExpression, (current, m) => current.Replace(m.Key, m.Value));
            return exp;
        }


        //System.Windows.Forms.MessageBox.


        public async Task ManuallyAllocate(AsycudaSalesAllocations currentAsycudaSalesAllocation ,xcuda_Item PreviousItemEx)
        {
            double aqty;
            using (var ctx = new AllocationDSContext() {StartTracking = true})
            {
                var entryDataDetails =
                    ctx.EntryDataDetails.Include(x => x.Sales).First(
                        x => x.EntryDataDetailsId == currentAsycudaSalesAllocation.EntryDataDetailsId.Value);

               var asycudaItem = ctx.xcuda_Item.Include(x => x.xcuda_Tarification.xcuda_Supplementary_unit).First(x => x.Item_Id == PreviousItemEx.Item_Id);
                ctx.AsycudaSalesAllocations.Attach(currentAsycudaSalesAllocation);

                if (entryDataDetails.Quantity >=
                    (asycudaItem.ItemQuantity - asycudaItem.QtyAllocated))
                {
                    aqty = asycudaItem.ItemQuantity - asycudaItem.QtyAllocated;
                }
                else
                {
                    aqty = entryDataDetails.Quantity;
                }
                currentAsycudaSalesAllocation.PreviousItem_Id = asycudaItem.Item_Id;

                currentAsycudaSalesAllocation.QtyAllocated = aqty;
                entryDataDetails.QtyAllocated += aqty;
                if ((entryDataDetails.Sales as Sales).DutyFreePaid == "Duty Free")
                {
                    asycudaItem.DFQtyAllocated += aqty;
                }
                else
                {
                    asycudaItem.DPQtyAllocated += aqty;
                }

                currentAsycudaSalesAllocation.Status = "Manual Allocation";

                ctx.SaveChanges();
                currentAsycudaSalesAllocation.AcceptChanges();
            }
            // SaveAsycudaSalesAllocation(currentAsycudaSalesAllocation);
            
        }

        private async  void SaveAsycudaSalesAllocation(AsycudaSalesAllocations allo)
        {
            using (var ctx = new AsycudaSalesAllocationsService())
            {
                await ctx.UpdateAsycudaSalesAllocations(allo).ConfigureAwait(false);
            }
        }

        public async Task ClearAllocations(string filterExpression)
        {
            var lst = await GetAsycudaSalesAllocations(filterExpression).ConfigureAwait(false);
            await ClearAllocations(lst).ConfigureAwait(false);
        }

        public async Task ClearAllAllocations()
        {
            StatusModel.Timer("Clear All Existing Allocations");

            using (var ctx = new AllocationDSContext())
            {
               await ctx.Database.ExecuteSqlCommandAsync(TransactionalBehavior.EnsureTransaction,
                    "delete from AsycudaSalesAllocations" +
                    "\r\n\r\n" +
                    "update xcuda_Item" + "\r\n" +
                    "set DFQtyAllocated = 0, DPQtyAllocated = 0\r\n\r\n\r\n" +
                    "update EntryDataDetails\r\n" + "set QtyAllocated = 0\r\n\r\n" +
                    "update xcuda_PreviousItem\r\nset QtyAllocated = 0\r\n\r\n" +
                    "update SubItems \r\nset QtyAllocated = 0").ConfigureAwait(false);
            }
        }


        public  async Task ClearAllocations(IEnumerable<AsycudaSalesAllocations> alst)
        {


                    foreach (var allo in alst)
                    {

                        await ClearAllocation(allo).ConfigureAwait(false);
                        StatusModel.StatusUpdate();
                    }


                    var neAllo = alst.Where(x => x.EntryDataDetails == null && x.PreviousDocumentItem != null).ToList();
                    StatusModel.StartStatusUpdate("Deleting Null EntryData Allocations", neAllo.Count());

                    foreach (var allo in neAllo)
                    {
                        await ClearAllocation(allo).ConfigureAwait(false);
                        StatusModel.StatusUpdate();
                    }
                
                StatusModel.Timer("ReLoading Data..");

                
                
                StatusModel.StopStatusUpdate();
                

        }




        private async Task<List<AsycudaSalesAllocations>> GetSalesData(string dfp)
        {
            StatusModel.Timer("Loading Data...");
            List<AsycudaSalesAllocations> alst = null;
            using (var ctx = new AsycudaSalesAllocationsService())
            {
                alst = (await ctx.GetAsycudaSalesAllocations().ConfigureAwait(false))
                                    .Where(x => x.EntryDataDetails.Sales != null
                                        && x.PreviousDocumentItem != null
                                        // && x.EntryDataDetails.ItemDescription.Contains("POLLEN-BR-B") // && x.PreviousItemEx.xcuda_Tarification.xcuda_HScode.Precision_4.Contains("DKR")// // 
                                        && x.PreviousDocumentItem.AsycudaDocument.CNumber != null)
                                     .AsEnumerable()
                                     .Where(x => (x.EntryDataDetails.Sales as Sales).DutyFreePaid == dfp)
                                     .OrderBy(x => x.EntryDataDetails.Sales.EntryDataDate).ThenBy(x => x.EntryDataDetails.EntryDataDetailsId).ToList();
            }
            StatusModel.Timer("Cleaning Data...");

            using (var ctx = new global::AllocationDS.Business.Services.xcuda_ItemService())
            {
                alst.ForEach(x => x.PreviousDocumentItem.EntryPreviousItems.Select(p => p.xcuda_PreviousItem).ToList().ForEach(z => z.QtyAllocated = 0));
                alst.ForEach(x => x.xBondAllocations.Clear());
            }
            return alst;
        }


        public  void Send2Excel(List<AsycudaSalesAllocations> lst)
        {
            var s = new ExportToCSV<AllocationsModel.AllocationsExcelLine, List<AllocationsModel.AllocationsExcelLine>>();
            s.dataToPrint = (from sa in lst
                             let sales = sa.EntryDataDetails.Sales as Sales
                             let prevEntry = sa.PreviousDocumentItem

                             select new AllocationsModel.AllocationsExcelLine
                             {
                                 DutyFreePaid = sales == null ? null : sales.DutyFreePaid,
                                 InvoiceNo = sales == null ? null : sales.INVNumber,
                                 InvoiceDate = sales == null ? DateTime.MinValue : sales.EntryDataDate,
                                 SalesAllocationNo = sales == null ? 0 : Convert.ToInt32(sa.SANumber),
                                 SalesQty = sales == null ? 0 : Convert.ToDouble(sa.EntryDataDetails.Quantity),
                                 SalesQtyAllocated = sales == null ? 0 : Convert.ToDouble(sa.EntryDataDetails.QtyAllocated),
                                 ItemNumber = sales == null ? null : sa.EntryDataDetails.ItemNumber,
                                 ItemDescription = sales == null ? null : sa.EntryDataDetails.ItemDescription,
                                 UnitCost = sales == null ? 0 : Convert.ToDouble(sa.EntryDataDetails.Cost),
                                 SalesValue = sales == null ? 0 : Convert.ToDouble(sa.EntryDataDetails.Cost) * Convert.ToDouble(sa.EntryDataDetails.Quantity),
                                 AllocatedValue = sales == null ? 0 : Convert.ToDouble(sa.EntryDataDetails.Cost) * Convert.ToDouble(sa.QtyAllocated),
                                 TariffCode = prevEntry == null ? null : prevEntry.TariffCode,
                                 CIF = prevEntry == null ? 0 : sa.PreviousDocumentItem.xcuda_Valuation_item.Total_CIF_itm / Convert.ToDouble(sa.PreviousDocumentItem.ItemQuantity),
                                 DutyLiability = prevEntry == null ? 0 : Convert.ToDouble(sa.PreviousDocumentItem.DutyLiability),
                                 ItemQuantity = prevEntry == null ? 0 : Convert.ToDouble(sa.PreviousDocumentItem.ItemQuantity),
                                 AllocatedQty = sales == null ? 0 : Convert.ToDouble(sa.QtyAllocated),
                                 PreviousLineNumber = prevEntry == null ? 0 : sa.PreviousDocumentItem.LineNumber,
                                 PreviousCNumber = prevEntry == null ? null : sa.PreviousDocumentItem.AsycudaDocument.CNumber,
                                 PreviousRegDate = prevEntry == null ? DateTime.MinValue : Convert.ToDateTime(sa.PreviousDocumentItem.AsycudaDocument.RegistrationDate),
                                 AllocationStatus = sa.Status,
                                 PiQuantity = prevEntry == null ? 0 : Convert.ToDouble(sa.PreviousDocumentItem.EntryPreviousItems.Select(p => p.xcuda_PreviousItem).Sum(x => x.Suplementary_Quantity)),
                                 DutyFreePi = prevEntry == null || sa.PreviousDocumentItem.EntryPreviousItems.Select(p => p.xcuda_PreviousItem).Any() == false ? 0 : sa.PreviousDocumentItem.EntryPreviousItems.Select(p => p.xcuda_PreviousItem).Where(x => x.DutyFreePaid == "Duty Free").Sum(x => x.Suplementary_Quantity),
                                 DutyPaidPi = prevEntry == null || sa.PreviousDocumentItem.EntryPreviousItems.Select(p => p.xcuda_PreviousItem).Any() == false ? 0 : sa.PreviousDocumentItem.EntryPreviousItems.Select(p => p.xcuda_PreviousItem).Where(x => x.DutyFreePaid == "Duty Paid").Sum(x => x.Suplementary_Quantity),
                                 DFQtyAllocated = prevEntry == null ? 0 : Convert.ToDouble(sa.PreviousDocumentItem.DFQtyAllocated),
                                 DPQtyAllocated = prevEntry == null ? 0 : Convert.ToDouble(sa.PreviousDocumentItem.DPQtyAllocated),
                                 Ex9Doc = sa.xBondEntry == null ? "" : BaseDataModel.Instance.GetDocument(sa.xBondEntry.ASYCUDA_Id).Result.ReferenceNumber,
                                 Ex9DocLine = sa.xBondEntry == null ? 0 : sa.xBondEntry.LineNumber
                             }).ToList();
            s.GenerateReport();
        }

        

        public class AllocationsExcelLine
        {
            public string DutyFreePaid { get; set; }
            public string InvoiceNo { get; set; }
            public DateTime InvoiceDate { get; set; }
            public int SalesAllocationNo { get; set; }
            public double SalesQty { get; set; }
            public double SalesQtyAllocated { get; set; }
            public string ItemNumber { get; set; }
            public string ItemDescription { get; set; }
            public double UnitCost { get; set; }
            public double SalesValue { get; set; }
            public double AllocatedValue { get; set; }
            public string TariffCode { get; set; }
            public double CIF { get; set; }
            public double DutyLiability { get; set; }
            public double ItemQuantity { get; set; }
            public double AllocatedQty { get; set; }
            public int PreviousLineNumber { get; set; }
            public string PreviousCNumber { get; set; }
            public DateTime PreviousRegDate { get; set; }
            public string AllocationStatus { get; set; }
            public double PiQuantity { get; set; }
            public double DFQtyAllocated { get; set; }
            public double DutyFreePi { get; set; }
            public double DPQtyAllocated { get; set; }
            public double DutyPaidPi { get; set; }
            public string Ex9Doc { get; set; }
            public int Ex9DocLine { get; set; }
        }


        public class AlloEntryLineData : BaseDataModel.IEntryLineData
        {
            public string ItemNumber { get; set; }
            public string ItemDescription { get; set; }
            public string TariffCode { get; set; }
            public double Cost { get; set; }
            public string PreviousDocumentItemId { get; set; }
            public double Quantity { get; set; }
            public List<EntryDataDetailSummary> EntryDataDetails { get; set; }
           // public IDocumentItem PreviousDocumentItem { get; set; }
            public IInventoryItem InventoryItem { get; set; }
            public double Weight { get; set; }
            public double InternalFreight { get; set; }
            public double Freight { get; set; }
            public List<ITariffSupUnitLkp> TariffSupUnitLkps { get; set; }
            // public InventoryItem InventoryItem { get; set; }
          
           public EX9AsycudaSalesAllocations EX9Allocation { get; set; }
            public string EntryData { get; set; }
        }


        

        //public List<AsycudaSalesAllocations> CurrentAllocations
        //{
        //    get
        //    {
        //        if (QuerySpace.AllocationQS.ViewModels.AllocationsModel.Instance.SelectedAsycudaSalesAllocationsExs != null)
        //        {
        //            var lst = QuerySpace.AllocationQS.ViewModels.AllocationsModel.Instance.SelectedAsycudaSalesAllocationsExs;
        //            var res = new List<AsycudaSalesAllocations>();
        //            using (var ctx = new AsycudaSalesAllocationsService())
        //            {
        //                foreach (var item in lst)
        //                {
        //                    res.Add(ctx.GetAsycudaSalesAllocations(item.AllocationId.ToString()).Result);
        //                }
        //            }
        //            return res;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}

        public CreateEx9Class CreateEX9Class
        {
            get { return CreateEx9Class.Instance; }
        }

        public CreateOPSClass CreateOpsClassClass
        {
            get { return _createOpsClassClass; }
        }

        //public CreateErrOPS CreateErrOps
        //{
        //    get { return CreateErrOPS.Instance; }
        //}

        //public CreateIncompOPSClass CreateIncompOpsClass
        //{
        //    get { return _createIncompOpsClass; }
        //}

        public async Task ClearAllocation(AsycudaSalesAllocations allo)
        {
            /////////// took out entrydatadetails update

            if (allo.EntryDataDetails != null && (allo.EntryDataDetails.TrackingState != TrackingState.Deleted))
            {
                allo.EntryDataDetails.QtyAllocated = 0;
                allo.EntryDataDetails = null;
            }

            if (allo.PreviousDocumentItem != null)
            {

                using (var ctx = new xcuda_ItemService())
                {

                    var res = await ctx.Getxcuda_ItemByKey(allo.PreviousItem_Id.ToString()).ConfigureAwait(false);
                    res.DFQtyAllocated = 0;
                    res.DPQtyAllocated = 0;

                    foreach (var sitm in res.SubItems)
                    {
                        sitm.QtyAllocated = 0;
                    }

                    foreach (var ed in res.xcuda_PreviousItems.Select(x => x.xcuda_PreviousItem))
                    {

                        ed.QtyAllocated = 0;
                    }
                    await ctx.Updatexcuda_Item(res).ConfigureAwait(false);

                }

                allo.PreviousDocumentItem = null;
            }


            using (var ctx = new AsycudaSalesAllocationsService())
            {
                await ctx.DeleteAsycudaSalesAllocations(allo.AllocationId.ToString()).ConfigureAwait(false);
            }

        }
       
    }
}