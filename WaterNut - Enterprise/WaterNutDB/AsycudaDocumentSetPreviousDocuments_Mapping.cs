//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterNutDB
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class AsycudaDocumentSetPreviousDocuments_Mapping : EntityTypeConfiguration<AsycudaDocumentSetPreviousDocuments>
    {
        public AsycudaDocumentSetPreviousDocuments_Mapping()
        {                        
              this.HasKey(t => new {t.AsycudaDocumentSetId, t.ASYCUDA_Id});        
              this.ToTable("AsycudaDocumentSetPreviousDocuments", "WaterNutDBDataLayerStoreContainer");
              this.Property(t => t.AsycudaDocumentSetId).HasColumnName("AsycudaDocumentSetId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.ASYCUDA_Id).HasColumnName("ASYCUDA_Id").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.HasRequired(t => t.xcuda_ASYCUDA).WithMany(t => t.AsycudaDocumentSetPreviousDocuments).HasForeignKey(d => d.ASYCUDA_Id);
         }
    }
}
