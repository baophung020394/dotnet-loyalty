using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using loyaltyentity.Models;
namespace loyaltyentity.DBA
{
    public class CustomerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CustomerContext>
    {
        protected override void Seed(CustomerContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{Title="Title",Firstname="Firstname",Surname="Surname",Address1="address 1", Age=10, Created_at=DateTime.Parse("2005-09-01"), Updated_at=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
           
        }
    }
}