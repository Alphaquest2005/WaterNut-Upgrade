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

namespace AllocationDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class TariffCategory : BaseEntity<TariffCategory>, ITrackable 
    {
        partial void AutoGenStartUp() //TariffCategory()
        {
            this.TariffCodes = new List<TariffCodes>();
            this.TariffCategoryCodeSuppUnit = new List<TariffCategoryCodeSuppUnit>();
        }

        [DataMember]
        public string TariffCategoryCode 
        {
            get
            {
                return _tariffcategorycode;
            }
            set
            {
                _tariffcategorycode = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _tariffcategorycode;
        [DataMember]
        public string Description 
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _description;
        [DataMember]
        public string ParentTariffCategoryCode 
        {
            get
            {
                return _parenttariffcategorycode;
            }
            set
            {
                _parenttariffcategorycode = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _parenttariffcategorycode;
        [DataMember]
        public Nullable<bool> LicenseRequired 
        {
            get
            {
                return _licenserequired;
            }
            set
            {
                _licenserequired = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _licenserequired;
        [DataMember]
        public List<TariffCodes> TariffCodes { get; set; }
        [DataMember]
        public List<TariffCategoryCodeSuppUnit> TariffCategoryCodeSuppUnit { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


