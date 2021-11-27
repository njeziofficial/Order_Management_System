using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMS.DAL.Models
{
    public class Pending
    {
        [MaxLength(11)]
        public int PendingId { get; set; }
        public int PendingNumber { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Flavors { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
