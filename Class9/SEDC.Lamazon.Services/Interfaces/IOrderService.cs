﻿using SEDC.Lamazon.WebModels.Enums;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderViewModel> GetAllOrders();
        OrderViewModel GetOrderById(int id);
        int ChangeStatus(int orderId, string userId, StatusTypeViewModel status);
        OrderViewModel GetOrderById(int id, string userId);
        OrderViewModel GetCurrentOrder(string userId);
        int AddProduct(int orderId, int productId, string userId);
    }
}
