using InteriorMobilya.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorMobilya.Model.Mapping
{
    public class ProductMapping:EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            Property(x => x.ProductName).IsRequired().HasMaxLength(120);
            Property(x => x.Brand).IsOptional().HasMaxLength(120);
            Property(x => x.UnitPrice).IsRequired().HasColumnType("money");

            HasRequired<Category>(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(fk => fk.CategoryID);
        }
    }
}
