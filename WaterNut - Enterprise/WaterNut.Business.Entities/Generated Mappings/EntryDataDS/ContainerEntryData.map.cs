﻿namespace EntryDataDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class ContainerEntryDataMap : EntityTypeConfiguration<ContainerEntryData>
    {
        public ContainerEntryDataMap()
        {                        
              this.HasKey(t => t.ContainerEntryData1);        
              this.ToTable("ContainerEntryData");
              this.Property(t => t.Container_Id).HasColumnName("Container_Id");
              this.Property(t => t.EntryDataId).HasColumnName("EntryDataId").IsRequired().IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.ContainerEntryData1).HasColumnName("ContainerEntryData").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.HasRequired(t => t.Container).WithMany(t =>(ICollection<ContainerEntryData>) t.ContainerEntryData).HasForeignKey(d => d.Container_Id);
              this.HasRequired(t => t.EntryData).WithMany(t =>(ICollection<ContainerEntryData>) t.ContainerEntryData).HasForeignKey(d => d.EntryDataId);
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
