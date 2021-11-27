using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMS.DAL.Models
{
    public class Order
    {
        [MaxLength(11)]
        public int OrderID { get; set; }

        [MaxLength(11)]
        [ForeignKey("Customer")]
        public int PlacedBy { get; set; }
        //[NotMapped]
        public Customer Customer { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalProduct { get; set; }
        public double TotalPrice { get; set; }
        public int OrderStatus { get; set; }
    }
}
