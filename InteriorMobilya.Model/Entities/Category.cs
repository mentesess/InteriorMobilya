using System.Collections.Generic;

namespace InteriorMobilya.Model.Entities
{
    public class Category:IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
        //NP
        public virtual ICollection<Product> Products { get; set; }
    }
}