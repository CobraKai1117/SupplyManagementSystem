using System;
using SupplyManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyManagementSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InventoryManagementContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product{ProductID = 12115, ProductName = "Tractor Axle", SupplierID = 117, Stock = 5, OrderStatus = "Medium Priority"},
                new Product {ProductID = 12119, ProductName = "Tractor Transmission", SupplierID = 117, Stock = 17, OrderStatus = "Low Priority" },
                new Product{ProductID = 12129, ProductName = "IC Engine", SupplierID = 225, Stock = 2, OrderStatus = "High Priority / Reorder"},
                new Product{ProductID =13994, ProductName = "Screw Packs D Series", SupplierID = 601, Stock = 55, OrderStatus = "Low Priority" },
                new Product{ProductID = 15040, ProductName = "Cooling Fan", SupplierID = 449, Stock = 6, OrderStatus = "Medium Priority" },
                new Product{ProductID = 16667, ProductName= "Clutch", SupplierID = 225, Stock = 22, OrderStatus = "Medium Priority" },
                new Product{ProductID = 15735, ProductName = "Chisel Plow", SupplierID = 779, Stock = 17, OrderStatus = "Low Priority"},
                new Product{ProductID = 11579, ProductName = "Rotator", SupplierID = 779, Stock = 5, OrderStatus = "Medium Priority"},
                new Product{ProductID = 15879, ProductName = "Roller" , SupplierID = 886, Stock = 14, OrderStatus = "Low Priority" },
                new Product{ProductID = 12774, ProductName = "Subsoiler", SupplierID = 448, Stock = 7, OrderStatus = "Medium Priority" }
            };

            foreach (Product item in products)
            {
               context.Products.Add(item);
               
            }

           context.SaveChanges();

            var suppliers = new Supplier[]
            {
                new Supplier{SupplierID = 117, SupplierName = "Blue Tech", ContactName = "Steven Urkel", SupplierPhone = "579-449-9979" },
                new Supplier{SupplierID = 225, SupplierName = "Lund Manufacturing", ContactName = "Dick Grayson", SupplierPhone = "675-995-4541" },
                new Supplier{SupplierID = 601, SupplierName = "Whiteham LLC", ContactName = "Jordan Belfort", SupplierPhone = "775-195-2725" } ,
                new Supplier{SupplierID = 449, SupplierName = "Dawn Industries",ContactName= "Russel Adler", SupplierPhone = "703-482-0623"},
                new Supplier{SupplierID = 779, SupplierName = "Groebbing Hanlin", ContactName = "Peter Griffin",SupplierPhone = "555-498-2521" },
                new Supplier{SupplierID = 886, SupplierName = "M1 Manufacturing", ContactName = "Jack Bauer",SupplierPhone = "565-452-9593"},
                new Supplier{SupplierID = 448, SupplierName = "HapyTrie Industries",ContactName = "Bob Ross", SupplierPhone = "515-993-9595" }
            };

            foreach(Supplier Contact in suppliers)
            {
                context.Suppliers.Add(Contact);
            }

            context.SaveChanges(); 

        }
    }
}
