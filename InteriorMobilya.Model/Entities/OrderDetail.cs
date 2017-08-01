namespace InteriorMobilya.Model.Entities
{
    public class OrderDetail
    {
        //FK->Pk
        public int OrderID { get; set; }
        //FK->Pk
        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public ushort Quantity { get; set; }

        public double Discount { get; set; }

        //NP
        public virtual Order Order{ get; set; }

        public virtual Product Product { get; set; }
    }
}