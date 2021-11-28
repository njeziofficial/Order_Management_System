using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMS.DAL.Models
{
    public class Transaction
    {
        [MaxLength(11)]
        public int TransactionId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public double TotalPrice { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public DateTime DateDelivered { get; set; }

    }
}
