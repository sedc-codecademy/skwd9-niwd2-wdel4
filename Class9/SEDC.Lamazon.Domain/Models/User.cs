using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Domain.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
