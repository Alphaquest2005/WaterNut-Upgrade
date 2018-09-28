﻿// <autogenerated>
//   This file was generated by T4 code generator AllQuerySpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Schedulers;
using SimpleMvvmToolkit;
using System;
using System.Windows;
using System.Windows.Data;
using System.Text;
using Core.Common.UI.DataVirtualization;
using System.Collections.Generic;
using Core.Common.UI;
using Core.Common.Converters;

using OversShortQS.Client.Entities;
using OversShortQS.Client.Repositories;
//using WaterNut.Client.Repositories;


namespace WaterNut.QuerySpace.OversShortQS.ViewModels
{
    
	public partial class AsycudaDocumentItemViewModel_AutoGen : ViewModelBase<AsycudaDocumentItemViewModel_AutoGen>
	{

       private static readonly AsycudaDocumentItemViewModel_AutoGen instance;
       static AsycudaDocumentItemViewModel_AutoGen()
        {
            instance = new AsycudaDocumentItemViewModel_AutoGen();
        }

       public static AsycudaDocumentItemViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public AsycudaDocumentItemViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<AsycudaDocumentItem>(MessageToken.CurrentAsycudaDocumentItemChanged, OnCurrentAsycudaDocumentItemChanged);
            RegisterToReceiveMessages(MessageToken.AsycudaDocumentItemsChanged, OnAsycudaDocumentItemsChanged);
			RegisterToReceiveMessages(MessageToken.AsycudaDocumentItemsFilterExpressionChanged, OnAsycudaDocumentItemsFilterExpressionChanged);

 
			RegisterToReceiveMessages<AsycudaDocument>(MessageToken.CurrentAsycudaDocumentChanged, OnCurrentAsycudaDocumentChanged);

 			// Recieve messages for Core Current Entities Changed
 

			AsycudaDocumentItems = new VirtualList<AsycudaDocumentItem>(vloader);
			AsycudaDocumentItems.LoadingStateChanged += AsycudaDocumentItems_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(AsycudaDocumentItems, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<AsycudaDocumentItem> _AsycudaDocumentItems = null;
        public VirtualList<AsycudaDocumentItem> AsycudaDocumentItems
        {
            get
            {
                return _AsycudaDocumentItems;
            }
            set
            {
                _AsycudaDocumentItems = value;
            }
        }

		 private void OnAsycudaDocumentItemsFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			AsycudaDocumentItems.Refresh();
            SelectedAsycudaDocumentItems.Clear();
            NotifyPropertyChanged(x => SelectedAsycudaDocumentItems);
            BeginSendMessage(MessageToken.SelectedAsycudaDocumentItemsChanged, new NotificationEventArgs(MessageToken.SelectedAsycudaDocumentItemsChanged));
        }

