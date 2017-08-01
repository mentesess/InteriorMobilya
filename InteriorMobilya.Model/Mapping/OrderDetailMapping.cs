using InteriorMobilya.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorMobilya.Model.Mapping
{
    public class OrderDetailMapping:EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            HasKey(x => new { x.OrderID, x.ProductID });
            
        }
    }
}
