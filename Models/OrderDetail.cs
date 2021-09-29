using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int bookId { get; set; }
        public Books Books { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
    }
}
