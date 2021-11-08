using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Enums;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enums;
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
        protected readonly IUserRepository _userRepository;

        public OrderService(IRepository<Order> orderRepository, IMapper mapper, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public int ChangeStatus(int orderId, string userId, StatusTypeViewModel status)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);

                order.Status = (StatusType)status;

                if(status == StatusTypeViewModel.Pending)
                {
                    _orderRepository.Insert(
                        new Order
                        {
                            User = user,
                            DateOfOrder = DateTime.Now,
                            Status = StatusType.Init
                        }
                      );
                    
                }
                return _orderRepository.Update(order);

            }
            catch(Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            IEnumerable<Order> orders = _orderRepository.GetAll();
            List<OrderViewModel> mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
            return mappedOrders;
        }

        public OrderViewModel GetOrderById(int id)
        {
            return _mapper.Map<OrderViewModel>(_orderRepository.GetById(id));
        }
    }
}
