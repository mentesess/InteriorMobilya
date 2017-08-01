using System.Collections.Generic;

namespace InteriorMobilya.Model.Entities
{
    public class ShoppingCart : IEntity
    {
        public ShoppingCart()
        {
            ShoppingCartItems = new HashSet<ShoppingCartItem>();
        }
        //PK
        public int ShoppingCartID { get; set; }
        //FK
        public string CustomerID { get; set; }

        public decimal TotalPrice { get; set; }

        //NP
        public virtual Customer Customer { get; set; }

        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
