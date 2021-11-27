using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMS.API.Data.ViewModels;
using OMS.API.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        public async Task<IActionResult> Register(CustomerVM customerVM)
        {
            bool isSuccess = await customerService.Register(customerVM);
            if (isSuccess)
                return Ok("Successfuly registered.");
            return BadRequest("An Error while trying to register.");

        }
    }
}
