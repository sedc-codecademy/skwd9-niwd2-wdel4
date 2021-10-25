using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public string Status { get; set; }
        public bool Paid { get; set; }
    }
}
