using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelsVM
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public List<string> ProductNames { get; set; }
        public double Price { get; set; }
    }
}
