using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace loyaltyentity.Models
{
    public partial class CustomerContextCF : DbContext
    {
        public CustomerContextCF() : base("CustomerContextCF")
        {
        }
        public DbSet<CustomerCF> CustomerCF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
