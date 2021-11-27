using OMS.DAL.Models;
using OMS.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.Persistence.Repositories.Concrete
{

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext context;

        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
