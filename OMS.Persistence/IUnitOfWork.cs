using OMS.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Persistence
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        public ICustomerRepository Customers { get; }

        Task<int> CompleteAsync();
    }
}
