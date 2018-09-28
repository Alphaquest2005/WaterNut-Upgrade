namespace OversShortQS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class OversShortEXMap : EntityTypeConfiguration<OversShortEX>
    {
        public OversShortEXMap()
        {                        
              this.HasKey(t => t.OversShortsId);        
              this.ToTable("OversShortEX");
              this.Property(t => t.OversShortsId).HasColumnName("OversShortsId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.Identity));
              this.Property(t => t.ReceivedValue).HasColumnName("ReceivedValue");
              this.Property(t => t.InvoiceValue).HasColumnName("InvoiceValue");
              this.HasMany(t => t.OverShortDetailsEXes).WithRequired(t => (OversShortEX)t.OversShortEX);
              this.HasOptional(t => t.OverShortSuggestedDocuments).WithRequired(t => (OversShortEX) t.OversShortEX);
             // Nav Property Names
                  
    
    
              
    
         }
    }
}
