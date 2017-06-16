namespace NgApplication.Models.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NgData : DbContext
    {
        public NgData()
            : base("name=NgData")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.target_budget)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.Customer1)
                .WithRequired(e => e.Customer2);
        }
    }
}
