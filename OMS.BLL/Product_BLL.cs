using OMS.DAL.Models;
using OMS.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OMS.BLL
{
    public class Product_BLL
    {
        private readonly IUnitOfWork unitOfWork;

        public Product_BLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Product>> GetProducts()
            => await unitOfWork.Products.GetAll();
    }
}
