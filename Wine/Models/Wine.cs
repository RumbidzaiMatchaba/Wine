namespace Wine.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wine")]
    public partial class Wine
    {
        [Key]
        public int WineCategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Producer { get; set; }

        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
