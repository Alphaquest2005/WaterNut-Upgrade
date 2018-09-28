﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;

using Core.Common.Business.Entities;
using WaterNut.Interfaces;
using TrackableEntities;

namespace DocumentItemDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class xcuda_Item : BaseEntity<xcuda_Item>, ITrackable 
    {
        partial void AutoGenStartUp() //xcuda_Item()
        {
            this.SubItems = new List<SubItems>();
            this.xBondAllocations = new List<xBondAllocations>();
            this.xcuda_Attached_documents = new List<xcuda_Attached_documents>();
            this.xcuda_Packages = new List<xcuda_Packages>();
            this.xcuda_Taxation = new List<xcuda_Taxation>();
            this.EntryDataDetails = new List<xcuda_ItemEntryDataDetails>();
            this.xcuda_Suppliers_link = new List<xcuda_Suppliers_link>();
            this.xcuda_PreviousItems = new List<EntryPreviousItems>();
        }

        [DataMember]
        public string Amount_deducted_from_licence 
        {
            get
            {
                return _amount_deducted_from_licence;
            }
            set
            {
                _amount_deducted_from_licence = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _amount_deducted_from_licence;
        [DataMember]
        public string Quantity_deducted_from_licence 
        {
            get
            {
                return _quantity_deducted_from_licence;
            }
            set
            {
                _quantity_deducted_from_licence = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _quantity_deducted_from_licence;
        [DataMember]
        public int Item_Id 
        {
            get
            {
                return _item_id;
            }
            set
            {
                _item_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _item_id;
        [DataMember]
        public int ASYCUDA_Id 
        {
            get
            {
                return _asycuda_id;
            }
            set
            {
                _asycuda_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _asycuda_id;
        [DataMember]
        public string Licence_number 
        {
            get
            {
                return _licence_number;
            }
            set
            {
                _licence_number = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _licence_number;
        [DataMember]
        public Nullable<int> EntryDataDetailsId 
        {
            get
            {
                return _entrydatadetailsid;
            }
            set
            {
                _entrydatadetailsid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<int> _entrydatadetailsid;
        [DataMember]
        public int LineNumber 
        {
            get
            {
                return _linenumber;
            }
            set
            {
                _linenumber = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _linenumber;
        [DataMember]
        public Nullable<bool> IsAssessed 
        {
            get
            {
                return _isassessed;
            }
            set
            {
                _isassessed = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _isassessed;
        [DataMember]
        public double DPQtyAllocated 
        {
            get
            {
                return _dpqtyallocated;
            }
            set
            {
                _dpqtyallocated = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _dpqtyallocated;
        [DataMember]
        public double DFQtyAllocated 
        {
            get
            {
                return _dfqtyallocated;
            }
            set
            {
                _dfqtyallocated = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _dfqtyallocated;
        [DataMember]
        public Nullable<System.DateTime> EntryTimeStamp 
        {
            get
            {
                return _entrytimestamp;
            }
            set
            {
                _entrytimestamp = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<System.DateTime> _entrytimestamp;
        [DataMember]
        public Nullable<bool> AttributeOnlyAllocation 
        {
            get
            {
                return _attributeonlyallocation;
            }
            set
            {
                _attributeonlyallocation = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _attributeonlyallocation;
        [DataMember]
        public Nullable<bool> DoNotAllocate 
        {
            get
            {
                return _donotallocate;
            }
            set
            {
                _donotallocate = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _donotallocate;
        [DataMember]
        public Nullable<bool> DoNotEX 
        {
            get
            {
                return _donotex;
            }
            set
            {
                _donotex = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _donotex;
        [DataMember]
        public string Free_text_1 
        {
            get
            {
                return _free_text_1;
            }
            set
            {
                _free_text_1 = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _free_text_1;
        [DataMember]
        public string Free_text_2 
        {
            get
            {
                return _free_text_2;
            }
            set
            {
                _free_text_2 = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _free_text_2;
        [DataMember]
        public bool ImportComplete 
        {
            get
            {
                return _importcomplete;
            }
            set
            {
                _importcomplete = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        bool _importcomplete;
        [DataMember]
        public string WarehouseError 
        {
            get
            {
                return _warehouseerror;
            }
            set
            {
                _warehouseerror = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _warehouseerror;
        [DataMember]
        public double SalesFactor 
        {
            get
            {
                return _salesfactor;
            }
            set
            {
                _salesfactor = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _salesfactor;
        [DataMember]
        public List<SubItems> SubItems { get; set; }
        [DataMember]
        public List<xBondAllocations> xBondAllocations { get; set; }
        [DataMember]
        public List<xcuda_Attached_documents> xcuda_Attached_documents { get; set; }
        [DataMember]
        public xcuda_Goods_description xcuda_Goods_description { get; set; }
        [DataMember]
        public List<xcuda_Packages> xcuda_Packages { get; set; }
        [DataMember]
        public xcuda_Previous_doc xcuda_Previous_doc { get; set; }
        [DataMember]
        public xcuda_Tarification xcuda_Tarification { get; set; }
        [DataMember]
        public List<xcuda_Taxation> xcuda_Taxation { get; set; }
        [DataMember]
        public xcuda_Valuation_item xcuda_Valuation_item { get; set; }
        [DataMember]
        public xcuda_PreviousItem xcuda_PreviousItem { get; set; }
        [DataMember]
        public List<xcuda_ItemEntryDataDetails> EntryDataDetails { get; set; }
        [DataMember]
        public List<xcuda_Suppliers_link> xcuda_Suppliers_link { get; set; }
        [DataMember]
        public List<EntryPreviousItems> xcuda_PreviousItems { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


