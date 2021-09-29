using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class ShoppingCartItem
    {
        public int shoppingCartItemId { get; set; }
        public string shoppingCartId { get; set; }
        public Books Books { get; set; }
        public int Amount { get; set; }

    }
}
