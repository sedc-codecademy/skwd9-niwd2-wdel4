using SEDC.Lamazon.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryType Category { get; set; }
        public double Price { get; set; }
    }
}
