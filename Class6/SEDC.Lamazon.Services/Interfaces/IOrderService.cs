using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderViewModel> GetAllOrders();
    }
}
