﻿namespace DocumentDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class Document_TypeMap : EntityTypeConfiguration<Document_Type>
    {
        public Document_TypeMap()
        {                        
              this.HasKey(t => t.Document_TypeId);        
              this.ToTable("Document_Type");
              this.Property(t => t.Document_TypeId).HasColumnName("Document_TypeId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.Identity));
              this.Property(t => t.Type_of_declaration).HasColumnName("Type_of_declaration").IsUnicode(false);
              this.Property(t => t.Declaration_gen_procedure_code).HasColumnName("Declaration_gen_procedure_code").IsUnicode(false);
              this.HasMany(t => t.AsycudaDocumentSets).WithOptional(t => t.Document_Type).HasForeignKey(d => d.Document_TypeId);
              this.HasMany(t => t.Customs_Procedure).WithRequired(t => (Document_Type)t.Document_Type);
              this.HasMany(t => t.xcuda_ASYCUDA_ExtendedProperties).WithOptional(t => t.Document_Type).HasForeignKey(d => d.Document_TypeId);
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
