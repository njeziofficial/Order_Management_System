using AutoMapper;
using OMS.API.Data.ViewModels;
using OMS.API.Services.Abstract;
using OMS.DAL.Models;
using OMS.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Register(CustomerVM customerVM)
        {
            var customer = mapper.Map<Customer>(customerVM);
            var salt = Guid.NewGuid().ToString();
            customer.Salt = salt;
            customer.Password += salt;
            customer.Password = Utilities.Utility.PasswordEncoder(customer.Password);
            customer = await unitOfWork.Customers.Add(customer);
            return customer.CustomerId > 0;
        }
    }
}
