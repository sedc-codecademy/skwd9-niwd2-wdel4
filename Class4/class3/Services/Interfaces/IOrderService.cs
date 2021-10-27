using System;
using System.Collections.Generic;
using System.Text;
using ViewModelsVM;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderViewModel> GetAllOrders();
        OrderViewModel GetOrderById(int id);
    }
}
