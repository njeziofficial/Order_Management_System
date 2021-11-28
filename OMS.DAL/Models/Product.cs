using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMS.DAL.Models
{
    public class Product
    {
        [MaxLength(11)]
        public int ProductId { get; set; }
        [MaxLength(30)]
        public string Names { get; set; }
        public bool IsAvailable { get; set; } = true;
        [MaxLength(100)]
        public string Flavours { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Pending> Pendings { get; set; }
    }
}
