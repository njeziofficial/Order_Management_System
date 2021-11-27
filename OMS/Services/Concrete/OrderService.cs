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
        private readonly IOrder_BLL order_BLL;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper, IOrder_BLL order_BLL)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.order_BLL = order_BLL;
        }
        //public async Task<Tuple<OrderVM, bool, string>>PlaceOrder(OrderVM orderVM)
        //{
        //    var order = mapper.Map<Order>(orderVM);
        //    var response = await order_BLL.PlaceOrder(order);
        //}
    }
}