		void AsycudaDocumentItems_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (AsycudaDocumentItems.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => AsycudaDocumentItems);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("AsycudaDocumentItems | Error occured..." + AsycudaDocumentItems.LastLoadingError.Message);
                    NotifyPropertyChanged(x => AsycudaDocumentItems);
                    break;
            }
           
        }

		
		public readonly AsycudaDocumentItemVirturalListLoader vloader = new AsycudaDocumentItemVirturalListLoader();

		private ObservableCollection<AsycudaDocumentItem> _selectedAsycudaDocumentItems = new ObservableCollection<AsycudaDocumentItem>();
        public ObservableCollection<AsycudaDocumentItem> SelectedAsycudaDocumentItems
        {
            get
            {
                return _selectedAsycudaDocumentItems;
            }
            set
            {
                _selectedAsycudaDocumentItems = value;
				BeginSendMessage(MessageToken.SelectedAsycudaDocumentItemsChanged,
                                    new NotificationEventArgs(MessageToken.SelectedAsycudaDocumentItemsChanged));
				 NotifyPropertyChanged(x => SelectedAsycudaDocumentItems);
            }
        }

        internal void OnCurrentAsycudaDocumentItemChanged(object sender, NotificationEventArgs<AsycudaDocumentItem> e)
        {
            if(BaseViewModel.Instance.CurrentAsycudaDocumentItem != null) BaseViewModel.Instance.CurrentAsycudaDocumentItem.PropertyChanged += CurrentAsycudaDocumentItem__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentAsycudaDocumentItem);
        }   

            void CurrentAsycudaDocumentItem__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddAsycudaDocument")
                   // {
                   //    if(AsycudaDocuments.Contains(CurrentAsycudaDocumentItem.AsycudaDocument) == false) AsycudaDocuments.Add(CurrentAsycudaDocumentItem.AsycudaDocument);
                    //}
                 } 
        internal void OnAsycudaDocumentItemsChanged(object sender, NotificationEventArgs e)
        {
            _AsycudaDocumentItems.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentItems);
        }   


 	
		 internal void OnCurrentAsycudaDocumentChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<AsycudaDocument> e)
			{
			if(ViewCurrentAsycudaDocument == false) return;
			if (e.Data == null || e.Data.ASYCUDA_Id == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("AsycudaDocumentId == {0}", e.Data.ASYCUDA_Id.ToString());
                 }

				AsycudaDocumentItems.Refresh();
				NotifyPropertyChanged(x => this.AsycudaDocumentItems);
                // SendMessage(MessageToken.AsycudaDocumentItemsChanged, new NotificationEventArgs(MessageToken.AsycudaDocumentItemsChanged));
                                          
                BaseViewModel.Instance.CurrentAsycudaDocumentItem = null;
			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentAsycudaDocument = false;
         public bool ViewCurrentAsycudaDocument
         {
             get
             {
                 return _viewCurrentAsycudaDocument;
             }
             set
             {
                 _viewCurrentAsycudaDocument = value;
                 NotifyPropertyChanged(x => x.ViewCurrentAsycudaDocument);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_AsycudaDocumentItems.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentItems);
		}

		public async Task SelectAll()
        {
            IEnumerable<AsycudaDocumentItem> lst = null;
            using (var ctx = new AsycudaDocumentItemRepository())
            {
                lst = await ctx.GetAsycudaDocumentItemsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedAsycudaDocumentItems = new ObservableCollection<AsycudaDocumentItem>(lst);
        }

 

		private Int32? _lineNumberFilter;
        public Int32? LineNumberFilter
        {
            get
            {
                return _lineNumberFilter;
            }
            set
            {
                _lineNumberFilter = value;
				NotifyPropertyChanged(x => LineNumberFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _isAssessedFilter;
        public Boolean? IsAssessedFilter
        {
            get
            {
                return _isAssessedFilter;
            }
            set
            {
                _isAssessedFilter = value;
				NotifyPropertyChanged(x => IsAssessedFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _doNotAllocateFilter;
        public Boolean? DoNotAllocateFilter
        {
            get
            {
                return _doNotAllocateFilter;
            }
            set
            {
                _doNotAllocateFilter = value;
				NotifyPropertyChanged(x => DoNotAllocateFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _doNotEXFilter;
        public Boolean? DoNotEXFilter
        {
            get
            {
                return _doNotEXFilter;
            }
            set
            {
                _doNotEXFilter = value;
				NotifyPropertyChanged(x => DoNotEXFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _attributeOnlyAllocationFilter;
        public Boolean? AttributeOnlyAllocationFilter
        {
            get
            {
                return _attributeOnlyAllocationFilter;
            }
            set
            {
                _attributeOnlyAllocationFilter = value;
				NotifyPropertyChanged(x => AttributeOnlyAllocationFilter);
                FilterData();
                
            }
        }	

 

		private string _description_of_goodsFilter;
        public string Description_of_goodsFilter
        {
            get
            {
                return _description_of_goodsFilter;
            }
            set
            {
                _description_of_goodsFilter = value;
				NotifyPropertyChanged(x => Description_of_goodsFilter);
                FilterData();
                
            }
        }	

 

		private string _commercial_DescriptionFilter;
        public string Commercial_DescriptionFilter
        {
            get
            {
                return _commercial_DescriptionFilter;
            }
            set
            {
                _commercial_DescriptionFilter = value;
				NotifyPropertyChanged(x => Commercial_DescriptionFilter);
                FilterData();
                
            }
        }	

 

		private Double? _gross_weight_itmFilter;
        public Double? Gross_weight_itmFilter
        {
            get
            {
                return _gross_weight_itmFilter;
            }
            set
            {
                _gross_weight_itmFilter = value;
				NotifyPropertyChanged(x => Gross_weight_itmFilter);
                FilterData();
                
            }
        }	

 

		private Double? _net_weight_itmFilter;
        public Double? Net_weight_itmFilter
        {
            get
            {
                return _net_weight_itmFilter;
            }
            set
            {
                _net_weight_itmFilter = value;
				NotifyPropertyChanged(x => Net_weight_itmFilter);
                FilterData();
                
            }
        }	

 

		private Double? _item_priceFilter;
        public Double? Item_priceFilter
        {
            get
            {
                return _item_priceFilter;
            }
            set
            {
                _item_priceFilter = value;
				NotifyPropertyChanged(x => Item_priceFilter);
                FilterData();
                
            }
        }	

 

		private Double? _itemQuantityFilter;
        public Double? ItemQuantityFilter
        {
            get
            {
                return _itemQuantityFilter;
            }
            set
            {
                _itemQuantityFilter = value;
				NotifyPropertyChanged(x => ItemQuantityFilter);
                FilterData();
                
            }
        }	

 

		private string _suppplementary_unit_codeFilter;
        public string Suppplementary_unit_codeFilter
        {
            get
            {
                return _suppplementary_unit_codeFilter;
            }
            set
            {
                _suppplementary_unit_codeFilter = value;
				NotifyPropertyChanged(x => Suppplementary_unit_codeFilter);
                FilterData();
                
            }
        }	

 

		private string _itemNumberFilter;
        public string ItemNumberFilter
        {
            get
            {
                return _itemNumberFilter;
            }
            set
            {
                _itemNumberFilter = value;
				NotifyPropertyChanged(x => ItemNumberFilter);
                FilterData();
                
            }
        }	

 

		private string _tariffCodeFilter;
        public string TariffCodeFilter
        {
            get
            {
                return _tariffCodeFilter;
            }
            set
            {
                _tariffCodeFilter = value;
				NotifyPropertyChanged(x => TariffCodeFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _tariffCodeLicenseRequiredFilter;
        public Boolean? TariffCodeLicenseRequiredFilter
        {
            get
            {
                return _tariffCodeLicenseRequiredFilter;
            }
            set
            {
                _tariffCodeLicenseRequiredFilter = value;
				NotifyPropertyChanged(x => TariffCodeLicenseRequiredFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _tariffCategoryLicenseRequiredFilter;
        public Boolean? TariffCategoryLicenseRequiredFilter
        {
            get
            {
                return _tariffCategoryLicenseRequiredFilter;
            }
            set
            {
                _tariffCategoryLicenseRequiredFilter = value;
				NotifyPropertyChanged(x => TariffCategoryLicenseRequiredFilter);
                FilterData();
                
            }
        }	

 

		private string _tariffCodeDescriptionFilter;
        public string TariffCodeDescriptionFilter
        {
            get
            {
                return _tariffCodeDescriptionFilter;
            }
            set
            {
                _tariffCodeDescriptionFilter = value;
				NotifyPropertyChanged(x => TariffCodeDescriptionFilter);
                FilterData();
                
            }
        }	

 

		private Double? _dutyLiabilityFilter;
        public Double? DutyLiabilityFilter
        {
            get
            {
                return _dutyLiabilityFilter;
            }
            set
            {
                _dutyLiabilityFilter = value;
				NotifyPropertyChanged(x => DutyLiabilityFilter);
                FilterData();
                
            }
        }	

 

		private Double? _total_CIF_itmFilter;
        public Double? Total_CIF_itmFilter
        {
            get
            {
                return _total_CIF_itmFilter;
            }
            set
            {
                _total_CIF_itmFilter = value;
				NotifyPropertyChanged(x => Total_CIF_itmFilter);
                FilterData();
                
            }
        }	

 

		private Double? _freightFilter;
        public Double? FreightFilter
        {
            get
            {
                return _freightFilter;
            }
            set
            {
                _freightFilter = value;
				NotifyPropertyChanged(x => FreightFilter);
                FilterData();
                
            }
        }	

 

		private Double? _statistical_valueFilter;
        public Double? Statistical_valueFilter
        {
            get
            {
                return _statistical_valueFilter;
            }
            set
            {
                _statistical_valueFilter = value;
				NotifyPropertyChanged(x => Statistical_valueFilter);
                FilterData();
                
            }
        }	

 

		private Double? _dPQtyAllocatedFilter;
        public Double? DPQtyAllocatedFilter
        {
            get
            {
                return _dPQtyAllocatedFilter;
            }
            set
            {
                _dPQtyAllocatedFilter = value;
				NotifyPropertyChanged(x => DPQtyAllocatedFilter);
                FilterData();
                
            }
        }	

 

		private Double? _dFQtyAllocatedFilter;
        public Double? DFQtyAllocatedFilter
        {
            get
            {
                return _dFQtyAllocatedFilter;
            }
            set
            {
                _dFQtyAllocatedFilter = value;
				NotifyPropertyChanged(x => DFQtyAllocatedFilter);
                FilterData();
                
            }
        }	

 

		private Double? _piQuantityFilter;
        public Double? PiQuantityFilter
        {
            get
            {
                return _piQuantityFilter;
            }
            set
            {
                _piQuantityFilter = value;
				NotifyPropertyChanged(x => PiQuantityFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _importCompleteFilter;
        public Boolean? ImportCompleteFilter
        {
            get
            {
                return _importCompleteFilter;
            }
            set
            {
                _importCompleteFilter = value;
				NotifyPropertyChanged(x => ImportCompleteFilter);
                FilterData();
                
            }
        }	

 
		internal bool DisableBaseFilterData = false;
        public virtual void FilterData()
	    {
	        FilterData(null);
	    }
		public void FilterData(StringBuilder res = null)
		{
		    if (DisableBaseFilterData) return;
			if(res == null) res = GetAutoPropertyFilterString();
			if (res.Length == 0 && vloader.NavigationExpression.Count != 0) res.Append("&& All");					
			if (res.Length > 0)
            {
                vloader.FilterExpression = res.ToString().Trim().Substring(2).Trim();
            }
            else
            {
                 if (vloader.FilterExpression != "All") vloader.FilterExpression = null;
            }

			AsycudaDocumentItems.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentItems);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

					if(LineNumberFilter.HasValue)
						res.Append(" && " + string.Format("LineNumber == {0}",  LineNumberFilter.ToString()));				 

									if(IsAssessedFilter.HasValue)
						res.Append(" && " + string.Format("IsAssessed == {0}",  IsAssessedFilter));						
 

									if(DoNotAllocateFilter.HasValue)
						res.Append(" && " + string.Format("DoNotAllocate == {0}",  DoNotAllocateFilter));						
 

									if(DoNotEXFilter.HasValue)
						res.Append(" && " + string.Format("DoNotEX == {0}",  DoNotEXFilter));						
 

									if(AttributeOnlyAllocationFilter.HasValue)
						res.Append(" && " + string.Format("AttributeOnlyAllocation == {0}",  AttributeOnlyAllocationFilter));						
 

									if(string.IsNullOrEmpty(Description_of_goodsFilter) == false)
						res.Append(" && " + string.Format("Description_of_goods.Contains(\"{0}\")",  Description_of_goodsFilter));						
 

									if(string.IsNullOrEmpty(Commercial_DescriptionFilter) == false)
						res.Append(" && " + string.Format("Commercial_Description.Contains(\"{0}\")",  Commercial_DescriptionFilter));						
 

					if(Gross_weight_itmFilter.HasValue)
						res.Append(" && " + string.Format("Gross_weight_itm == {0}",  Gross_weight_itmFilter.ToString()));				 

					if(Net_weight_itmFilter.HasValue)
						res.Append(" && " + string.Format("Net_weight_itm == {0}",  Net_weight_itmFilter.ToString()));				 

					if(Item_priceFilter.HasValue)
						res.Append(" && " + string.Format("Item_price == {0}",  Item_priceFilter.ToString()));				 

					if(ItemQuantityFilter.HasValue)
						res.Append(" && " + string.Format("ItemQuantity == {0}",  ItemQuantityFilter.ToString()));				 

									if(string.IsNullOrEmpty(Suppplementary_unit_codeFilter) == false)
						res.Append(" && " + string.Format("Suppplementary_unit_code.Contains(\"{0}\")",  Suppplementary_unit_codeFilter));						
 

									if(string.IsNullOrEmpty(ItemNumberFilter) == false)
						res.Append(" && " + string.Format("ItemNumber.Contains(\"{0}\")",  ItemNumberFilter));						
 

									if(string.IsNullOrEmpty(TariffCodeFilter) == false)
						res.Append(" && " + string.Format("TariffCode.Contains(\"{0}\")",  TariffCodeFilter));						
 

									if(TariffCodeLicenseRequiredFilter.HasValue)
						res.Append(" && " + string.Format("TariffCodeLicenseRequired == {0}",  TariffCodeLicenseRequiredFilter));						
 

									if(TariffCategoryLicenseRequiredFilter.HasValue)
						res.Append(" && " + string.Format("TariffCategoryLicenseRequired == {0}",  TariffCategoryLicenseRequiredFilter));						
 

									if(string.IsNullOrEmpty(TariffCodeDescriptionFilter) == false)
						res.Append(" && " + string.Format("TariffCodeDescription.Contains(\"{0}\")",  TariffCodeDescriptionFilter));						
 

					if(DutyLiabilityFilter.HasValue)
						res.Append(" && " + string.Format("DutyLiability == {0}",  DutyLiabilityFilter.ToString()));				 

					if(Total_CIF_itmFilter.HasValue)
						res.Append(" && " + string.Format("Total_CIF_itm == {0}",  Total_CIF_itmFilter.ToString()));				 

					if(FreightFilter.HasValue)
						res.Append(" && " + string.Format("Freight == {0}",  FreightFilter.ToString()));				 

					if(Statistical_valueFilter.HasValue)
						res.Append(" && " + string.Format("Statistical_value == {0}",  Statistical_valueFilter.ToString()));				 

					if(DPQtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("DPQtyAllocated == {0}",  DPQtyAllocatedFilter.ToString()));				 

					if(DFQtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("DFQtyAllocated == {0}",  DFQtyAllocatedFilter.ToString()));				 

					if(PiQuantityFilter.HasValue)
						res.Append(" && " + string.Format("PiQuantity == {0}",  PiQuantityFilter.ToString()));				 

									if(ImportCompleteFilter.HasValue)
						res.Append(" && " + string.Format("ImportComplete == {0}",  ImportCompleteFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<AsycudaDocumentItem> lst = null;
            using (var ctx = new AsycudaDocumentItemRepository())
            {
                lst = await ctx.GetAsycudaDocumentItemsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToCSV<AsycudaDocumentItemExcelLine, List<AsycudaDocumentItemExcelLine>>
            {
                dataToPrint = lst.Select(x => new AsycudaDocumentItemExcelLine
                {
 
                    LineNumber = Convert.ToUInt16(x.LineNumber) ,
                    
 
                    IsAssessed = x.IsAssessed ,
                    
 
                    DoNotAllocate = x.DoNotAllocate ,
                    
 
                    DoNotEX = x.DoNotEX ,
                    
 
                    AttributeOnlyAllocation = x.AttributeOnlyAllocation ,
                    
 
                    Description_of_goods = x.Description_of_goods ,
                    
 
                    Commercial_Description = x.Commercial_Description ,
                    
 
                    Gross_weight_itm = x.Gross_weight_itm ,
                    
 
                    Net_weight_itm = x.Net_weight_itm ,
                    
 
                    Item_price = x.Item_price ,
                    
 
                    ItemQuantity = x.ItemQuantity ,
                    
 
                    Suppplementary_unit_code = x.Suppplementary_unit_code ,
                    
 
                    ItemNumber = x.ItemNumber ,
                    
 
                    TariffCode = x.TariffCode ,
                    
 
                    TariffCodeLicenseRequired = x.TariffCodeLicenseRequired ,
                    
 
                    TariffCategoryLicenseRequired = x.TariffCategoryLicenseRequired ,
                    
 
                    TariffCodeDescription = x.TariffCodeDescription ,
                    
 
                    DutyLiability = x.DutyLiability ,
                    
 
                    Total_CIF_itm = x.Total_CIF_itm ,
                    
 
                    Freight = x.Freight ,
                    
 
                    Statistical_value = x.Statistical_value ,
                    
 
                    DPQtyAllocated = Convert.ToDouble(x.DPQtyAllocated) ,
                    
 
                    DFQtyAllocated = Convert.ToDouble(x.DFQtyAllocated) ,
                    
 
                    PiQuantity = x.PiQuantity ,
                    
 
                    ImportComplete = Convert.ToBoolean(x.ImportComplete)
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class AsycudaDocumentItemExcelLine
        {
		 
                    public int LineNumber { get; set; } 
                    
 
                    public Nullable<bool> IsAssessed { get; set; } 
                    
 
                    public Nullable<bool> DoNotAllocate { get; set; } 
                    
 
                    public Nullable<bool> DoNotEX { get; set; } 
                    
 
                    public Nullable<bool> AttributeOnlyAllocation { get; set; } 
                    
 
                    public string Description_of_goods { get; set; } 
                    
 
                    public string Commercial_Description { get; set; } 
                    
 
                    public double Gross_weight_itm { get; set; } 
                    
 
                    public Nullable<double> Net_weight_itm { get; set; } 
                    
 
                    public Nullable<double> Item_price { get; set; } 
                    
 
                    public Nullable<double> ItemQuantity { get; set; } 
                    
 
                    public string Suppplementary_unit_code { get; set; } 
                    
 
                    public string ItemNumber { get; set; } 
                    
 
                    public string TariffCode { get; set; } 
                    
 
                    public Nullable<bool> TariffCodeLicenseRequired { get; set; } 
                    
 
                    public Nullable<bool> TariffCategoryLicenseRequired { get; set; } 
                    
 
                    public string TariffCodeDescription { get; set; } 
                    
 
                    public Nullable<double> DutyLiability { get; set; } 
                    
 
                    public Nullable<double> Total_CIF_itm { get; set; } 
                    
 
                    public Nullable<double> Freight { get; set; } 
                    
 
                    public Nullable<double> Statistical_value { get; set; } 
                    
 
                    public double DPQtyAllocated { get; set; } 
                    
 
                    public double DFQtyAllocated { get; set; } 
                    
 
                    public Nullable<double> PiQuantity { get; set; } 
                    
 
                    public bool ImportComplete { get; set; } 
                    
        }

		
    }
}
		
