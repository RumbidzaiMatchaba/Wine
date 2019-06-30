 namespace Wine.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WineDataModel : DbContext
    {
        public WineDataModel()
            : base("name=WineDataModel1")
        {
        }

        public virtual DbSet<Wine> Wines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wine>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
