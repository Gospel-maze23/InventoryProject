namespace InventoryProjectCsharp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Inventory : DbContext
    {
        public Inventory()
            : base("name=Inventory")
        {
        }

        public virtual DbSet<ProductTbl> ProductTbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTbl>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
