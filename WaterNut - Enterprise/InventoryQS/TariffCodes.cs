//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryQS
{
    using System;
    using System.Collections.Generic;
    
    public partial class TariffCodes
    {
        public TariffCodes()
        {
            this.InventoryItemsEx = new HashSet<InventoryItemsEx>();
        }
    
        public string TariffCode { get; set; }
        public string Description { get; set; }
        public string RateofDuty { get; set; }
        public string EnvironmentalLevy { get; set; }
        public string CustomsServiceCharge { get; set; }
        public string ExciseTax { get; set; }
        public string VatRate { get; set; }
        public string PetrolTax { get; set; }
        public string Units { get; set; }
        public string SiteRev3 { get; set; }
        public string TariffCategoryCode { get; set; }
        public Nullable<bool> LicenseRequired { get; set; }
        public Nullable<bool> Invalid { get; set; }
    
        public virtual TariffCategory TariffCategory { get; set; }
        public virtual ICollection<InventoryItemsEx> InventoryItemsEx { get; set; }
    }
}
