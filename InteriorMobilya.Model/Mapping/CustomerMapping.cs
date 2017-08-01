using InteriorMobilya.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorMobilya.Model.Mapping
{
    public class CustomerMapping:EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            HasKey(x => x.CustomerID);
            Property(x => x.CustomerName).HasMaxLength(60).IsRequired();
            Property(x => x.CustomerSurname).HasMaxLength(60).IsRequired();
            Property(x => x.Email).IsRequired();

            HasMany<Address>(cus => cus.Addresses)
                .WithRequired(adr => adr.Customer)
                .HasForeignKey(fk => fk.CustomerID);
        }
    }
}
