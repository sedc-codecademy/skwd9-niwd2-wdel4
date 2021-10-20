using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool Paid { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string UserFullName { get; set; }
    }
}
