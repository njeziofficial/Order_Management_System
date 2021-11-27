using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Data.ViewModels
{
    public class CustomerVM
    {
        public int CustomerId { get; set; }        
        public string Username { get; set; }
        public string Password { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(20)]
        [Required]
        public string Phone { get; set; }
        public IEnumerable<TransactionVM> Transactions { get; set; }
        public IEnumerable<PendingVM> Pendings { get; set; }
    }
}
