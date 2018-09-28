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
    public partial class xcuda_Export : BaseEntity<xcuda_Export>, ITrackable 
    {
        [DataMember]
        public string Export_country_code 
        {
            get
            {
                return _export_country_code;
            }
            set
            {
                _export_country_code = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _export_country_code;
        [DataMember]
        public string Export_country_name 
        {
            get
            {
                return _export_country_name;
            }
            set
            {
                _export_country_name = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _export_country_name;
        [DataMember]
        public int Country_Id 
        {
            get
            {
                return _country_id;
            }
            set
            {
                _country_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _country_id;
        [DataMember]
        public string Export_country_region 
        {
            get
            {
                return _export_country_region;
            }
            set
            {
                _export_country_region = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _export_country_region;
        [DataMember]
        public xcuda_Country xcuda_Country { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


