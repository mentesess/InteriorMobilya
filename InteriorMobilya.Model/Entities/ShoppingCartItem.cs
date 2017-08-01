namespace InteriorMobilya.Model.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }

        public int ProductID { get; set; }

        public int ShoppingCartID { get; set; }

        public ushort Quantity { get; set; }

        public bool IsActive { get; set; }

        //NP
        public virtual Product Product { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}