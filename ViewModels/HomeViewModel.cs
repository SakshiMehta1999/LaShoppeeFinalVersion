using LaShoppeeFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Books> bookOnSale { get; set; }
    }
}
