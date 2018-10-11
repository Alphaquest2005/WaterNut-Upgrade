﻿using DocumentDS.Business.Entities;
using DocumentDS.Business.Services;
using DocumentItemDS.Business.Entities;
using DocumentItemDS.Business.Services;
using InventoryDS.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
//using WaterNut.DataLayer;
using TrackableEntities;
using Asycuda421;
using TrackableEntities.Common;
using TrackableEntities.EF6;
using WaterNut.Business.Entities;
using WaterNut.Interfaces;

using Customs_Procedure = DocumentDS.Business.Entities.Customs_Procedure;
using xcuda_Item = DocumentItemDS.Business.Entities.xcuda_Item;
using xcuda_PreviousItem = DocumentItemDS.Business.Entities.xcuda_PreviousItem;
using DIBaseDataModel = WaterNut.DataSpace.DocumentItemDS.DataModels.BaseDataModel;
using DBaseDataModel = WaterNut.DataSpace.DocumentDS.DataModels.BaseDataModel;
using Document_Type = DocumentDS.Business.Entities.Document_Type;
using EntryPreviousItems = DocumentItemDS.Business.Entities.EntryPreviousItems;
using xcuda_Goods_description = DocumentItemDS.Business.Entities.xcuda_Goods_description;
using xcuda_HScode = DocumentItemDS.Business.Entities.xcuda_HScode;
using xcuda_Item_Invoice = DocumentItemDS.Business.Entities.xcuda_Item_Invoice;
using xcuda_Supplementary_unit = DocumentItemDS.Business.Entities.xcuda_Supplementary_unit;
using xcuda_Tarification = DocumentItemDS.Business.Entities.xcuda_Tarification;
using xcuda_Taxation = DocumentItemDS.Business.Entities.xcuda_Taxation;
using xcuda_Taxation_line = DocumentItemDS.Business.Entities.xcuda_Taxation_line;
using xcuda_Valuation_item = DocumentItemDS.Business.Entities.xcuda_Valuation_item;
using xcuda_Weight = DocumentDS.Business.Entities.xcuda_Weight;
using xcuda_Weight_itm = DocumentItemDS.Business.Entities.xcuda_Weight_itm;


namespace WaterNut.DataSpace.Asycuda
{
    public partial class AsycudaToDataBase421
    {
        private static readonly AsycudaToDataBase421 instance;
        static AsycudaToDataBase421()
        {
            instance = new AsycudaToDataBase421();
           
       
        }

         public static AsycudaToDataBase421 Instance
        {
            get { return instance; }
        }

        private DocumentCT da;
        private ASYCUDA a;

       
        //private static DataCache<AsycudaDocumentItem> _asycudaDocumentItemCache;
        //private static DataCache<AsycudaDocument> _asycudaDocumentCache;

        private bool updateItemsTariffCode = false;
        private bool importOnlyRegisteredDocuments = true;

        [XmlIgnore()]
        public bool UpdateItemsTariffCode
        {
            get { return updateItemsTariffCode; }
            set { updateItemsTariffCode = value; }
        }

        [XmlIgnore()]
        public bool ImportOnlyRegisteredDocuments
        {
            get { return importOnlyRegisteredDocuments; }
            set { importOnlyRegisteredDocuments = value; }
        }
        public bool OverwriteExisting { get; set; }
        public bool NoMessages { get; set; }

        public bool LinkPi { get; set; }
        public async Task SaveToDatabase(ASYCUDA adoc, AsycudaDocumentSet docSet)
        {

            try
            {

                // db = new WaterNutDBEntities();
                a = adoc;
                xcuda_ASYCUDA doc;
                if (await DeleteExistingDocument().ConfigureAwait(false)) return;

                var ads = docSet; //await GetAsycudaDocumentSet().ConfigureAwait(false);
                //}
                da = await CreateDocumentCt(ads).ConfigureAwait(false);

                

                await SaveGeneralInformation().ConfigureAwait(false);
                await SaveDeclarant().ConfigureAwait(false);
                await SaveTraders().ConfigureAwait(false);
                await SaveProperty().ConfigureAwait(false);
                await SaveIdentification().ConfigureAwait(false);
                await SaveTransport().ConfigureAwait(false);
                await SaveFinancial().ConfigureAwait(false);
                await Save_Warehouse().ConfigureAwait(false);
                await Save_Valuation().ConfigureAwait(false);
                await SaveContainer().ConfigureAwait(false);
              

                await Save_Items().ConfigureAwait(false);
                
                if (!da.DocumentItems.Any() == true)
                {
                    await BaseDataModel.Instance.DeleteAsycudaDocument(da.Document.ASYCUDA_Id).ConfigureAwait(false);
                    return;
                }
                
                if(LinkPi) await LinkExistingPreviousItems().ConfigureAwait(false);

                await SavePreviousItem().ConfigureAwait(false);

                await Save_Suppliers_Documents().ConfigureAwait(false);

                if(!da.DocumentItems.Any(x => x.ImportComplete == false))
                    da.Document.xcuda_ASYCUDA_ExtendedProperties.ImportComplete = true;

                //await
                    //DBaseDataModel.Instance.Savexcuda_ASYCUDA_ExtendedProperties(
                    //    da.Document.xcuda_ASYCUDA_ExtendedProperties).ConfigureAwait(false);

                await BaseDataModel.Instance.SaveDocumentCT(da).ConfigureAwait(false);

               // BuildSalesReportClass.Instance.ReBuildSalesReports(da.Document.id);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (da != null && da.Document != null && !da.Document.xcuda_ASYCUDA_ExtendedProperties.ImportComplete)
                {
                    da.Document.xcuda_ASYCUDA_ExtendedProperties.AsycudaDocumentSet.xcuda_ASYCUDA_ExtendedProperties
                        .Remove(da.Document.xcuda_ASYCUDA_ExtendedProperties);
                   await BaseDataModel.Instance.DeleteDocumentCt(da).ConfigureAwait(false);
                }
            }

        }

        private  async Task<DocumentCT> CreateDocumentCt(AsycudaDocumentSet ads)
        {
            DocumentCT da = await BaseDataModel.Instance.CreateDocumentCt(ads).ConfigureAwait(false);
            da.Document.xcuda_ASYCUDA_ExtendedProperties.ImportComplete = false;
            da.Document.id = a.id;
            da.Document.xcuda_ASYCUDA_ExtendedProperties.AutoUpdate = false;
            da.Document.xcuda_ASYCUDA_ExtendedProperties.AsycudaDocumentSetId = ads.AsycudaDocumentSetId;
            da.Document.xcuda_ASYCUDA_ExtendedProperties.AsycudaDocumentSet = ads;
            //await BaseDataModel.Instance.SaveDocumentCT(da).ConfigureAwait(false);
            
            return da;
        }

        private async Task<AsycudaDocumentSet> GetAsycudaDocumentSet(int docSetId = -1)
        {
            AsycudaDocumentSet ads;
            //db.AsycudaDocumentSet.FirstOrDefault(
            //    x =>
            //    x.Declarant_Reference_Number.Replace(" ", "")
            //     .Contains(refstr.Substring(0, refstr.Length - refstr.IndexOf("-F"))));
            //if (ads == null)
            //{
            if (docSetId == -1)
            {
                ads = await NewAsycudaDocumentSet(a).ConfigureAwait(false);
            }
            else
            {
                ads =
                    await
                        BaseDataModel.Instance.GetAsycudaDocumentSet(docSetId,
                            new List<string>()
                            {
                                "ASYCUDA_ExtendedProperties"
                            }).ConfigureAwait(false);
            }
            return ads;
        }

