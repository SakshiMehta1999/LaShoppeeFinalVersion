using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public interface IBookRepository
    {
        IEnumerable<Books> GetAllBooks { get; }
        IEnumerable<Books> GetBooksOnSale { get; }
        Books GetBookBYId(int bookId);

    }
}
