using InteriorMobilya.Model.Entities;
using InteriorMobilya.Model.Entities.Identity;
using InteriorMobilya.Model.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace InteriorMobilya.DataAccess.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("MySqlConnection")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        #region internal tables
        internal DbSet<Customer> Customers { get; set; }
        internal DbSet<Address> Addresses { get; set; }
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<Order> Orders { get; set; }
        internal DbSet<OrderDetail> OrderDetails { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<ShoppingCart> ShoppingCarts { get; set; }
        internal DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        #endregion


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new OrderDetailMapping());
        }
    }
}
