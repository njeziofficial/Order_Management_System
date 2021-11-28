using OMS.DAL.Models;
using OMS.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.Persistence.Repositories.Concrete
{

    public class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        private readonly ApplicationDbContext context;

        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
