using OMS.API.ViewModels;
using OMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Services.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductVM>> GetAllProducts();
        Task<ProductVM> GetProductByID(int Id);
        Task<bool> UpdateProduct(ProductVM productVM);
        Task<Tuple<ProductVM, bool>> AddProduct(ProductVM productVM);
    }
}
