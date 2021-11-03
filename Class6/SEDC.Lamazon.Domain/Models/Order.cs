using SEDC.Lamazon.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.Lamazon.Domain.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public StatusType Status { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
