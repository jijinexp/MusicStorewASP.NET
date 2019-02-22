using MyOnlineStore.Models;
using System.Data.Entity;

namespace MyOnlineStore.DAL
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductImageMapping> ProductImageMappings { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public System.Data.Entity.DbSet<MyOnlineStore.ViewModels.RoleViewModel> RoleViewModels { get; set; }
    }
}