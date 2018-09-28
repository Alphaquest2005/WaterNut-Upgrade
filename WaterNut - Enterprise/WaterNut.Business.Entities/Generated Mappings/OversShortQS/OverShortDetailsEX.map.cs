namespace OversShortQS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class OverShortDetailsEXMap : EntityTypeConfiguration<OverShortDetailsEX>
    {
        public OverShortDetailsEXMap()
        {                        
              this.HasKey(t => t.OverShortDetailId);        
              this.ToTable("OverShortDetailsEX");
              this.Property(t => t.OverShortDetailId).HasColumnName("OverShortDetailId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.Identity));
              this.Property(t => t.ReceivedValue).HasColumnName("ReceivedValue");
              this.Property(t => t.InvoiceValue).HasColumnName("InvoiceValue");
              this.HasRequired(t => t.OversShortEX).WithMany(t =>(ICollection<OverShortDetailsEX>) t.OverShortDetailsEXes).HasForeignKey(d => d.OversShortsId);
              this.HasRequired(t => t.InventoryItem).WithMany(t =>(ICollection<OverShortDetailsEX>) t.OverShortDetailsEXes).HasForeignKey(d => d.ItemNumber);
              this.HasMany(t => t.OverShortAllocationsEXes).WithRequired(t => (OverShortDetailsEX)t.OverShortDetailsEX);
             // Nav Property Names
                  
    
    
              
    
         }
    }
}
