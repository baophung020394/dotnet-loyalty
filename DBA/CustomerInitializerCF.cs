using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using loyaltyentity.Models;

namespace loyaltyentity.Models
{
    public class CustomerInitializerCF : System.Data.Entity.DropCreateDatabaseIfModelChanges<CustomerContextCF>
    {
        protected override void Seed(CustomerContextCF context)
        {
            var customers = new List<CustomerCF>
            {
            new CustomerCF{title="Title",firstname="Firstname",surname="Surname",address1="address 1", address2="address 2", address3="address 3",address4="address 4", postcode="postcode", telephone="telephone", age=10, Created_at=DateTime.Parse("2005-09-01"), Updated_at=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(s => context.CustomerCF.Add(s));
            context.SaveChanges();

        }
    }
}