using DataAccess;
using Domain.Domain;
using Mappers.Order;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModelsVM;

namespace Services.Implementation
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<OrderViewModel> GetAllOrders()
        {
            List<Order> orders = _orderRepository.GetAll();
            List<OrderViewModel> orderViewModel = new List<OrderViewModel>();
            foreach (Order order in orders)
            {
                orderViewModel.Add(order.ToOrderViewModel());
            }

            return orderViewModel;
        }

        public OrderViewModel GetOrderById(int id)
        {
            Order order = _orderRepository.GetById(id);
            if(order == null)
            {
                throw new Exception($"Order with id {id} does not exist");
            }

            return order.ToOrderViewModel();
        }
    }
}
