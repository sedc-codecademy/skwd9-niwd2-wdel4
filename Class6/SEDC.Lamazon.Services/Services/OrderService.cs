using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IRepository<Order> _orderRepository;
        protected readonly IMapper _mapper;

        public OrderService(IRepository<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            IEnumerable<Order> orders = _orderRepository.GetAll();
            List<OrderViewModel> mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
            return mappedOrders;
        }
    }
}
