using LaShoppeeFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Books> bookies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
