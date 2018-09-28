﻿namespace EntryDataDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class InventoryItemsExMap : EntityTypeConfiguration<InventoryItemsEx>
    {
        public InventoryItemsExMap()
        {                        
              this.HasKey(t => t.ItemNumber);        
              this.ToTable("InventoryItemsEx");
              this.Property(t => t.ItemNumber).HasColumnName("ItemNumber").IsRequired().IsUnicode(false).HasMaxLength(255);
              this.Property(t => t.Description).HasColumnName("Description").IsRequired().IsUnicode(false);
              this.Property(t => t.Category).HasColumnName("Category").HasMaxLength(60);
              this.Property(t => t.TariffCode).HasColumnName("TariffCode").IsUnicode(false).HasMaxLength(8);
              this.Property(t => t.SuppUnitCode2).HasColumnName("SuppUnitCode2").HasMaxLength(50);
              this.Property(t => t.SuppQty).HasColumnName("SuppQty");
              this.HasMany(t => t.EntryDataDetails).WithRequired(t => (InventoryItemsEx)t.InventoryItems);
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