        private async Task<bool> DeleteExistingDocument()
        {
            xcuda_ASYCUDA doc = null;
            if (string.IsNullOrEmpty(a.Identification.Registration.Number))
            {
                if (ImportOnlyRegisteredDocuments) return true;
                a.Identification.Registration.Number = "0";
            }
            if (a.Identification.Registration.Date == "")
                a.Identification.Registration.Date = DateTime.MinValue.ToShortDateString();

            //docs =  db.xcuda_ASYCUDA.Where(x => x.id == a.id).ToList();
            doc = (await DBaseDataModel.Instance.Searchxcuda_ASYCUDA(new List<string>()
            {
                string.Format("id == \"{0}\"",a.id)
            
            }, new List<string>()
            {
                "xcuda_Identification ",
                "xcuda_ASYCUDA_ExtendedProperties",
                "xcuda_Identification.xcuda_Registration",
                "xcuda_Identification.xcuda_Office_segment",
                "xcuda_Declarant"
            }).ConfigureAwait(false)).FirstOrDefault();

            ////if (doc == null)
            ////{
            ////    using (var ctx = new xcuda_ASYCUDAService())
            ////    {
            ////        doc = (await ctx.Getxcuda_ASYCUDAByExpressionLst(new List<string>()
            ////        {
            ////            string.Format("xcuda_Identification.xcuda_Registration.Number == \"{0}\"",
            ////                a.Identification.Registration.Number),
            ////            string.Format("xcuda_Identification.xcuda_Registration.Date != null && Convert.ToDateTime(xcuda_Identification.xcuda_Registration.Date).Year == {0}",
            ////                Convert.ToDateTime(a.Identification.Registration.Date).Year),
            ////            string.Format(
            ////                "xcuda_Identification.xcuda_Office_segment.Customs_clearance_office_code == \"{0}\"",
            ////                a.Identification.Office_segment.Customs_clearance_office_code.Text)
            ////        }, new List<string>()
            ////        {
            ////            "xcuda_Identification ",
            ////            "xcuda_ASYCUDA_ExtendedProperties",
            ////            "xcuda_Identification.xcuda_Registration",
            ////            "xcuda_Identification.xcuda_Office_segment",
            ////            "xcuda_Declarant"
            ////        }).ConfigureAwait(false)).FirstOrDefault();
            ////    }
            ////}
            //// check the declarant reference number
            //if (doc == null)
            //{
            //    doc =
            //        db.xcuda_ASYCUDA.Where(x => x.xcuda_Identification.xcuda_Registration.Number == null
            //                                    && x.xcuda_Declarant != null
            //                                    && x.xcuda_Declarant.Number != null
            //                                    && x.xcuda_Declarant.Number.Replace(" ", "")
            //                                    == a.Declarant.Reference.Number.Replace(" ", ""))
            //            .AsEnumerable()
            //            .Where(c => c.RegistrationDate == DateTime.MinValue
            //                        || (c.RegistrationDate != DateTime.MinValue
            //                            &&
            //                            c.RegistrationDate.Year ==
            //                            Convert.ToDateTime(a.Identification.Registration.Date).Year)
            //                        &&
            //                        c.xcuda_Identification.xcuda_Office_segment.Customs_clearance_office_code ==
            //                        a.Identification.Office_segment.Customs_clearance_office_code.Text
            //                            .FirstOrDefault()
            //            ).Distinct().ToList();


            //}

            if (doc != null)
            {
                if (!OverwriteExisting && doc.xcuda_ASYCUDA_ExtendedProperties.ImportComplete) return true;
                await BaseDataModel.Instance.DeleteAsycudaDocument(doc.ASYCUDA_Id).ConfigureAwait(false);
            }
            return false;
        }

        private async Task LinkExistingPreviousItems()
        {
            //get all previous items for this document
            var year = Convert.ToDateTime(da.Document.xcuda_Identification.xcuda_Registration.Date).Year.ToString();
            var plst = await DIBaseDataModel.Instance.Searchxcuda_PreviousItem(new List<string>()
            {
                string.Format("Prev_reg_nbr == \"{0}\"",da.Document.xcuda_Identification.xcuda_Registration.Number),
                string.Format("Prev_reg_dat == \"{0}\"",year),
                string.Format("Prev_reg_cuo == \"{0}\"",da.Document.xcuda_Identification.xcuda_Office_segment.Customs_clearance_office_code)

            }).ConfigureAwait(false);

            //Where(x => x.Prev_reg_nbr == da.xcuda_Identification.xcuda_Registration.Number
            //                                            && x.Prev_reg_dat == year
            //                                            && x.Prev_reg_cuo == da.xcuda_Identification.xcuda_Office_segment.Customs_clearance_office_code).ToList();

            if (plst.Any() == false) return;
            foreach (var itm in da.DocumentItems)
            {
                var pplst = plst.Where(x => x.Previous_item_number == itm.LineNumber.ToString());
                //if(pplst.Any == false) MessageBox.Show("Please Import 
                foreach (var p in pplst)
                {
                    var ep = new EntryPreviousItems(true){Item_Id = itm.Item_Id, PreviousItem_Id = p.PreviousItem_Id, TrackingState = TrackingState.Added};
                    itm.xcuda_PreviousItems.Add(ep);
                   //await DIBaseDataModel.Instance.SaveEntryPreviousItems(ep).ConfigureAwait(false);
                }
                    
                
            }

        }

  

        private async Task SavePreviousItem()
        {

            try
            {

                for (var i = 0; i < a.Prev_decl.Count; i++)
                {


                    var ai = a.Prev_decl.ElementAt(i);
                    if (ai == null) continue;
                    var itm = da.DocumentItems.OrderBy(x => x.LineNumber).ElementAt(i);
                    if (itm.xcuda_Tarification.Extended_customs_procedure == "9071") return;
                    var pi = new xcuda_PreviousItem(true)
                    {
                        PreviousItem_Id = itm.Item_Id,
                        TrackingState = TrackingState.Added
                    };

                    itm.xcuda_PreviousItem = pi;
                    pi.xcuda_Item = itm;

                    if (LinkPi )
                    {
                        await LinkPIItem(ai, itm, pi).ConfigureAwait(false);
                    }

                    pi.Commodity_code = ai.Prev_decl_HS_prec;
                        pi.Current_item_number = ai.Prev_decl_current_item;
                        pi.Current_value = Convert.ToSingle(Math.Round(Convert.ToDouble(ai.Prev_decl_ref_value), 2));
                        pi.Goods_origin = ai.Prev_decl_country_origin;
                        pi.Hs_code = ai.Prev_decl_HS_code;
                        pi.Net_weight = Convert.ToSingle(ai.Prev_decl_weight);
                        pi.Packages_number = ai.Prev_decl_number_packages;
                        pi.Prev_net_weight = Convert.ToSingle(ai.Prev_decl_weight_written_off);
                        pi.Prev_reg_cuo = ai.Prev_decl_office_code;
                        pi.Prev_reg_dat = ai.Prev_decl_reg_year;
                        pi.Prev_reg_nbr = ai.Prev_decl_reg_number;
                        pi.Prev_reg_ser = ai.Prev_decl_reg_serial;
                       if(!string.IsNullOrEmpty(ai.Prev_decl_supp_quantity_written_off)) pi.Preveious_suplementary_quantity = Convert.ToSingle(ai.Prev_decl_supp_quantity_written_off);
                        pi.Previous_item_number = ai.Prev_decl_item_number;
                        pi.Previous_Packages_number = ai.Prev_decl_number_packages_written_off;
                        if (ai.Prev_decl_ref_value_written_off != null)
                            pi.Previous_value = (float)Math.Round(Convert.ToDouble(ai.Prev_decl_ref_value_written_off), 2);
                    if (!string.IsNullOrEmpty(ai.Prev_decl_supp_quantity)) pi.Suplementary_Quantity = Convert.ToSingle(ai.Prev_decl_supp_quantity);

                      //await DataSpace.DocumentItemDS.ViewModels.BaseDataModel.Instance.Savexcuda_PreviousItem(pi).ConfigureAwait(false);

                }
            }
            catch (Exception Ex)
            {
                throw;
            }
        }

        private async Task LinkPIItem(ASYCUDAPrev_decl ai, xcuda_Item itm, xcuda_PreviousItem pi)
        {
            var itemId = await GetOriginalEntryItemId(ai, itm.ItemNumber).ConfigureAwait(false);

            var bl = String.Format("{0} {1} C {2} art. {3}", ai.Prev_decl_office_code,
                ai.Prev_decl_reg_year,
                ai.Prev_decl_reg_number, ai.Prev_decl_item_number);

            if (itemId != 0)
            {
                await LinkPi2Item(itemId, pi).ConfigureAwait(false);
            }
            else
            {
                if (!NoMessages)
                {
                    throw new ApplicationException("Can not find Original entry: " + bl);
                }
            }
        }


        private async Task<IEnumerable<xcuda_Item>> SearchDocumentItems(List<string> explst, List<string> includeLst = null)
        {
            using (var ctx = new xcuda_ItemService())
            {

                return await ctx.Getxcuda_ItemByExpressionLst(explst, includeLst).ConfigureAwait(false);
            }
        }

