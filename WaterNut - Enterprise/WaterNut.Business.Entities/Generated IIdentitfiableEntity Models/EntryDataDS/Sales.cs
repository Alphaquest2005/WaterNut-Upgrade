﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Business.Entities;
using Core.Common.Data.Contracts;
using System;

namespace EntryDataDS.Business.Entities
{
    public partial class Sales: IIdentifiableEntity
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.EntryDataId.ToString();  // this.EntryDataId == null?"0":
            }
            set
            {
                this.EntryDataId = Convert.ToString(value);
            }
        }



         #endregion
    }
   
}
		