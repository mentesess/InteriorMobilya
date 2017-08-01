using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorMobilya.Model.Entities
{
    public class Order : IEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public decimal TotalPrice { get; set; }

        public int AddressID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
