using AutoMapper;
using OMS.API.Data.ViewModels;
using OMS.BLL;
using OMS.DAL.Models;
using OMS.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Services.Concrete
{
    public class OrderService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<Tuple<bool, string>> PlaceOrder(OrderVM orderVM)
        {
            var order = mapper.Map<Order>(orderVM);
            order = await unitOfWork.Orders.Add(order);
            var order_product = orderVM.Products.Select(x => new OrderProduct
            {
                OrderID = order.OrderID,
                ProductID = x.ProductId
            }).ToArray();
            bool isSuccess = await unitOfWork.OrderProducts.AddRange(order_product);
            string message = "Error in Placing Order.";
            if (isSuccess)
                message = "Order placed successfully.";
            return Tuple.Create(isSuccess, message);
        }
    }
}
