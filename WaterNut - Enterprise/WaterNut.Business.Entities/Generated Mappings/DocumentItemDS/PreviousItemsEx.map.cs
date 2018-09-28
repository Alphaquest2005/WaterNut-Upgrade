﻿namespace DocumentItemDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class PreviousItemsExMap : EntityTypeConfiguration<PreviousItemsEx>
    {
        public PreviousItemsExMap()
        {                        
              this.HasKey(t => t.PreviousItem_Id);        
              this.ToTable("PreviousItemsEx");
              this.Property(t => t.Packages_number).HasColumnName("Packages_number").IsUnicode(false);
              this.Property(t => t.Previous_Packages_number).HasColumnName("Previous_Packages_number").IsUnicode(false);
              this.Property(t => t.Hs_code).HasColumnName("Hs_code").IsUnicode(false);
              this.Property(t => t.Commodity_code).HasColumnName("Commodity_code").IsUnicode(false);
              this.Property(t => t.Previous_item_number).HasColumnName("Previous_item_number").IsUnicode(false);
              this.Property(t => t.Goods_origin).HasColumnName("Goods_origin").IsUnicode(false);
              this.Property(t => t.Net_weight).HasColumnName("Net_weight");
              this.Property(t => t.Prev_net_weight).HasColumnName("Prev_net_weight");
              this.Property(t => t.Prev_reg_ser).HasColumnName("Prev_reg_ser").IsUnicode(false);
              this.Property(t => t.Prev_reg_nbr).HasColumnName("Prev_reg_nbr").IsUnicode(false);
              this.Property(t => t.Prev_reg_dat).HasColumnName("Prev_reg_dat").IsUnicode(false);
              this.Property(t => t.Prev_reg_cuo).HasColumnName("Prev_reg_cuo").IsUnicode(false);
              this.Property(t => t.Suplementary_Quantity).HasColumnName("Suplementary_Quantity");
              this.Property(t => t.Preveious_suplementary_quantity).HasColumnName("Preveious_suplementary_quantity");
              this.Property(t => t.Current_value).HasColumnName("Current_value");
              this.Property(t => t.Previous_value).HasColumnName("Previous_value");
              this.Property(t => t.Current_item_number).HasColumnName("Current_item_number").IsUnicode(false);
              this.Property(t => t.PreviousItem_Id).HasColumnName("PreviousItem_Id").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.ASYCUDA_Id).HasColumnName("ASYCUDA_Id");
              this.Property(t => t.QtyAllocated).HasColumnName("QtyAllocated");
              this.Property(t => t.RndCurrent_Value).HasColumnName("RndCurrent_Value");
              this.Property(t => t.CNumber).HasColumnName("CNumber").IsUnicode(false);
              this.Property(t => t.RegistrationDate).HasColumnName("RegistrationDate");
              this.Property(t => t.PreviousDocumentItemId).HasColumnName("PreviousDocumentItemId");
              this.Property(t => t.AsycudaDocumentItemId).HasColumnName("AsycudaDocumentItemId");
              this.HasRequired(t => t.xcuda_PreviousItem).WithOptional(t => (PreviousItemsEx)t.Ex);
             // Tracking Properties
    			this.Ignore(t => t.TrackingState);
    			this.Ignore(t => t.ModifiedProperties);
    
    
             // IIdentifibleEntity
                this.Ignore(t => t.EntityId);
                this.Ignore(t => t.EntityName); 
    
                this.Ignore(t => t.EntityKey);
             // Nav Property Names
                  
    
    
              
    
         }
    }
}
