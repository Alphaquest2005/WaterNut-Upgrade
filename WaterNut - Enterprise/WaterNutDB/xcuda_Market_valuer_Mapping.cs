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
    
    internal partial class xcuda_Market_valuer_Mapping : EntityTypeConfiguration<xcuda_Market_valuer>
    {
        public xcuda_Market_valuer_Mapping()
        {                        
              this.HasKey(t => t.Valuation_item_Id);        
              this.ToTable("xcuda_Market_valuer");
              this.Property(t => t.Rate).HasColumnName("Rate").IsUnicode(false);
              this.Property(t => t.Currency_amount).HasColumnName("Currency_amount");
              this.Property(t => t.Basis_amount).HasColumnName("Basis_amount").IsUnicode(false);
              this.Property(t => t.Valuation_item_Id).HasColumnName("Valuation_item_Id").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.HasRequired(t => t.xcuda_Valuation_item).WithOptional(t => t.xcuda_Market_valuer);
         }
    }
}
