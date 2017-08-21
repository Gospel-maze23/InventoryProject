namespace InventoryProjectCsharp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductTbl")]
    public partial class ProductTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? ProductStock { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }
    }
}