        private async Task<int> GetOriginalEntryItemId(ASYCUDAPrev_decl ai, string itemNumber)
        {
            try
            {
               xcuda_ASYCUDA pdoc = null;
                using (var ctx = new DocumentDSContext())
                {
                     pdoc = ctx.xcuda_ASYCUDA.FirstOrDefault(
                        x =>
                            x.xcuda_Identification.xcuda_Registration.Date != null &&
                            x.xcuda_Identification.xcuda_Registration.Date.Substring(x.xcuda_Identification.xcuda_Registration.Date.Length-2) == ai.Prev_decl_reg_year.Substring(ai.Prev_decl_reg_year.Length - 2)
                            && x.xcuda_Identification.xcuda_Registration.Number == ai.Prev_decl_reg_number &&
                            x.xcuda_Identification.xcuda_Office_segment.Customs_clearance_office_code == ai.Prev_decl_office_code);
                }
                if (pdoc == null)
              throw new ApplicationException(string.Format("Please Import CNumber {0} Year {1} Office {2} before importing this file {3}-{4}", ai.Prev_decl_reg_number, ai.Prev_decl_reg_year, ai.Prev_decl_office_code, a.Identification.Registration.Number, a.Identification.Registration.Date));
                using (var ctx = new DocumentItemDSContext())
                {
                    var itm = ctx.xcuda_Item.FirstOrDefault(
                        x => x.LineNumber.ToString() == ai.Prev_decl_item_number
                             && x.ASYCUDA_Id == pdoc.ASYCUDA_Id
                             //&& x.xcuda_Tarification.xcuda_HScode.Precision_4 == itemNumber // cuz of c#39457
                             );

                    if (itm != null) return itm.Item_Id;
                    return 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task LinkPi2Item(int itemId, xcuda_PreviousItem pi)
        {
            if (pi.xcuda_Items.Any(x => x.Item_Id == itemId)) return;
                        var ep = new EntryPreviousItems(true)
                        {
                            Item_Id = itemId,
                            PreviousItem_Id = pi.PreviousItem_Id,
                            TrackingState = TrackingState.Added
                        };
                       // //await DIBaseDataModel.Instance.SaveEntryPreviousItems(ep).ConfigureAwait(false);
                        pi.xcuda_Items.Add(ep);
        
        }



        public static async Task<AsycudaDocumentSet> NewAsycudaDocumentSet(ASYCUDA a)
        {
            var ads = (await DBaseDataModel.Instance.SearchAsycudaDocumentSet(new List<string>()
            {
                string.Format("Declarant_Reference_Number == \"{0}\"", a.Declarant.Reference.Number)
            }).ConfigureAwait(false)).FirstOrDefault();//.AsycudaDocumentSet.FirstOrDefault(d => d.Declarant_Reference_Number == a.Declarant.Reference.Number);
            if (ads == null)
            {
                ads = new AsycudaDocumentSet(true)
                    {
                        TrackingState = TrackingState.Added,
                        Declarant_Reference_Number = a.Declarant.Reference.Number.Text.FirstOrDefault(),
                        Currency_Code = a.Valuation.Gs_Invoice.Currency_code.Text.FirstOrDefault(),
                        Document_Type =
                            BaseDataModel.Instance.Document_Types
                              .FirstOrDefault(
                                  d =>
                                  d.Type_of_declaration == a.Identification.Type.Type_of_declaration &&
                                  d.Declaration_gen_procedure_code == a.Identification.Type.Declaration_gen_procedure_code)
                    };


                if (ads.Document_Type == null)
                {
                    var dt = new Document_Type(true)
                        {
                            Declaration_gen_procedure_code = a.Identification.Type.Declaration_gen_procedure_code,
                            Type_of_declaration = a.Identification.Type.Type_of_declaration,
                            TrackingState = TrackingState.Added
                        };
                    //await DBaseDataModel.Instance.SaveDocument_Type(dt).ConfigureAwait(false);
                    ads.Document_Type = dt;
                }

                ads.Customs_Procedure = BaseDataModel.Instance.Customs_Procedures
                                       .FirstOrDefault(cp => cp.National_customs_procedure == a.Item.FirstOrDefault().Tarification.National_customs_procedure.Text.FirstOrDefault() 
                                                    && cp.Extended_customs_procedure == a.Item.FirstOrDefault().Tarification.Extended_customs_procedure.Text.FirstOrDefault());
                if (ads.Customs_Procedure == null)
                {
                    var cp = new Customs_Procedure(true)
                        {
                            Extended_customs_procedure = a.Item[0].Tarification.Extended_customs_procedure.Text.FirstOrDefault(),
                        National_customs_procedure = a.Item[0].Tarification.National_customs_procedure.Text.FirstOrDefault(),
                        Document_Type = ads.Document_Type,
                            TrackingState = TrackingState.Added
                        };
                    //await DBaseDataModel.Instance.SaveCustoms_Procedure(cp).ConfigureAwait(false);
                    ads.Customs_Procedure = cp;
                }

                ads.Exchange_Rate = Convert.ToSingle(a.Valuation.Gs_Invoice.Currency_rate);

                //await DBaseDataModel.Instance.SaveAsycudaDocumentSet(ads).ConfigureAwait(false);

                return ads;
            }
            else
            {
                return ads;
            }

        }

        private async Task Save_Suppliers_Documents()
        {
            if (a.Supplier_documents.Count > 0 && a.Supplier_documents[0] == null) return;
            for (int i = 0; i < a.Supplier_documents.Count; i++)
            {
                var asd = a.Supplier_documents.ElementAt(i);  
            
                var s = da.Document.xcuda_Suppliers_documents.ElementAtOrDefault(i);
                if (s == null)
                {
                    s = new xcuda_Suppliers_documents(true)
                    {
                        ASYCUDA_Id = da.Document.ASYCUDA_Id,
                        TrackingState = TrackingState.Added
                    };
                    da.Document.xcuda_Suppliers_documents.Add(s);
                }
                // var asd = a.Suppliers_documents[0];
                if (asd.Invoice_supplier_city.Text.Count > 0)
                    s.Suppliers_document_city = asd.Invoice_supplier_city.Text[0];

               

                if (asd.Invoice_supplier_country.Text.Count > 0)
                    s.Suppliers_document_country = asd.Invoice_supplier_country.Text[0];

                if (asd.Invoice_supplier_fax.Text.Count > 0)
                    s.Suppliers_document_fax = asd.Invoice_supplier_fax.Text[0];

                if (asd.Invoice_supplier_name.Text.Count > 0)
                    s.Suppliers_document_name = asd.Invoice_supplier_name.Text[0];

                if (asd.Invoice_supplier_street.Text.Count > 0)
                    s.Suppliers_document_street = asd.Invoice_supplier_street.Text[0];

                if (asd.Invoice_supplier_telephone.Text.Count > 0)
                    s.Suppliers_document_telephone = asd.Invoice_supplier_telephone.Text[0];

                
                if (asd.Invoice_supplier_zip_code.Text.Count > 0)
                    s.Suppliers_document_zip_code = asd.Invoice_supplier_zip_code.Text[0];

                //await DBaseDataModel.Instance.Savexcuda_Suppliers_documents(s).ConfigureAwait(false);

            }
        }



        private async Task Save_Items()
        {
            try
            {

          da.Document.xcuda_ASYCUDA_ExtendedProperties.DocumentLines = a.Item.Count;
          for (var i = 0; i < a.Item.Count; i++)
           // Parallel.For(0, a.Item.Count, i =>
            {
               
                        var ai = a.Item.ElementAt(i);
                xcuda_Item di;

                if (!ai.Tarification.HScode.Commodity_code.Text.Any()) continue;

                    di = da.DocumentItems.ElementAtOrDefault(i);
                

                if (di == null)
                {
                    di = new xcuda_Item(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, ImportComplete = false, TrackingState = TrackingState.Added };
                        // db.xcuda_Item.CreateObject();//
                    //DIBaseDataModel.Instance.Savexcuda_Item(di);
                    da.DocumentItems.Add(di);

                }

                if (!string.IsNullOrEmpty(a.Identification.Registration.Number))
                {
                    di.IsAssessed = true;
                }



                di.LineNumber = i + 1;
                di.SalesFactor = 1;

                if (ai.Licence_number.Text.Count > 0)
                {
                    di.Licence_number = ai.Licence_number.Text[0];
                    di.Amount_deducted_from_licence = ai.Amount_deducted_from_licence;
                    di.Quantity_deducted_from_licence = ai.Quantity_deducted_from_licence;
                }
               

                //DIBaseDataModel.Instance.Savexcuda_Item(di).Wait();
                //await DIBaseDataModel.Instance.Savexcuda_Item(di).ConfigureAwait(false);

                await Save_Item_Suppliers_link(di, ai).ConfigureAwait(false);
               
                await Save_Item_Attached_documents(di, ai).ConfigureAwait(false);

                await Save_Item_Packages(di, ai).ConfigureAwait(false);

                // SaveInventoryItem(ai);


                await Save_Item_Tarification(di, ai).ConfigureAwait(false);
                //Save_Item_Tarification(di, ai).Wait();
                await Save_Item_Goods_description(di, ai).ConfigureAwait(false);
                await Save_Item_Previous_doc(di, ai).ConfigureAwait(false);
                await Save_Item_Taxation(di, ai).ConfigureAwait(false);
                //Save_Item_Taxation(di, ai).Wait();
               await Save_Item_Valuation_item(di, ai).ConfigureAwait(false);
               // Save_Item_Valuation_item(di, ai).Wait();

                
                di.ImportComplete = true;
               //await DIBaseDataModel.Instance.Savexcuda_Item(di).ConfigureAwait(false);
                if (UpdateItemsTariffCode)
                {
                    Update_TarrifCodes(ai);
                }


            }
            //    );
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Update_TarrifCodes(ASYCUDAItem ai)
        {
            try
            {
                if (!ai.Tarification.HScode.Commodity_code.Text.Any()) return;

                using (var ctx = new InventoryDSContext())
                {
                    var tariffCode = ctx.TariffCodes
                        .Include("TariffCategory.TariffCategoryCodeSuppUnits.TariffSupUnitLkp")
                        .FirstOrDefault(x => x.TariffCodeName == ai.Tarification.HScode.Commodity_code.Text.FirstOrDefault());
                        if(tariffCode == null)
                        tariffCode = new TariffCode(true)
                                     {
                                         TariffCodeName = ai.Tarification.HScode.Commodity_code.Text.FirstOrDefault(),
                            TariffCategory = ctx.TariffCategories.FirstOrDefault(x =>
                                                              x.TariffCategoryCode == ai.Tarification.HScode
                                                                  .Commodity_code.Text.FirstOrDefault().Substring(0, 4))
                                                          ,
                                         TrackingState = TrackingState.Added

                                     };

                    if (tariffCode.TariffCategory == null)
                    {
                        tariffCode.TariffCategory = new TariffCategory(true)
                        {
                            TariffCategoryCode =
                                ai.Tarification.HScode.Commodity_code.Text.FirstOrDefault().Substring(0, 4),
                            Description = ai.Goods_description.Description_of_goods.Text.Any()?ai.Goods_description.Description_of_goods.Text[0]:"",
                        TrackingState = TrackingState.Added
                        };
                    }

                    for (var i = 0;
                        i < ai.Tarification.Supplementary_unit.Count(x => x.Suppplementary_unit_code.Text.Count > 0);
                        i++)
                    {
                        var au = ai.Tarification.Supplementary_unit.ElementAt(i);

                        var lst = tariffCode.TariffCategory?.TariffCategoryCodeSuppUnits?
                            .Where(z => z.TariffSupUnitLkp.SuppUnitCode2 == au.Suppplementary_unit_code.Text[0]);
                        if (lst == null || !lst.Any())
                        {
                            var tcc = au.Suppplementary_unit_code.Text[0];
                            var tn = au.Suppplementary_unit_name.Text.Any() ? au.Suppplementary_unit_name.Text[0] : "";


                            TariffSupUnitLkp tariffSupUnitLkp =
                                ctx.TariffSupUnitLkps.FirstOrDefault(x => x.SuppUnitCode2 == tcc)
                                ?? new TariffSupUnitLkp(true)
                                {
                                    SuppUnitCode2 = tcc,
                                    SuppUnitName2 = tn,
                                    SuppQty = 1,
                                    TrackingState = TrackingState.Added
                                };

                            var supUnit = new TariffCategoryCodeSuppUnit(true)
                            {
                                TariffCategory = tariffCode.TariffCategory,
                                TariffSupUnitLkp = tariffSupUnitLkp,
                                TrackingState = TrackingState.Added
                            };

                            

                            tariffCode.TariffCategory.TariffCategoryCodeSuppUnits.Add(supUnit);
                            ctx.ApplyChanges(supUnit);
                            ctx.SaveChanges();
                            supUnit.AcceptChanges();

                        }

                    }

                    if(ai.Goods_description.Description_of_goods.Text.Any()) tariffCode.Description = ai.Goods_description.Description_of_goods.Text[0];
                    if (ai.Licence_number.Text.Any()) tariffCode.TariffCategory.LicenseRequired = true;

                    for (var i = 0; i < ai.Taxation.Taxation_line.Count(x => x.Duty_tax_code.Text.Count > 0); i++)
                    {
                        var au = ai.Taxation.Taxation_line.ElementAt(i);
                        var rate = (Convert.ToDouble(au.Duty_tax_rate) / 100).ToString("00.00");
                        switch (au.Duty_tax_code.Text[0])
                        {
                            case "CET":
                                tariffCode.RateofDuty = rate;
                                break;
                            case "CSC":
                                tariffCode.CustomsServiceCharge = rate;
                                break;
                            case "EVL":
                                tariffCode.EnvironmentalLevy = rate;
                                break;
                            case "EXT":
                                tariffCode.ExciseTax = rate;
                                break;
                            case "VAT":
                                tariffCode.VatRate = rate;
                                break;
                            case "PET":
                                tariffCode.PetrolTax = rate;
                                break;
                            default:
                                break;
                        }

                    }
                    ctx.ApplyChanges(tariffCode);
                    ctx.SaveChanges();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async Task<InventoryItem> SaveInventoryItem(ASYCUDAItem ai)
        {
            try
            {
                using (var ctx = new InventoryDSContext())
                {
                    var iv = ctx.InventoryItems.FirstOrDefault(x =>
                        x.ItemNumber == ai.Tarification.HScode.Precision_4.Text.FirstOrDefault());
                    ////    (await DataSpace.InventoryDS.ViewModels.BaseDataModel.Instance.SearchInventoryItem(new List<string>()
                    ////{
                    ////    string.Format("ItemNumber == \"{0}\"",ai.Tarification.HScode.Precision_4.Text.FirstOrDefault())
                    ////}).ConfigureAwait(false)).FirstOrDefault();
                    //InventoryItems.FirstOrDefault(i => i.ItemNumber == ai.Tarification.HScode.Precision_4.Text.FirstOrDefault());
                    if (iv == null && ai.Tarification.HScode.Precision_4.Text.FirstOrDefault() != null)
                    {

                        iv = new InventoryItem(true)
                        {
                            ItemNumber = ai.Tarification.HScode.Precision_4.Text.FirstOrDefault(),
                            Description = ai.Goods_description.Commercial_Description.Text.FirstOrDefault()??"",
                            TrackingState = TrackingState.Added
                        };


                        var tc = ctx.TariffCodes.FirstOrDefault(x =>
                            x.TariffCodeName == ai.Tarification.HScode.Commodity_code.Text.FirstOrDefault());

                        if (tc != null)
                            iv.TariffCode = ai.Tarification.HScode.Commodity_code.Text.FirstOrDefault();



                        ctx.ApplyChanges(iv);
                        ctx.SaveChanges();



                    }

                    //include tarrifcode
                    return iv;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        private async Task Save_Item_Valuation_item(xcuda_Item di, ASYCUDAItem ai)
        {
            var vi = di.xcuda_Valuation_item;//.FirstOrDefault();
            if (vi == null)
            {
                vi = new xcuda_Valuation_item(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
              //  DIBaseDataModel.Instance.Savexcuda_Valuation_item(vi);
                di.xcuda_Valuation_item = vi;//di.xcuda_Valuation_item.Add(vi);
            }
            if (ai.Valuation_item.Alpha_coeficient_of_apportionment != "")
                vi.Alpha_coeficient_of_apportionment = ai.Valuation_item.Alpha_coeficient_of_apportionment;
            if (ai.Valuation_item.Rate_of_adjustement != "")
                vi.Rate_of_adjustement = Convert.ToDouble(ai.Valuation_item.Rate_of_adjustement);
            if (ai.Valuation_item.Statistical_value != "")
                vi.Statistical_value = Convert.ToSingle(ai.Valuation_item.Statistical_value);
            if (ai.Valuation_item.Total_CIF_itm != "")
                vi.Total_CIF_itm = Convert.ToSingle(ai.Valuation_item.Total_CIF_itm);
            if (ai.Valuation_item.Total_cost_itm != "")
                vi.Total_cost_itm = Convert.ToSingle(ai.Valuation_item.Total_cost_itm);

            Save_Item_Invoice(vi, ai);
            Save_item_External_freight(vi, ai);
            Save_Weight_Item(vi, ai);

           //await DIBaseDataModel.Instance.Savexcuda_Valuation_item(vi).ConfigureAwait(false);
        }

        private void Save_Weight_Item(xcuda_Valuation_item vi, ASYCUDAItem ai)
        {
            var wi = vi.xcuda_Weight_itm;
            if (wi == null)
            {
                wi = new xcuda_Weight_itm(true) { Valuation_item_Id = vi.Item_Id, TrackingState = TrackingState.Added };
                vi.xcuda_Weight_itm = wi;
            }
            if (ai.Valuation_item.Weight_itm.Gross_weight_itm != "")
                wi.Gross_weight_itm = Convert.ToSingle(ai.Valuation_item.Weight_itm.Gross_weight_itm);

            if (ai.Valuation_item.Weight_itm.Net_weight_itm != "")
                wi.Net_weight_itm = Convert.ToSingle(ai.Valuation_item.Weight_itm.Net_weight_itm);

        }

        private void Save_item_External_freight(xcuda_Valuation_item vi, ASYCUDAItem ai)
        {
            var i = vi.xcuda_item_external_freight;
            if (i == null)
            {
                i = new xcuda_item_external_freight(true) { Valuation_item_Id = vi.Item_Id, TrackingState = TrackingState.Added };
                vi.xcuda_item_external_freight = i;
            }
            if (ai.Valuation_item.item_external_freight.Amount_foreign_currency != "")
                i.Amount_foreign_currency = Convert.ToSingle(ai.Valuation_item.item_external_freight.Amount_foreign_currency);
            if (ai.Valuation_item.item_external_freight.Amount_national_currency != "")
                i.Amount_national_currency = Convert.ToSingle(ai.Valuation_item.item_external_freight.Amount_national_currency);

            i.Currency_code = ai.Valuation_item.item_external_freight.Currency_code.Text.FirstOrDefault();

            if (ai.Valuation_item.item_external_freight.Currency_rate != "")
                i.Currency_rate = Convert.ToSingle(ai.Valuation_item.item_external_freight.Currency_rate);

        }

        private void Save_Item_Invoice(xcuda_Valuation_item vi, ASYCUDAItem ai)
        {
            var i = vi.xcuda_Item_Invoice;
            if (i == null)
            {
                i = new xcuda_Item_Invoice(true) { Valuation_item_Id = vi.Item_Id, TrackingState = TrackingState.Added };
                vi.xcuda_Item_Invoice = i;
            }
            if (ai.Valuation_item.Item_Invoice.Amount_foreign_currency != "")
                i.Amount_foreign_currency = Convert.ToSingle(ai.Valuation_item.Item_Invoice.Amount_foreign_currency);
            if (ai.Valuation_item.Item_Invoice.Amount_national_currency != "")
                i.Amount_national_currency = Convert.ToSingle(ai.Valuation_item.Item_Invoice.Amount_national_currency);
            if (ai.Valuation_item.Item_Invoice.Currency_code?.Text?.FirstOrDefault() != null)
                i.Currency_code = ai.Valuation_item.Item_Invoice.Currency_code.Text.FirstOrDefault();
            if (ai.Valuation_item.Item_Invoice.Currency_rate != "")
                i.Currency_rate = Convert.ToSingle(ai.Valuation_item.Item_Invoice.Currency_rate);

        }

        private async Task Save_Item_Taxation(xcuda_Item di, ASYCUDAItem ai)
        {
            var t = di.xcuda_Taxation.FirstOrDefault();
            if (t == null)
            {

                t = new xcuda_Taxation(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                di.xcuda_Taxation.Add(t);
               
            }

            //t.Counter_of_normal_mode_of_payment = ai.Taxation.Counter_of_normal_mode_of_payment
            //t.Displayed_item_taxes_amount = ai.Taxation.Displayed_item_taxes_amount;
            if (ai.Taxation.Item_taxes_amount != "")
                t.Item_taxes_amount = Convert.ToSingle(ai.Taxation.Item_taxes_amount);
            //t.Item_taxes_guaranted_amount = ai.Taxation.Item_taxes_guaranted_amount;
            if (ai.Taxation.Item_taxes_mode_of_payment.Text.Count > 0)
                t.Item_taxes_mode_of_payment = ai.Taxation.Item_taxes_mode_of_payment.Text[0];


            Save_Taxation_line(t, ai);

            //await DIBaseDataModel.Instance.Savexcuda_Taxation(t).ConfigureAwait(false);
        }

        private void Save_Taxation_line(xcuda_Taxation t, ASYCUDAItem ai)
        {
            for (var i = 0; i < ai.Taxation.Taxation_line.Count; i++)
            {
                var au = ai.Taxation.Taxation_line.ElementAt(i);

                if (au.Duty_tax_code.Text.Count == 0) break;

                var tl = t.xcuda_Taxation_line.ElementAtOrDefault(i);
                if (tl == null)
                {
                    tl = new xcuda_Taxation_line(true) { TrackingState = TrackingState.Added };
                    t.xcuda_Taxation_line.Add(tl);
                    
                }

                tl.Duty_tax_amount = Convert.ToDouble(au.Duty_tax_amount);
                tl.Duty_tax_Base = au.Duty_tax_Base;
                tl.Duty_tax_code = au.Duty_tax_code.Text[0];

                if (au.Duty_tax_MP.Text.Count > 0)
                    tl.Duty_tax_MP = au.Duty_tax_MP.Text[0];

                tl.Duty_tax_rate = Convert.ToDouble(au.Duty_tax_rate);

            }
        }

        private async Task Save_Item_Previous_doc(xcuda_Item di, ASYCUDAItem ai)
        {
            var pd = di.xcuda_Previous_doc;
            if (pd == null)
            {
                pd = new xcuda_Previous_doc(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                // di.xcuda_Previous_doc.Add(pd);
                di.xcuda_Previous_doc = pd;
            }
            pd.Summary_declaration = ai.Previous_doc.Summary_declaration.Text.FirstOrDefault();
            if (da.Document.xcuda_ASYCUDA_ExtendedProperties.BLNumber == null && ai.Previous_doc.Summary_declaration != null)
                da.Document.xcuda_ASYCUDA_ExtendedProperties.BLNumber = ai.Previous_doc.Summary_declaration.Text.FirstOrDefault();

            //await DIBaseDataModel.Instance.Savexcuda_Previous_doc(pd).ConfigureAwait(false);
        }

        private async Task Save_Item_Goods_description(xcuda_Item di, ASYCUDAItem ai)
        {
            var g = di.xcuda_Goods_description;//.FirstOrDefault();
            if (g == null)
            {
                g = new xcuda_Goods_description(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                di.xcuda_Goods_description = g;
            }
            g.Commercial_Description = ai.Goods_description.Commercial_Description.Text.FirstOrDefault();
            g.Country_of_origin_code = ai.Goods_description.Country_of_origin_code.Text.FirstOrDefault();
            g.Description_of_goods = ai.Goods_description.Description_of_goods.Text.FirstOrDefault();

            //await DIBaseDataModel.Instance.Savexcuda_Goods_description(g).ConfigureAwait(false);
        }

        private async Task Save_Item_Tarification(xcuda_Item di, ASYCUDAItem ai)
        {
            var t = di.xcuda_Tarification;//.FirstOrDefault();
            if (t == null)
            {
                t = new xcuda_Tarification(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                di.xcuda_Tarification = t;

            }

            t.Extended_customs_procedure = ai.Tarification.Extended_customs_procedure.Text.FirstOrDefault();
            t.National_customs_procedure = ai.Tarification.National_customs_procedure.Text.FirstOrDefault();
            if (ai.Tarification.Item_price != "")
                t.Item_price = Convert.ToSingle(ai.Tarification.Item_price);
            if (ai.Tarification.Value_item.Text.Count > 0)
                t.Value_item = ai.Tarification.Value_item.Text[0];

            Save_Supplementary_unit(t, ai);
            
            if (ai.Tarification.Attached_doc_item.Text.Count > 0)
                t.Attached_doc_item = ai.Tarification.Attached_doc_item.Text[0];
            
            await SaveCustomsProcedure(t).ConfigureAwait(false);

            await Save_HScode(t, di,ai).ConfigureAwait(false);

            //await DIBaseDataModel.Instance.Savexcuda_Tarification(t).ConfigureAwait(false);
        }

        private async Task<Customs_Procedure> SaveCustomsProcedure(xcuda_Tarification t)
        {
            var cp = BaseDataModel.Instance.Customs_ProcedureCache.Data.FirstOrDefault(x => x.Extended_customs_procedure == t.Extended_customs_procedure
                                                            && x.National_customs_procedure == t.National_customs_procedure 
                                                            && x.Document_TypeId == da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_Type.Document_TypeId);
            //    (await DBaseDataModel.Instance.SearchCustoms_Procedure(new List<string>()
            //{
            //    string.Format("Extended_customs_procedure == \"{0}\"", t.Extended_customs_procedure),
            //    string.Format("National_customs_procedure == \"{0}\"", t.National_customs_procedure)
            //}).ConfigureAwait(false)).FirstOrDefault();
            if (cp == null)
            {
                cp = new Customs_Procedure(true)
                {
                    Extended_customs_procedure = t.Extended_customs_procedure,
                    National_customs_procedure = t.National_customs_procedure,
                    TrackingState = TrackingState.Added
                };
                
                    if (da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_Type != null)
                    {
                        //if (da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_Type
                        //    .DefaultCustoms_Procedure == null)
                        //    da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_Type
                        //        .DefaultCustoms_Procedure = cp;

                        cp.Document_TypeId = da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_Type.Document_TypeId;
                    }

                using (var ctx = new Customs_ProcedureService())
                {
                    cp = await ctx.UpdateCustoms_Procedure(cp).ConfigureAwait(false);
                }
                    //await DBaseDataModel.Instance.SaveCustoms_Procedure(cp).ConfigureAwait(false);
                    BaseDataModel.Instance.Customs_ProcedureCache.AddItem(cp);
                
            }
            da.Document.xcuda_ASYCUDA_ExtendedProperties.Customs_ProcedureId = cp.Customs_ProcedureId;
            da.Document.xcuda_ASYCUDA_ExtendedProperties.Customs_Procedure = cp;
            //await
            //    DBaseDataModel.Instance.Savexcuda_ASYCUDA_ExtendedProperties(
            //        da.Document.xcuda_ASYCUDA_ExtendedProperties).ConfigureAwait(false);
            return cp;
        }

        private void Save_Supplementary_unit(xcuda_Tarification t, ASYCUDAItem ai)
        {
            for (var i = 0; i < ai.Tarification.Supplementary_unit.Count; i++)
            {
                var au = ai.Tarification.Supplementary_unit.ElementAt(i);

                if (au.Suppplementary_unit_code.Text.Count == 0) continue;

                var su = t.xcuda_Supplementary_unit.ElementAtOrDefault(i);
                if (su == null)
                {
                    su = new xcuda_Supplementary_unit(true) { Tarification_Id = t.Item_Id, TrackingState = TrackingState.Added };
                    t.Unordered_xcuda_Supplementary_unit.Add(su);
                }

                su.Suppplementary_unit_quantity = Convert.ToDouble(string.IsNullOrEmpty(au.Suppplementary_unit_quantity) ? "0" : au.Suppplementary_unit_quantity);

                if (au.Suppplementary_unit_code.Text.Count > 0)
                    su.Suppplementary_unit_code = au.Suppplementary_unit_code.Text[0];

                if (au.Suppplementary_unit_name.Text.Count > 0)
                    su.Suppplementary_unit_name = au.Suppplementary_unit_name.Text[0];

                if (i == 0) su.IsFirstRow = true;

                
                    
                        
                    
                }
            }
        
    

        private async Task Save_HScode(xcuda_Tarification t,xcuda_Item di, ASYCUDAItem ai)
        {
            var h = t.xcuda_HScode;//.FirstOrDefault();
            if (h == null)
            {
                h = new xcuda_HScode(true) { Item_Id = t.Item_Id, TrackingState = TrackingState.Added };
                t.xcuda_HScode = h;
            }

            h.Commodity_code = ai.Tarification.HScode.Commodity_code.Text.FirstOrDefault();
            h.Precision_1 = ai.Tarification.HScode.Precision_1.Text.FirstOrDefault();
            if (ai.Tarification.HScode.Precision_4.Text.FirstOrDefault() != null)
            {
                h.Precision_4 = ai.Tarification.HScode.Precision_4.Text.FirstOrDefault();
            }
            else
            {
                //if (!NoMessages)
                //    throw new ApplicationException(string.Format("Null Product Code on Line{0}", di.LineNumber));
            }


            //InventoryItems inv = db.InventoryItems.Where(x => x.ItemNumber == h.Precision_4).FirstOrDefault();
            //if(inv == null)
            //{
            //    inv = new InventoryItems(){ ItemNumber = h.Precision_4, Description = ai.Goods_description.Commercial_Description};
            //    db.InventoryItems.AddObject(inv);
            //}

           

            var i = await SaveInventoryItem(ai).ConfigureAwait(false);
            
        }

        private async Task Save_Item_Packages(xcuda_Item di, ASYCUDAItem ai)
        {
            var p = di.xcuda_Packages.FirstOrDefault();
            if (p == null)
            {
                p = new xcuda_Packages(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                di.xcuda_Packages.Add(p);
            }
            p.Kind_of_packages_code = ai.Packages.Kind_of_packages_code.Text.FirstOrDefault();
            p.Kind_of_packages_name = ai.Packages.Kind_of_packages_name.Text.FirstOrDefault();
            p.Number_of_packages = string.IsNullOrEmpty(ai.Packages.Number_of_packages)? 0 : Convert.ToSingle(ai.Packages.Number_of_packages);

            if (ai.Packages.Marks1_of_packages.Text.Count > 0)
                p.Marks1_of_packages = ai.Packages.Marks1_of_packages.Text[0];

            if (ai.Packages.Marks2_of_packages.Text.Count > 0)
                p.Marks2_of_packages = ai.Packages.Marks2_of_packages.Text[0];

            //await DIBaseDataModel.Instance.Savexcuda_Packages(p).ConfigureAwait(false);
        }

        private async Task Save_Item_Suppliers_link(xcuda_Item di, ASYCUDAItem ai)
        {
            var sl = di.xcuda_Suppliers_link.FirstOrDefault();
            if (sl == null)
            {
                sl = new xcuda_Suppliers_link(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                di.xcuda_Suppliers_link.Add(sl);
            }

            sl.Suppliers_link_code = ai.Suppliers_link.Suppliers_link_code;
            //await DIBaseDataModel.Instance.Savexcuda_Suppliers_link(sl).ConfigureAwait(false);
        }

        private async Task Save_Item_Attached_documents(xcuda_Item di, ASYCUDAItem ai)
        {
            for (var i = 0; i < ai.Attached_documents.Count; i++)
            {
                if (ai.Attached_documents[i].Attached_document_code.Text.Count == 0) break;

                var ad = di.xcuda_Attached_documents.ElementAtOrDefault(i);
                if (ad == null)
                {
                    ad = new xcuda_Attached_documents(true) { Item_Id = di.Item_Id, TrackingState = TrackingState.Added };
                    di.xcuda_Attached_documents.Add(ad);
                }

                ad.Attached_document_date = ai.Attached_documents[i].Attached_document_date;

                if (ai.Attached_documents[i].Attached_document_code.Text.Count != 0)
                    ad.Attached_document_code = ai.Attached_documents[i].Attached_document_code.Text[0];

                if (ai.Attached_documents[i].Attached_document_from_rule.Text.Count != 0)
                    ad.Attached_document_from_rule = Convert.ToInt32(ai.Attached_documents[i].Attached_document_from_rule.Text[0]);

                if (ai.Attached_documents[i].Attached_document_name.Text.Count != 0)
                    ad.Attached_document_name = ai.Attached_documents[i].Attached_document_name.Text[0];

                if (ai.Attached_documents[i].Attached_document_reference.Text.Count != 0)
                    ad.Attached_document_reference = ai.Attached_documents[i].Attached_document_reference.Text[0];

                //await DIBaseDataModel.Instance.Savexcuda_Attached_documents(ad).ConfigureAwait(false);

            }
        }

        private async Task SaveContainer()
        {
            try
            {
                foreach (var ac in a.Container)
                {
                var c = da.Document.xcuda_Container.FirstOrDefault(x => x.Container_identity == ac.Container_identity);
                if (c == null)
                {
                    c = new xcuda_Container(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                    da.Document.xcuda_Container.Add(c);
                }
                
                    
                        c.Container_identity = ac.Container_identity;
                        c.Container_type = ac.Container_type;
                        c.Empty_full_indicator = ac.Empty_full_indicator;
                        c.Goods_description = ac.Goods_description;
                        c.Gross_weight = Convert.ToSingle(ac.Gross_weight.Text.FirstOrDefault());
                        c.Item_Number = ac.Item_Number;
                        c.Packages_number = ac.Packages_number;
                        c.Packages_type = ac.Packages_type;
                        c.Packages_weight = Convert.ToSingle(ac.Packages_weight);
                   
                }

               
                //await DBaseDataModel.Instance.Savexcuda_Container(c).ConfigureAwait(false);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }

        private async Task Save_Valuation()
        {
            var v = da.Document.xcuda_Valuation;
            if (v == null)
            {
                v = new xcuda_Valuation(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                da.Document.xcuda_Valuation = v;
            }
            v.Calculation_working_mode = a.Valuation.Calculation_working_mode;
            v.Total_CIF = Convert.ToSingle(a.Valuation.Total_CIF);
            v.Total_cost = Convert.ToSingle(a.Valuation.Total_cost);

            Save_Valuation_Weight(v);
            Save_Gs_Invoice(v);
            Save_Gs_External_freight(v);
            Save_Total(v);
            //await DBaseDataModel.Instance.Savexcuda_Valuation(v).ConfigureAwait(false);
        }

        private void Save_Total(xcuda_Valuation v)
        {
            var t = v.xcuda_Total;
            if (t == null)
            {
                t = new xcuda_Total(true) { Valuation_Id = v.ASYCUDA_Id, TrackingState = TrackingState.Added };
                v.xcuda_Total = t;
            }
            t.Total_invoice = Convert.ToSingle(a.Valuation.Total.Total_invoice);
            t.Total_weight = Convert.ToSingle(a.Valuation.Total.Total_weight);
        }

        private void Save_Gs_External_freight(xcuda_Valuation v)
        {
            var gf = v.xcuda_Gs_external_freight;
            if (gf == null)
            {
                gf = new xcuda_Gs_external_freight(true) { Valuation_Id = v.ASYCUDA_Id, TrackingState = TrackingState.Added };
                v.xcuda_Gs_external_freight = gf;
            }

            gf.Amount_foreign_currency = Convert.ToSingle(a.Valuation.Gs_external_freight.Amount_foreign_currency);
            gf.Amount_national_currency = Convert.ToSingle(a.Valuation.Gs_external_freight.Amount_national_currency);
            gf.Currency_code = a.Valuation.Gs_external_freight.Currency_code.Text.FirstOrDefault();
            gf.Currency_name = a.Valuation.Gs_external_freight.Currency_name.Text.FirstOrDefault();
            gf.Currency_rate = Convert.ToSingle(a.Valuation.Gs_external_freight.Currency_rate);


        }

        private void Save_Gs_Invoice(xcuda_Valuation v)
        {
            var gi = v.xcuda_Gs_Invoice;
            if (gi == null)
            {
                gi = new xcuda_Gs_Invoice(true) { Valuation_Id = v.ASYCUDA_Id, TrackingState = TrackingState.Added };
                v.xcuda_Gs_Invoice = gi;
            }

            gi.Amount_foreign_currency = Convert.ToSingle(a.Valuation.Gs_Invoice.Amount_foreign_currency);
            gi.Amount_national_currency = Convert.ToSingle(a.Valuation.Gs_Invoice.Amount_national_currency);
            gi.Currency_code = a.Valuation.Gs_Invoice.Currency_code.Text.FirstOrDefault();
            gi.Currency_rate = Convert.ToSingle(a.Valuation.Gs_Invoice.Currency_rate);
            if (a.Valuation.Gs_Invoice.Currency_name.Text.Count != 0)
                gi.Currency_name = a.Valuation.Gs_Invoice.Currency_name.Text[0];
        }

        private void Save_Valuation_Weight(xcuda_Valuation v)
        {
            var w = v.xcuda_Weight;
            if (w == null)
            {
                w = new xcuda_Weight(true) { Valuation_Id = v.ASYCUDA_Id, TrackingState = TrackingState.Added };
                v.xcuda_Weight = w;
            }
            // w.Gross_weight = a.Valuation.Weight.Gross_weight
        }

        private async Task Save_Warehouse()
        {
            var w = da.Document.xcuda_Warehouse.FirstOrDefault();
            if (w == null)
            {
                w = new xcuda_Warehouse(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                da.Document.xcuda_Warehouse.Add(w);
            }
            w.Identification = a.Warehouse.Identification.Text.FirstOrDefault();
            w.Delay = a.Warehouse.Delay;
            //await DBaseDataModel.Instance.Savexcuda_Warehouse(w).ConfigureAwait(false);
        }

        private async Task SaveFinancial()
        {
            var f = da.Document.xcuda_Financial.FirstOrDefault();
            if (f == null)
            {
                f = new xcuda_Financial(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
               // await DBaseDataModel.Instance.Savexcuda_Financial(f).ConfigureAwait(false); 
               // da.Document.xcuda_Financial.Add(f);
            }
            if (a.Financial.Deffered_payment_reference.Text.Count != 0)
                f.Deffered_payment_reference = a.Financial.Deffered_payment_reference.Text[0];

            f.Mode_of_payment = a.Financial.Mode_of_payment;

            Save_Amounts(f);
            Save_Guarantee(f);
                //await DBaseDataModel.Instance.Savexcuda_Financial(f).ConfigureAwait(false); 

        }

        public ASYCUDA A
        {
            get { return a; }
            set { a = value; }
        }

        private void Save_Guarantee(xcuda_Financial f)
        {
            var g = f.xcuda_Financial_Guarantee.FirstOrDefault();
            if (g == null)
            {
                g = new xcuda_Financial_Guarantee(true) { Financial_Id = f.Financial_Id, TrackingState = TrackingState.Added };
                f.xcuda_Financial_Guarantee.Add(g);
            }
            if (a.Financial.Guarantee.Amount != "")
                g.Amount = Convert.ToDecimal(a.Financial.Guarantee.Amount);
            //  g.Date = a.Financial.Guarantee.Date;
        }

        private void Save_Amounts(xcuda_Financial f)
        {
            var fa = f.xcuda_Financial_Amounts.FirstOrDefault();
            if (fa == null)
            {
                fa = new xcuda_Financial_Amounts(true) { Financial_Id = f.Financial_Id, TrackingState = TrackingState.Added };
                f.xcuda_Financial_Amounts.Add(fa);
            }
            if (a.Financial.Amounts.Global_taxes != "")
                fa.Global_taxes = Convert.ToDecimal(a.Financial.Amounts.Global_taxes);
            // fa.Total_manual_taxes = a.Financial.Amounts.Total_manual_taxes;
            if (a.Financial.Amounts.Totals_taxes != "")
                fa.Totals_taxes = Convert.ToDecimal(a.Financial.Amounts.Totals_taxes);
        }

        private async Task SaveTransport()
        {
            var t = da.Document.xcuda_Transport.FirstOrDefault();
            if (t == null)
            {
                t = new xcuda_Transport(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                da.Document.xcuda_Transport.Add(t);
            }
            t.Container_flag = a.Transport.Container_flag;
            t.Single_waybill_flag = a.Transport.Single_waybill_flag;
            if (a.Transport.Location_of_goods.Text.Count != 0)
            {
                t.Location_of_goods = a.Transport.Location_of_goods.Text[0];
            }
            SaveMeansofTransport(t);
            Save_Delivery_terms(t);
            Save_Border_office(t);
            //await DBaseDataModel.Instance.Savexcuda_Transport(t).ConfigureAwait(false);
        }

        private void Save_Border_office(xcuda_Transport t)
        {
            var bo = t.xcuda_Border_office.FirstOrDefault();
            if (bo == null)
            {
                bo = new xcuda_Border_office(true) { Transport_Id = t.Transport_Id, TrackingState = TrackingState.Added };
                t.xcuda_Border_office.Add(bo);
            }
            if (a.Transport.Border_office.Code.Text.Count != 0)
                bo.Code = a.Transport.Border_office.Code.Text[0];

            if (a.Transport.Border_office.Name.Text.Count != 0)
                bo.Name = a.Transport.Border_office.Name.Text[0];

        }

        private void Save_Delivery_terms(xcuda_Transport t)
        {
            var d = t.xcuda_Delivery_terms.FirstOrDefault();
            if (d == null)
            {
                d = new xcuda_Delivery_terms(true) { Transport_Id = t.Transport_Id, TrackingState = TrackingState.Added };
                t.xcuda_Delivery_terms.Add(d);
            }
            if (a.Transport.Delivery_terms.Code.Text.Count != 0)
                d.Code = a.Transport.Delivery_terms.Code.Text[0];
            //d.Place = a.Transport.Delivery_terms.Place
        }

        private void SaveMeansofTransport(xcuda_Transport t)
        {
            var m = t.xcuda_Means_of_transport.FirstOrDefault();
            if (m == null)
            {
                m = new xcuda_Means_of_transport(true) { Transport_Id = t.Transport_Id, TrackingState = TrackingState.Added };
                t.xcuda_Means_of_transport.Add(m);

            }

            SaveDepartureArrivalInformation(m);
            SaveBorderInformation(m);
            //m.Inland_mode_of_transport = a.Transport.Means_of_transport.Inland_mode_of_transport.

        }



        private void SaveBorderInformation(xcuda_Means_of_transport m)
        {
            var d = m.xcuda_Border_information.FirstOrDefault();
            if (d == null)
            {
                d = new xcuda_Border_information(true) { Means_of_transport_Id = m.Means_of_transport_Id, TrackingState = TrackingState.Added };
                m.xcuda_Border_information.Add(d);
            }
            //if (a.Transport.Means_of_transport.Border_information.Nationality.ToString() != null)
            //    d.Nationality = a.Transport.Means_of_transport.Departure_arrival_information.Nationality.Text[0];

            //if (a.Transport.Means_of_transport.Departure_arrival_information.Identity.Text.Count != 0)
            //    d.Identity = a.Transport.Means_of_transport.Departure_arrival_information.Identity.Text[0];
            if (a.Transport.Means_of_transport.Border_information.Mode.Text.Count != 0)
                d.Mode = Convert.ToInt32(a.Transport.Means_of_transport.Border_information.Mode.Text[0]);
        }

        private void SaveDepartureArrivalInformation(xcuda_Means_of_transport m)
        {
            var d = m.xcuda_Departure_arrival_information.FirstOrDefault();
            if (d == null)
            {
                d = new xcuda_Departure_arrival_information(true) { Means_of_transport_Id = m.Means_of_transport_Id, TrackingState = TrackingState.Added };
                m.xcuda_Departure_arrival_information.Add(d);
            }
            if (a.Transport.Means_of_transport.Departure_arrival_information.Nationality.Text.Count != 0)
                d.Nationality = a.Transport.Means_of_transport.Departure_arrival_information.Nationality.Text[0];

            if (a.Transport.Means_of_transport.Departure_arrival_information.Identity.Text.Count != 0)
                d.Identity = a.Transport.Means_of_transport.Departure_arrival_information.Identity.Text[0];
        }

        private async Task SaveGeneralInformation()
        {
            var gi = da.Document.xcuda_General_information;
            if (gi == null)
            {
                gi = new xcuda_General_information() {ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                da.Document.xcuda_General_information = gi;
            }
            gi.Value_details = a.General_information.Value_details;
            gi.Comments_free_text = a.General_information.Comments_free_text.Text.FirstOrDefault();

            SetEffectiveAssessmentDate(da, gi.Comments_free_text);

            SaveCountry(gi);
            //await DBaseDataModel.Instance.Savexcuda_General_information(gi).ConfigureAwait(false);
        }

        private void SetEffectiveAssessmentDate(DocumentCT documentCt, string commentsFreeText)
        {
            if (string.IsNullOrEmpty(commentsFreeText)) return;
            documentCt.Document.xcuda_ASYCUDA_ExtendedProperties.EffectiveRegistrationDate = DateTime.ParseExact(commentsFreeText.Replace("EffectiveAssessmentDate:",""),"MMM-dd-yyyy",null);
        }

        private void SaveCountry(xcuda_General_information gi)
        {
            var c = gi.xcuda_Country;
            if (c == null)
            {
                c = new xcuda_Country(true) {Country_Id = gi.ASYCUDA_Id, TrackingState = TrackingState.Added };
                gi.xcuda_Country = c;
            }
            c.Country_first_destination = a.General_information.Country.Country_first_destination.Text.FirstOrDefault();
            c.Country_of_origin_name = a.General_information.Country.Country_of_origin_name;
            c.Trading_country = a.General_information.Country.Trading_country.Text.FirstOrDefault();
            SaveExport(c);
            SaveDestination(c);
        }

        private void SaveDestination(xcuda_Country c)
        {
            var des = c.xcuda_Destination;
            if (des == null)
            {
                des = new xcuda_Destination(true) { Country_Id = c.Country_Id, TrackingState = TrackingState.Added };
                c.xcuda_Destination = des;
                des.xcuda_Country = c;
                //await BaseDataModel.Instance.SaveDocumentCT(da).ConfigureAwait(false);
            }
            des.Destination_country_code = a.General_information.Country.Destination.Destination_country_code.Text.FirstOrDefault();
            if (a.General_information.Country.Destination.Destination_country_name != null)
                des.Destination_country_name = a.General_information.Country.Destination.Destination_country_name.Text.FirstOrDefault();
            //Exp.Export_country_region = a.General_information.Country.Export.Export_country_region.;
        }

        private void SaveExport(xcuda_Country c)
        {
            var Exp = c.xcuda_Export;
            if (Exp == null)
            {
                Exp = new xcuda_Export(true) { Country_Id = c.Country_Id, TrackingState = TrackingState.Added };
                c.xcuda_Export = Exp;
            }
            Exp.Export_country_code = a.General_information.Country.Export.Export_country_code.Text.FirstOrDefault();
            Exp.Export_country_name = a.General_information.Country.Export.Export_country_name.Text.FirstOrDefault();
            //Exp.Export_country_region = a.General_information.Country.Export.Export_country_region.;
        }

        private async Task SaveDeclarant()
        {
            try
            {
                var d = da.Document.xcuda_Declarant;//.FirstOrDefault();
                if (d == null)
                {
                    da.Document.xcuda_Declarant = new xcuda_Declarant(true) { ASYCUDA_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                    d = da.Document.xcuda_Declarant;
                    //da.xcuda_Declarant.Add(d);
                }

                d.Declarant_name = a.Declarant.Declarant_name;
                d.Declarant_representative = a.Declarant.Declarant_representative.Text.FirstOrDefault();
                d.Declarant_code = a.Declarant.Declarant_code;

                //if(a.Declarant.Reference.Number.Text.Count > 0)
                d.Number = a.Declarant.Reference.Number.Text.FirstOrDefault();
                //await DBaseDataModel.Instance.Savexcuda_Declarant(d).ConfigureAwait(false);
            }
            catch (Exception Ex)
            {
                throw new Exception("Declarant fail to import - " + a.Declarant.Reference.Number);
            }

        }

        private async Task SaveTraders()
        {
            var t = da.Document.xcuda_Traders;
            if (t == null)
            {
                t = new xcuda_Traders(true) { Traders_Id = da.Document.ASYCUDA_Id, TrackingState = TrackingState.Added };
                da.Document.xcuda_Traders = t;
            }
            SaveExporter(t);
            SaveConsignee(t);
            SaveTradersFinancial(t);
            //await DBaseDataModel.Instance.Savexcuda_Traders(t).ConfigureAwait(false);
        }

        private void SaveTradersFinancial(xcuda_Traders t)
        {
            if (a.Traders.Financial.Financial_code.Text.Count == 0) return;
            var f = t.xcuda_Traders_Financial;
            if (f == null)
            {
                f = new xcuda_Traders_Financial(true) { Traders_Id = t.Traders_Id, TrackingState = TrackingState.Added };
                t.xcuda_Traders_Financial = f;
            }
            if (a.Traders.Financial.Financial_code.Text.Count != 0)
            {
                f.Financial_code = a.Traders.Financial.Financial_code.Text[0];
            }
            if (a.Traders.Financial.Financial_name.Text.Count != 0)
            {
                f.Financial_name = a.Traders.Financial.Financial_name.Text[0];
            }
        }

        private void SaveConsignee(xcuda_Traders t)
        {
            var c = t.xcuda_Consignee;
            if (c == null)
            {
                c = new xcuda_Consignee(true) { Traders_Id = t.Traders_Id, TrackingState = TrackingState.Added };
                t.xcuda_Consignee = c;
            }
            if (a.Traders.Consignee.Consignee_code.Text.Count != 0)
            {
                c.Consignee_code = a.Traders.Consignee.Consignee_code.Text[0];
            }
            if (a.Traders.Consignee.Consignee_name.Text.Count != 0)
            {
                c.Consignee_name = a.Traders.Consignee.Consignee_name.Text[0];
            }
        }

        private void SaveExporter(xcuda_Traders t)
        {
            var e = t.xcuda_Exporter;
            if (e == null)
            {
                e = new xcuda_Exporter(true) { Traders_Id = t.Traders_Id, TrackingState = TrackingState.Added };
                t.xcuda_Exporter = e;
            }

            if (a.Traders.Exporter.Exporter_name.Text.Count != 0)
            {
                e.Exporter_code = a.Traders.Exporter.Exporter_name.Text[0];
            }

            if (a.Traders.Exporter.Exporter_code.Text.Count != 0)
            {
                e.Exporter_code = a.Traders.Exporter.Exporter_code.Text[0];
            }
        }

        private async Task SaveProperty()
        {
            var p = da.Document.xcuda_Property;//.FirstOrDefault();

            if (p == null)
            {
                p = new xcuda_Property(true) { TrackingState = TrackingState.Added };
                da.Document.xcuda_Property = p;
                // da.xcuda_Property.Add(p);
            }
            // p.Date_of_declaration = a.Property.Date_of_declaration.ToString();
            SaveNbers(p);
            //await DBaseDataModel.Instance.Savexcuda_Property(p).ConfigureAwait(false);
        }

        private void SaveNbers(xcuda_Property p)
        {

            var n = p.xcuda_Nbers;//.FirstOrDefault();
            if (n == null)
            {
                n = new xcuda_Nbers(true) { ASYCUDA_Id = p.ASYCUDA_Id, TrackingState = TrackingState.Added };
                p.xcuda_Nbers = n;
                //  p.xcuda_Nbers.Add(n);
            }
            n.Number_of_loading_lists = a.Property.Nbers.Number_of_loading_lists;
            n.Total_number_of_packages = Convert.ToSingle(string.IsNullOrEmpty(a.Property.Nbers.Total_number_of_packages) ? "0" : a.Property.Nbers.Total_number_of_packages);
            n.Total_number_of_items = a.Property.Nbers.Total_number_of_items;

        }

        private async Task SaveIdentification()
        {
            var di = da.Document.xcuda_Identification;//.FirstOrDefault();
            if (di == null)
            {
                di = new xcuda_Identification(true) { TrackingState = TrackingState.Added };
                da.Document.xcuda_Identification = di;
                // da.xcuda_Identification.Add(di);
            }

            SaveManifestReferenceNumber(di);
            SaveOfficeSegment(di);
            SaveRegistration(di);
            await SaveType(di).ConfigureAwait(false);

            //await DBaseDataModel.Instance.Savexcuda_Identification(di).ConfigureAwait(false);

        }

        private async Task SaveType(xcuda_Identification di)
        {
            var t = di.xcuda_Type;
            if (t == null)
            {
                t = new xcuda_Type(true) { TrackingState = TrackingState.Added };
                di.xcuda_Type = t;
            }

            t.Declaration_gen_procedure_code = a.Identification.Type.Declaration_gen_procedure_code;
            t.Type_of_declaration = a.Identification.Type.Type_of_declaration;

            var dt = await GetDocumentType(t).ConfigureAwait(false);
            da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_TypeId = dt.Document_TypeId;
            da.Document.xcuda_ASYCUDA_ExtendedProperties.Document_Type = dt;

            //await
            //    DBaseDataModel.Instance.Savexcuda_ASYCUDA_ExtendedProperties(
            //        da.Document.xcuda_ASYCUDA_ExtendedProperties).ConfigureAwait(false);
        }

        private async Task<Document_Type> GetDocumentType(xcuda_Type t)
        {
            var dt =
                 BaseDataModel.Instance.Document_TypeCache.GetSingle(x => x.Declaration_gen_procedure_code == t.Declaration_gen_procedure_code
                                                   && x.Type_of_declaration == t.Type_of_declaration);
            ////    (await DBaseDataModel.Instance.SearchDocument_Type(new List<string>()
            ////{
            ////    string.Format("Declaration_gen_procedure_code == \"{0}\"", t.Declaration_gen_procedure_code),
            ////    string.Format("Type_of_declaration == \"{0}\"", t.Type_of_declaration)
            ////}).ConfigureAwait(false)).FirstOrDefault();

            if (dt == null)
            {

                dt = new Document_Type(true)
                {
                    Type_of_declaration = t.Type_of_declaration,
                    Declaration_gen_procedure_code = t.Declaration_gen_procedure_code,
                    TrackingState = TrackingState.Added
                };
               
                await DBaseDataModel.Instance.SaveDocument_Type(dt).ConfigureAwait(false);
                BaseDataModel.Instance.Document_TypeCache.AddItem(dt);
               
            }
            return dt;
        }

        private void SaveManifestReferenceNumber(xcuda_Identification di)
        {
            //xcuda_Manifest_reference_number r = di.xcuda_Manifest_reference_number;//.FirstOrDefault();
            //if (r == null)
            //{
            //    r = new xcuda_Manifest_reference_number();
            //    di.xcuda_Manifest_reference_number = r;
            //    //di.xcuda_Manifest_reference_number.Add(r);
            //}
            if (a.Identification.Manifest_reference_number.Text.Count != 0)
                di.Manifest_reference_number = a.Identification.Manifest_reference_number.Text[0];

        }

        private void SaveOfficeSegment(xcuda_Identification di)
        {
            var o = di.xcuda_Office_segment;//.FirstOrDefault();
            if (o == null)
            {
                o = new xcuda_Office_segment(true) { ASYCUDA_Id = di.ASYCUDA_Id, TrackingState = TrackingState.Added };
                di.xcuda_Office_segment = o;
                // di.xcuda_Office_segment.Add(o);
            }
            o.Customs_clearance_office_code = a.Identification.Office_segment.Customs_clearance_office_code.Text.FirstOrDefault();
            o.Customs_Clearance_office_name = a.Identification.Office_segment.Customs_Clearance_office_name.Text.FirstOrDefault();

        }

        private void SaveRegistration(xcuda_Identification di)
        {
            var r = di.xcuda_Registration;
            if (r == null)
            {
                r = new xcuda_Registration(true) { ASYCUDA_Id = di.ASYCUDA_Id, TrackingState = TrackingState.Added };
                di.xcuda_Registration = r;
                // di.xcuda_Registration.Add(r);
            }
            if (a.Identification.Registration.Date != "1/1/0001")
                r.Date = a.Identification.Registration.Date;
            if (a.Identification.Registration.Number != "")
                r.Number = a.Identification.Registration.Number;

        }
    }
}
