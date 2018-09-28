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

using CoreEntities.Client.Entities;
using CoreEntities.Client.Repositories;
//using WaterNut.Client.Repositories;


namespace WaterNut.QuerySpace.CoreEntities.ViewModels
{
    
	public partial class Customs_ProcedureViewModel_AutoGen : ViewModelBase<Customs_ProcedureViewModel_AutoGen>
	{

       private static readonly Customs_ProcedureViewModel_AutoGen instance;
       static Customs_ProcedureViewModel_AutoGen()
        {
            instance = new Customs_ProcedureViewModel_AutoGen();
        }

       public static Customs_ProcedureViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public Customs_ProcedureViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<Customs_Procedure>(MessageToken.CurrentCustoms_ProcedureChanged, OnCurrentCustoms_ProcedureChanged);
            RegisterToReceiveMessages(MessageToken.Customs_ProcedureChanged, OnCustoms_ProcedureChanged);
			RegisterToReceiveMessages(MessageToken.Customs_ProcedureFilterExpressionChanged, OnCustoms_ProcedureFilterExpressionChanged);

 
			RegisterToReceiveMessages<Document_Type>(MessageToken.CurrentDocument_TypeChanged, OnCurrentDocument_TypeChanged);

 			// Recieve messages for Core Current Entities Changed
 

			Customs_Procedure = new VirtualList<Customs_Procedure>(vloader);
			Customs_Procedure.LoadingStateChanged += Customs_Procedure_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(Customs_Procedure, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<Customs_Procedure> _Customs_Procedure = null;
        public VirtualList<Customs_Procedure> Customs_Procedure
        {
            get
            {
                return _Customs_Procedure;
            }
            set
            {
                _Customs_Procedure = value;
            }
        }

		 private void OnCustoms_ProcedureFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			Customs_Procedure.Refresh();
            SelectedCustoms_Procedure.Clear();
            NotifyPropertyChanged(x => SelectedCustoms_Procedure);
            BeginSendMessage(MessageToken.SelectedCustoms_ProcedureChanged, new NotificationEventArgs(MessageToken.SelectedCustoms_ProcedureChanged));
        }

