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

namespace CounterPointQS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class CounterPointSales : BaseEntity<CounterPointSales>, ITrackable 
    {
        [DataMember]
        public string InvoiceNo 
        {
            get
            {
                return _invoiceno;
            }
            set
            {
                _invoiceno = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _invoiceno;
        [DataMember]
        public Nullable<System.DateTime> Date 
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<System.DateTime> _date;
        [DataMember]
        public decimal TAX_AMT 
        {
            get
            {
                return _tax_amt;
            }
            set
            {
                _tax_amt = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        decimal _tax_amt;
        [DataMember]
        public string CustomerName 
        {
            get
            {
                return _customername;
            }
            set
            {
                _customername = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _customername;
        [DataMember]
        public Nullable<int> LineNumber 
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
        Nullable<int> _linenumber;
        [DataMember]
        public Nullable<bool> Downloaded 
        {
            get
            {
                return _downloaded;
            }
            set
            {
                _downloaded = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _downloaded;

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


