using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._01_001
{
    public class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //make sure the database knows how to handlw the duplicate address property
            modelBuilder.Entity<Customer>().HasRequired(b => b.BillingAddress).WithMany().WillCascadeOnDelete(false);
        }

        

    }
}
