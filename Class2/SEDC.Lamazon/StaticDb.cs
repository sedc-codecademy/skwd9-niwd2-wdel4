using SEDC.Lamazon.Models.Domain;
using SEDC.Lamazon.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon
{
    public class StaticDb
    {
        public static List<Product> Products = new List<Product>
        {
            new Product()
            {
                Id = 1,
                Name = "Iphone13",
                Description = "Apple Iphone",
                Category = CategoryType.Electronics,
                Price = 1000
            },
            new Product()
            {
                Id = 2,
                Name = "Samsung S12",
                Description = "Samsung Galaxy",
                Category = CategoryType.Electronics,
                Price = 900
            },
            new Product()
            {
                Id = 3,
                Name = "Skopsko",
                Description = "Beer",
                Category = CategoryType.Drinks,
                Price = 50
            }

        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FullName = "Pane Manaskov",
                Username = "pane123",
                Email = "pane@mail.com",
                Password = "pass123"
            },
            new User
            {
                Id = 2,
                FullName = "Petre Arsovski",
                Username = "petre123",
                Email = "petree@mail.com",
                Password = "pass456"
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                User = Users[0],
                Product = Products[0],
                Status = "pending",
                Paid = false
            },
            new Order
            {
                Id = 2,
                User = Users[1],
                Product = Products[1],
                Status = "pending",
                Paid = true
            }
        };
    }
}
