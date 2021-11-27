using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OMS.DAL.Models
{
    public class Customer
    {
        [MaxLength(11)]
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Pending> Pendings { get; set; }
    }
}
