﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Business.Entities;
using Core.Common.Data.Contracts;
using System;

namespace CoreEntities.Business.Entities
{
    public partial class EntryPreviousItems: IIdentifiableEntity
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.EntryPreviousItemId.ToString();  // this.EntryPreviousItemId == null?"0":
            }
            set
            {
                this.EntryPreviousItemId = Convert.ToInt32(value);
            }
        }



         #endregion
    }
   
}
		