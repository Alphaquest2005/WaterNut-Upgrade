﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Business.Entities;
using Core.Common.Data.Contracts;
using System;

namespace DocumentDS.Business.Entities
{
    public partial class xcuda_Office_segment: IIdentifiableEntity
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.ASYCUDA_Id.ToString();  // this.ASYCUDA_Id == null?"0":
            }
            set
            {
                this.ASYCUDA_Id = Convert.ToInt32(value);
            }
        }



         #endregion
    }
   
}
		