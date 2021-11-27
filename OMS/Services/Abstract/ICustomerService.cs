using OMS.API.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Services.Abstract
{
    public interface ICustomerService
    {
        Task<bool> Register(CustomerVM customerVM);
    }
}
