using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OMS.API.Services.Abstract;
using OMS.API.ViewModels;
using OMS.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProduct()
        {
            var products = await productService.GetAllProducts();
            return Ok(products);
        }


        [HttpGet("GetProduct/{id}")]
        public async Task<IActionResult> GetProduct(int Id)
        {
            var product = await productService.GetProductByID(Id);
            return Ok(product);
        }

        [HttpPut("EditProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductVM productVM)
        {
            var reponse = await productService.UpdateProduct(productVM);
            if (reponse)
                return Ok(reponse);
            return BadRequest(reponse);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult>AddProduct([FromBody] ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                var serviceResponse = await productService.AddProduct(productVM);
                productVM = serviceResponse.Item1;
                bool isSuccess = serviceResponse.Item2;
                if (isSuccess)
                    return Ok(Tuple.Create(productVM, "Product Added Successfully."));                
            }
            return BadRequest(productVM);
        }
    }
}
