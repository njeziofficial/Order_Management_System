using OMS.DAL.Models;
using OMS.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.Persistence.Repositories.Concrete
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext context;

        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
