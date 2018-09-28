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

namespace DocumentDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class xcuda_Valuation : BaseEntity<xcuda_Valuation>, ITrackable 
    {
        [DataMember]
        public string Calculation_working_mode 
        {
            get
            {
                return _calculation_working_mode;
            }
            set
            {
                _calculation_working_mode = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _calculation_working_mode;
        [DataMember]
        public double Total_cost 
        {
            get
            {
                return _total_cost;
            }
            set
            {
                _total_cost = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _total_cost;
        [DataMember]
        public double Total_CIF 
        {
            get
            {
                return _total_cif;
            }
            set
            {
                _total_cif = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _total_cif;
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
        public xcuda_ASYCUDA xcuda_ASYCUDA { get; set; }
        [DataMember]
        public xcuda_Gs_deduction xcuda_Gs_deduction { get; set; }
        [DataMember]
        public xcuda_Gs_insurance xcuda_Gs_insurance { get; set; }
        [DataMember]
        public xcuda_Gs_internal_freight xcuda_Gs_internal_freight { get; set; }
        [DataMember]
        public xcuda_Gs_other_cost xcuda_Gs_other_cost { get; set; }
        [DataMember]
        public xcuda_Total xcuda_Total { get; set; }
        [DataMember]
        public xcuda_Weight xcuda_Weight { get; set; }
        [DataMember]
        public xcuda_Gs_Invoice xcuda_Gs_Invoice { get; set; }
        [DataMember]
        public xcuda_Gs_external_freight xcuda_Gs_external_freight { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


