namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class adrapiliminary : DbContext
    {
        public adrapiliminary()
            : base("name=adrapiliminary")
        {
        }

        public virtual DbSet<accountBalance> accountBalances { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
