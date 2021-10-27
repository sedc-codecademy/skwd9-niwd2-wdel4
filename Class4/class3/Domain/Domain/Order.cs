using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
        public bool Paid { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
