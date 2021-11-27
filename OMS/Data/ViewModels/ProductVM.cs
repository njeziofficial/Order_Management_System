using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.ViewModels
{
    public class ProductVM
    {

        public int ProductId { get; set; }
        public string Names { get; set; }
        public string Flavours { get; set; }
        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
