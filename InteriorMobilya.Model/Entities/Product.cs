using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteriorMobilya.Model.Entities
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Brand { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsActive { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
