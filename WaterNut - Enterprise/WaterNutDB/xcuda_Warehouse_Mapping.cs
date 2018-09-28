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
    
    internal partial class xcuda_Warehouse_Mapping : EntityTypeConfiguration<xcuda_Warehouse>
    {
        public xcuda_Warehouse_Mapping()
        {                        
              this.HasKey(t => t.Warehouse_Id);        
              this.ToTable("xcuda_Warehouse");
              this.Property(t => t.Identification).HasColumnName("Identification").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Delay).HasColumnName("Delay").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.ASYCUDA_Id).HasColumnName("ASYCUDA_Id");
              this.Property(t => t.Warehouse_Id).HasColumnName("Warehouse_Id");
              this.HasOptional(t => t.xcuda_ASYCUDA).WithMany(t => t.xcuda_Warehouse).HasForeignKey(d => d.ASYCUDA_Id);
         }
    }
}
