﻿// <autogenerated>
//   This file was generated by T4 code generator AllObjectContext.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

            


using System.Data.Entity;
using CoreEntities.Business.Entities;
using System.Data.Entity.Infrastructure;
using DocumentItemDS.Business.Entities.Mapping;
using WaterNut.Data;
using System.Data.Entity.Core.Objects;



namespace DocumentItemDS.Business.Entities
{
    [DbConfigurationType(typeof(DBConfiguration))] 
    public partial class DocumentItemDSContext : DbContext
    {
        static DocumentItemDSContext()
        {
            var x = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            Database.SetInitializer<DocumentItemDSContext>(null);
        }

        public DocumentItemDSContext()
            : base("Name=DocumentItemDS")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
               // Get the ObjectContext related to this DbContext
            var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 120;

            objectContext.ObjectMaterialized += ObjectContext_OnObjectMaterialized;
        }
        
        public bool StartTracking { get; set; }

        private void ObjectContext_OnObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            if (StartTracking == true) ((dynamic)e.Entity).StartTracking();
        }

        public DbSet<xcuda_Item> xcuda_Item { get; set; }
     
        public DbSet<xcuda_item_deduction> xcuda_item_deduction { get; set; }
     
        public DbSet<xcuda_item_external_freight> xcuda_item_external_freight { get; set; }
     
        public DbSet<xcuda_item_insurance> xcuda_item_insurance { get; set; }
     
        public DbSet<xcuda_item_internal_freight> xcuda_item_internal_freight { get; set; }
     
        public DbSet<xcuda_Item_Invoice> xcuda_Item_Invoice { get; set; }
     
        public DbSet<xcuda_item_other_cost> xcuda_item_other_cost { get; set; }
     
        public DbSet<SubItems> SubItems { get; set; }
     
        public DbSet<xBondAllocations> xBondAllocations { get; set; }
     
        public DbSet<xcuda_Attached_documents> xcuda_Attached_documents { get; set; }
     
        public DbSet<xcuda_Goods_description> xcuda_Goods_description { get; set; }
     
        public DbSet<xcuda_HScode> xcuda_HScode { get; set; }
     
        public DbSet<xcuda_Inventory_Item> xcuda_Inventory_Item { get; set; }
     
        public DbSet<xcuda_Packages> xcuda_Packages { get; set; }
     
        public DbSet<xcuda_Previous_doc> xcuda_Previous_doc { get; set; }
     
        public DbSet<xcuda_PreviousItem> xcuda_PreviousItem { get; set; }
     
        public DbSet<xcuda_Supplementary_unit> xcuda_Supplementary_unit { get; set; }
     
        public DbSet<xcuda_Tarification> xcuda_Tarification { get; set; }
     
        public DbSet<xcuda_Taxation> xcuda_Taxation { get; set; }
     
        public DbSet<xcuda_Taxation_line> xcuda_Taxation_line { get; set; }
     
        public DbSet<xcuda_Valuation_item> xcuda_Valuation_item { get; set; }
     
        public DbSet<xcuda_Weight_itm> xcuda_Weight_itm { get; set; }
     
        public DbSet<xcuda_ItemEntryDataDetails> xcuda_ItemEntryDataDetails { get; set; }
     
        public DbSet<xcuda_Suppliers_link> xcuda_Suppliers_link { get; set; }
     
        public DbSet<PreviousItemsEx> PreviousItemsEx { get; set; }
     
        public DbSet<EntryPreviousItems> EntryPreviousItems { get; set; }
     


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new xcuda_ItemMap());
         
            modelBuilder.Configurations.Add(new xcuda_item_deductionMap());
         
            modelBuilder.Configurations.Add(new xcuda_item_external_freightMap());
         
            modelBuilder.Configurations.Add(new xcuda_item_insuranceMap());
         
            modelBuilder.Configurations.Add(new xcuda_item_internal_freightMap());
         
            modelBuilder.Configurations.Add(new xcuda_Item_InvoiceMap());
         
            modelBuilder.Configurations.Add(new xcuda_item_other_costMap());
         
            modelBuilder.Configurations.Add(new SubItemsMap());
         
            modelBuilder.Configurations.Add(new xBondAllocationsMap());
         
            modelBuilder.Configurations.Add(new xcuda_Attached_documentsMap());
         
            modelBuilder.Configurations.Add(new xcuda_Goods_descriptionMap());
         
            modelBuilder.Configurations.Add(new xcuda_HScodeMap());
         
            modelBuilder.Configurations.Add(new xcuda_Inventory_ItemMap());
         
            modelBuilder.Configurations.Add(new xcuda_PackagesMap());
         
            modelBuilder.Configurations.Add(new xcuda_Previous_docMap());
         
            modelBuilder.Configurations.Add(new xcuda_PreviousItemMap());
         
            modelBuilder.Configurations.Add(new xcuda_Supplementary_unitMap());
         
            modelBuilder.Configurations.Add(new xcuda_TarificationMap());
         
            modelBuilder.Configurations.Add(new xcuda_TaxationMap());
         
            modelBuilder.Configurations.Add(new xcuda_Taxation_lineMap());
         
            modelBuilder.Configurations.Add(new xcuda_Valuation_itemMap());
         
            modelBuilder.Configurations.Add(new xcuda_Weight_itmMap());
         
            modelBuilder.Configurations.Add(new xcuda_ItemEntryDataDetailsMap());
         
            modelBuilder.Configurations.Add(new xcuda_Suppliers_linkMap());
         
            modelBuilder.Configurations.Add(new PreviousItemsExMap());
         
            modelBuilder.Configurations.Add(new EntryPreviousItemsMap());
         
			OnModelCreatingExtentsion(modelBuilder);

        }
		partial void OnModelCreatingExtentsion(DbModelBuilder modelBuilder);
    }
}

 	
