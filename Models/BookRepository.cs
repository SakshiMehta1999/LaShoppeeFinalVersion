using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Books> GetAllBooks
        {
            get {
                return _appDbContext.bookies.Include(b => b.Category);
            } 

        }

        public IEnumerable<Books> GetBooksOnSale {
            get
            {
                return _appDbContext.bookies.Include(b => b.Category).Where(p=>p.bookOnSale);
            }
        }

        public Books GetBookBYId(int bookId)
        {
            return _appDbContext.bookies.FirstOrDefault(b => b.bookId == bookId);
            
        }
    }
}
