
namespace InteriorMobilya.Model.Entities
{
    public class Address:IEntity
    {
        //PK
        public int AddressID { get; set; }
        //FK
        public string CustomerID { get; set; }

        public string AddressTitle { get; set; }

        public string AddressDescription { get; set; }

        public string Provience { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        //NP
        public virtual Customer Customer { get; set; }

    }
}