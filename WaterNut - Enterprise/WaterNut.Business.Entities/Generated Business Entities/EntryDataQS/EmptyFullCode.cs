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

namespace EntryDataQS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class EmptyFullCode : BaseEntity<EmptyFullCode>, ITrackable 
    {
        [DataMember]
        public string EmptyFullCodeName 
        {
            get
            {
                return _emptyfullcodename;
            }
            set
            {
                _emptyfullcodename = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _emptyfullcodename;
        [DataMember]
        public string EmptyFullDescription 
        {
            get
            {
                return _emptyfulldescription;
            }
            set
            {
                _emptyfulldescription = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _emptyfulldescription;
        [DataMember]
        public int EmptyFullCodeId 
        {
            get
            {
                return _emptyfullcodeid;
            }
            set
            {
                _emptyfullcodeid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _emptyfullcodeid;

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


