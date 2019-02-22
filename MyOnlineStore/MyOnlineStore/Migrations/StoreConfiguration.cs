namespace MyOnlineStore.Migrations.StoreConfiguration
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<MyOnlineStore.DAL.StoreContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyOnlineStore.DAL.StoreContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Acoustic Guitar"},
                new Category { Name = "Electric Guitar"},
                new Category { Name = "Drum Sets"},
                new Category { Name ="Pianos"}
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product { Name ="Yamaha FG800",Description = "Beginner level",Price=249.99M,CategoryID=categories.Single(c=>c.Name =="Acoustic Guitar").ID},
                new Product {Name = "Ibanez AW54OPN Artwood Dreadnought", Description = "Beginner level", Price = 239, CategoryID= categories.Single(c=>c.Name == "Acoustic Guitar").ID},
                new Product {Name = "Epiphone DR100", Description = "Beginner level", Price = 225.99M, CategoryID= categories.Single(c=>c.Name == "Acoustic Guitar").ID},
                new Product {Name = "Seagull Artist Mosaic", Description = "Advanced level", Price = 669.99M, CategoryID= categories.Single(c=>c.Name == "Acoustic Guitar").ID},
                new Product {Name = "D Angelico EX63 Archtop", Description = "Advanced level", Price = 999.99M, CategoryID= categories.Single(c=>c.Name == "Acoustic Guitar").ID},
                new Product {Name = "Yamaha 6 String Series A3M Cutaway", Description = "Advanced level", Price = 759.99M, CategoryID= categories.Single(c=>c.Name == "Acoustic Guitar").ID},
                new Product {Name = "Ernie Ball Music Man John Petrucci Majesty Monarchy Black Knight", Description = "Advanced level", Price = 2999.99M, CategoryID= categories.Single(c=>c.Name == "Electric Guitar").ID},
                new Product {Name = "Ibanez JEM77WDP Steve Vai Signature JEM Premium Series 6 String", Description = "Advanced level", Price = 1799.99M, CategoryID= categories.Single(c=>c.Name == "Electric Guitar").ID},
                new Product {Name = "Hagstrom Tremar Viking Deluxe Semi Hollow Body ", Description = "Advanced level", Price = 849.99M, CategoryID= categories.Single(c=>c.Name == "Electric Guitar").ID},
                new Product {Name = "Yamaha RevStar RS420 ", Description = "Advanced level", Price = 599.99M, CategoryID= categories.Single(c=>c.Name == "Electric Guitar").ID},
                new Product {Name = "ENS EBCH1 Epiphone Les Paul STANDARD", Description = "Advanced level", Price = 2999.99M, CategoryID= categories.Single(c=>c.Name == "Electric Guitar").ID},
                new Product {Name = "Yamaha YPG235 76 Key Portable Grand Piano", Description = "Beginner level", Price = 269.99M, CategoryID= categories.Single(c=>c.Name == "Pianos").ID},
             };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var orders = new List<Order>
            {
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",County="Country", Postcode="PostCode" }, TotalPrice=249.99M,UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 1) ,DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",County="Country", Postcode="PostCode" }, TotalPrice=239,UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 2) ,DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",County="Country", Postcode="PostCode" }, TotalPrice=999.99M,UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 3) ,DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",County="County", Postcode="PostCode" }, TotalPrice=2999.99M,UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 4) ,DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1",County="Country", Postcode="PostCode" }, TotalPrice=269.99M,UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 5) ,DeliveryName="Admin" }
            };
            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();

            var orderLines = new List<OrderLine>
            {
                new OrderLine { OrderID = 1, ProductID = products.Single( c=> c.Name == "Yamaha FG800").ID,ProductName ="Yamaha FG800", Quantity =1, UnitPrice=products.Single( c=> c.Name == "Yamaha FG800").Price },

                new OrderLine { OrderID = 2, ProductID = products.Single( c=> c.Name == "Ibanez AW54OPN Artwood Dreadnought").ID,ProductName="Ibanez AW54OPN Artwood Dreadnought", Quantity=1, UnitPrice=products.Single( c=> c.Name =="Ibanez AW54OPN Artwood Dreadnought").Price },

                new OrderLine { OrderID = 3, ProductID = products.Single( c=> c.Name == "D Angelico EX63 Archtop").ID,ProductName ="D Angelico EX63 Archtop", Quantity=1, UnitPrice=products.Single( c=> c.Name == "D Angelico EX63 Archtop").Price },

                new OrderLine { OrderID = 4, ProductID = products.Single( c=> c.Name == "Ernie Ball Music Man John Petrucci Majesty Monarchy Black Knight").ID,ProductName ="Ernie Ball Music Man John Petrucci Majesty Monarchy Black Knight", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Ernie Ball Music Man John Petrucci Majesty Monarchy Black Knight").Price },

                new OrderLine { OrderID = 5, ProductID = products.Single( c=> c.Name == "Yamaha YPG235 76 Key Portable Grand Piano").ID,ProductName ="Yamaha YPG235 76 Key Portable Grand Piano", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Yamaha YPG235 76 Key Portable Grand Piano").Price }
            };
            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => ol.OrderID, c));
            context.SaveChanges();


        }
    }
}
