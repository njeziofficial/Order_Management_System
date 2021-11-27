using AutoMapper;
using OMS.API.Services.Abstract;
using OMS.API.ViewModels;
using OMS.BLL;
using OMS.DAL.Models;
using OMS.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProductVM>> GetAllProducts()
        {
            var products = await unitOfWork.Products.GetAll();
            var response = products.Select(mapper.Map<ProductVM>).ToList();
            return response;
        }

        public async Task<ProductVM> GetProductByID(int Id)
        {
            var product = await unitOfWork.Products.Get(Id);
            var response = mapper.Map<ProductVM>(product);
            return response;
        }

        public async Task<bool> UpdateProduct(ProductVM productVM)
        {
            var product = await unitOfWork.Products.Get(productVM.ProductId);
            mapper.Map(productVM, product);
            bool status = await unitOfWork.CompleteAsync() > 0;
            return status;
        }

        public async Task<Tuple<ProductVM, bool>>AddProduct(ProductVM productVM)
        {
            bool isSuccess = false;
            var product = mapper.Map<Product>(productVM);
            product = await unitOfWork.Products.Add(product);
            if (product != null)
            {
                productVM = mapper.Map(product, productVM);

                isSuccess = productVM.ProductId > 0;                
            }
            return Tuple.Create(productVM, isSuccess);
        }
    }
}
