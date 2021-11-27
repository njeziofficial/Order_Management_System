using OMS.Persistence.Repositories.Abstract;
using OMS.Persistence.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Orders = new OrderRepository(_context);
            Customers = new CustomerRepository(_context);

        }
        public IProductRepository Products { get; }
        public IOrderRepository Orders { get; }
        public ICustomerRepository Customers { get; }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public async Task Dispose() => await _context.DisposeAsync();
    }
}
