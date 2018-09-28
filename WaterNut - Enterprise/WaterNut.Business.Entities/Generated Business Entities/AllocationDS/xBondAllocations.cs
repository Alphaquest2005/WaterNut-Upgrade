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
    public partial class xBondAllocations : BaseEntity<xBondAllocations>, ITrackable 
    {
        [DataMember]
        public int xEntryItem_Id 
        {
            get
            {
                return _xentryitem_id;
            }
            set
            {
                _xentryitem_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _xentryitem_id;
        [DataMember]
        public int AllocationId 
        {
            get
            {
                return _allocationid;
            }
            set
            {
                _allocationid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _allocationid;
        [DataMember]
        public int xBondAllocationId 
        {
            get
            {
                return _xbondallocationid;
            }
            set
            {
                _xbondallocationid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _xbondallocationid;
        [DataMember]
        public AsycudaSalesAllocations AsycudaSalesAllocations { get; set; }
        [DataMember]
        public xcuda_Item xcuda_Item { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


