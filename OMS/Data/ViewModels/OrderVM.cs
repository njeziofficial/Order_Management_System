using OMS.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Data.ViewModels
{
    public class OrderVM
    {
        public int OrderID { get; set; }

        public int PlacedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public IEnumerable<ProductVM> Products { get; set; }
    }
}
