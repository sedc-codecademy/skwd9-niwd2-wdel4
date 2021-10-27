using Domain.Domain;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class StaticDb
    {
        public static int ProductId { get; set; } = 3;
        public static int OrderId { get; set; } = 2;

        public static List<Product> Products = new List<Product>
        {
            new Product()
            {
                Id = 1,
                Name = "Iphone13",
                Description = "Apple Iphone",
                CategoryType = CategoryType.Electronics,
                Price = 1000
            },
            new Product()
            {
                Id = 2,
                Name = "Samsung S12",
                Description = "Samsung Galaxy",
                CategoryType = CategoryType.Electronics,
                Price = 900
            },
            new Product()
            {
                Id = 3,
                Name = "Skopsko",
                Description = "Beer",
                CategoryType = CategoryType.Drinks,
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
                ProductOrders = new List<ProductOrder>
                {
                    new ProductOrder
                    {
                        Id = 1,
                        Product = Products[0],
                        ProductId = Products[0].Id,
                        OrderId = 1
                    },
                    new ProductOrder
                    {
                        Id = 2,
                        Product = Products[1],
                        ProductId = Products[1].Id,
                        OrderId = 1
                    }
                },
                Status = "pending",
                Paid = false
            },
            new Order
            {
                Id = 2,
                User = Users[1],
                ProductOrders = new List<ProductOrder>
                {
                    new ProductOrder
                    {
                        Id = 3,
                        Product = Products[2],
                        ProductId = Products[2].Id
                    }
                },
                Status = "pending",
                Paid = true
            }
        };
    }
}
