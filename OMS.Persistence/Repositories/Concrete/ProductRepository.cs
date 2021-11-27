using Microsoft.EntityFrameworkCore;
using OMS.DAL.Models;
using OMS.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Persistence.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Product>> GetProductWithTransactions(int productID)
        => await ApplicationDbContext.Products.Include(x => x.Transactions).Where(x => x.ProductId == productID).ToListAsync();


        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
