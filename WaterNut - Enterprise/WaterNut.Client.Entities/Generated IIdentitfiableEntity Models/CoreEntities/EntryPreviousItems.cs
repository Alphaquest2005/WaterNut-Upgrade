﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Client.Entities;
using CoreEntities.Client.Services;
//using WaterNut.Client.Services;
using CoreEntities.Client.Services;

using System;

namespace CoreEntities.Client.Entities
{
    public partial class EntryPreviousItems
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.EntryPreviousItemId.ToString();//this.EntryPreviousItemId == null?"0":			
            }
            set
            {
                this.EntryPreviousItemId = Convert.ToInt32(value);
            }
        }
        public string AsycudaDocumentItemEntityName
        {
            get
            {
                return this.AsycudaDocumentItem == null ? "" : this.AsycudaDocumentItem.EntityName;
            }
            set
            {
                                if (string.IsNullOrEmpty(value)) return;
                string[] vals = value.Split(',');
               
                    using (AsycudaDocumentItemClient ctx = new AsycudaDocumentItemClient())
                    {
                        var dto = ctx.GetAsycudaDocumentItems().Result.AsEnumerable().FirstOrDefault(x => x.EntityName == value);
                        

                        if ( dto == null)
                        {
                            this.AsycudaDocumentItem = (AsycudaDocumentItem)new AsycudaDocumentItem().CreateEntityFromString(value);
							
							this.EntryPreviousItemId = Convert.ToInt32(this.AsycudaDocumentItem.Item_Id);
                            this.TrackingState=TrackableEntities.TrackingState.Modified;
                           NotifyPropertyChanged("AddAsycudaDocumentItem");
                        }
                        else
                        {
                            var obj = new AsycudaDocumentItem(dto);
                           if (this.AsycudaDocumentItem == null || this.AsycudaDocumentItem.EntityId != obj.EntityId) this.AsycudaDocumentItem = obj;
                           
                        }
                         


                    }
            
            }

      }



         #endregion
    }
   
}
		