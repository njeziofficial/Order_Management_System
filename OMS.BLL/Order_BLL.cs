using OMS.DAL.Models;
using OMS.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL
{
    public class Order_BLL : IOrder_BLL
    {
        private readonly IUnitOfWork unitOfWork;

        public Order_BLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //public async Task<Tuple<Order, bool, string>> PlaceOrder(Order order)
        //{            

        //}
    }

    public interface IOrder_BLL
    {
        //Task<Tuple<Order, bool, string>> PlaceOrder(Order order);
    }
}
