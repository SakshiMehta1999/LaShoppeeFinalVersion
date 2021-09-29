using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class Books
    {
        [Key]
        public int bookId { get; set; }
        public string bookName { get; set; }
        public string bookDescription { get; set; }
        public decimal bookPrice { get; set; }
        public string bookImageUrl { get; set; }
        public string bookImageThumbnailUrl { get; set; }
        public bool bookInStock { get; set; }
        public bool bookOnSale { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }


    }
}