		void Customs_Procedure_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (Customs_Procedure.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => Customs_Procedure);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("Customs_Procedure | Error occured..." + Customs_Procedure.LastLoadingError.Message);
                    NotifyPropertyChanged(x => Customs_Procedure);
                    break;
            }
           
        }

		
		public readonly Customs_ProcedureVirturalListLoader vloader = new Customs_ProcedureVirturalListLoader();

		private ObservableCollection<Customs_Procedure> _selectedCustoms_Procedure = new ObservableCollection<Customs_Procedure>();
        public ObservableCollection<Customs_Procedure> SelectedCustoms_Procedure
        {
            get
            {
                return _selectedCustoms_Procedure;
            }
            set
            {
                _selectedCustoms_Procedure = value;
				BeginSendMessage(MessageToken.SelectedCustoms_ProcedureChanged,
                                    new NotificationEventArgs(MessageToken.SelectedCustoms_ProcedureChanged));
				 NotifyPropertyChanged(x => SelectedCustoms_Procedure);
            }
        }

        internal void OnCurrentCustoms_ProcedureChanged(object sender, NotificationEventArgs<Customs_Procedure> e)
        {
            if(BaseViewModel.Instance.CurrentCustoms_Procedure != null) BaseViewModel.Instance.CurrentCustoms_Procedure.PropertyChanged += CurrentCustoms_Procedure__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentCustoms_Procedure);
        }   

            void CurrentCustoms_Procedure__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddDocument_Type")
                   // {
                   //    if(Document_Type.Contains(CurrentCustoms_Procedure.Document_Type) == false) Document_Type.Add(CurrentCustoms_Procedure.Document_Type);
                    //}
                 } 
        internal void OnCustoms_ProcedureChanged(object sender, NotificationEventArgs e)
        {
            _Customs_Procedure.Refresh();
			NotifyPropertyChanged(x => this.Customs_Procedure);
        }   


 	
		 internal void OnCurrentDocument_TypeChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<Document_Type> e)
			{
			if(ViewCurrentDocument_Type == false) return;
			if (e.Data == null || e.Data.Document_TypeId == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("Document_TypeId == {0}", e.Data.Document_TypeId.ToString());
                 }

				Customs_Procedure.Refresh();
				NotifyPropertyChanged(x => this.Customs_Procedure);
                // SendMessage(MessageToken.Customs_ProcedureChanged, new NotificationEventArgs(MessageToken.Customs_ProcedureChanged));
                                          
                BaseViewModel.Instance.CurrentCustoms_Procedure = null;
			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentDocument_Type = true;
         public bool ViewCurrentDocument_Type
         {
             get
             {
                 return _viewCurrentDocument_Type;
             }
             set
             {
                 _viewCurrentDocument_Type = value;
                 NotifyPropertyChanged(x => x.ViewCurrentDocument_Type);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_Customs_Procedure.Refresh();
			NotifyPropertyChanged(x => this.Customs_Procedure);
		}

		public async Task SelectAll()
        {
            IEnumerable<Customs_Procedure> lst = null;
            using (var ctx = new Customs_ProcedureRepository())
            {
                lst = await ctx.GetCustoms_ProcedureByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedCustoms_Procedure = new ObservableCollection<Customs_Procedure>(lst);
        }

 

		private string _extended_customs_procedureFilter;
        public string Extended_customs_procedureFilter
        {
            get
            {
                return _extended_customs_procedureFilter;
            }
            set
            {
                _extended_customs_procedureFilter = value;
				NotifyPropertyChanged(x => Extended_customs_procedureFilter);
                FilterData();
                
            }
        }	

 

		private string _national_customs_procedureFilter;
        public string National_customs_procedureFilter
        {
            get
            {
                return _national_customs_procedureFilter;
            }
            set
            {
                _national_customs_procedureFilter = value;
				NotifyPropertyChanged(x => National_customs_procedureFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _isDefaultFilter;
        public Boolean? IsDefaultFilter
        {
            get
            {
                return _isDefaultFilter;
            }
            set
            {
                _isDefaultFilter = value;
				NotifyPropertyChanged(x => IsDefaultFilter);
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

			Customs_Procedure.Refresh();
			NotifyPropertyChanged(x => this.Customs_Procedure);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(Extended_customs_procedureFilter) == false)
						res.Append(" && " + string.Format("Extended_customs_procedure.Contains(\"{0}\")",  Extended_customs_procedureFilter));						
 

									if(string.IsNullOrEmpty(National_customs_procedureFilter) == false)
						res.Append(" && " + string.Format("National_customs_procedure.Contains(\"{0}\")",  National_customs_procedureFilter));						
 

									if(IsDefaultFilter.HasValue)
						res.Append(" && " + string.Format("IsDefault == {0}",  IsDefaultFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<Customs_Procedure> lst = null;
            using (var ctx = new Customs_ProcedureRepository())
            {
                lst = await ctx.GetCustoms_ProcedureByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToCSV<Customs_ProcedureExcelLine, List<Customs_ProcedureExcelLine>>
            {
                dataToPrint = lst.Select(x => new Customs_ProcedureExcelLine
                {
 
                    Extended_customs_procedure = x.Extended_customs_procedure ,
                    
 
                    National_customs_procedure = x.National_customs_procedure ,
                    
 
                    IsDefault = x.IsDefault 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class Customs_ProcedureExcelLine
        {
		 
                    public string Extended_customs_procedure { get; set; } 
                    
 
                    public string National_customs_procedure { get; set; } 
                    
 
                    public Nullable<bool> IsDefault { get; set; } 
                    
        }

		
    }
}
		
