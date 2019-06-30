namespace Wine.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserSecurityModel : DbContext
    {
        public UserSecurityModel()
            : base("name=UserSecurityModel")
        {
        }

        public virtual DbSet<loginUser> loginUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
