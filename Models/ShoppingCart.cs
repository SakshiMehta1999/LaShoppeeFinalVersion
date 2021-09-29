using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string shoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
           
            return new ShoppingCart(context) { shoppingCartId = cartId };
        }
        public void AddToCart(Books books,int amount) {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Books.bookId == books.bookId && s.shoppingCartId == shoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    shoppingCartId = shoppingCartId,
                    Books = books,
                    Amount = amount
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Books books) {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Books.bookId == books.bookId && s.shoppingCartId == shoppingCartId);
            var localAmount = 0;
            if (shoppingCartItem !=null) {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems() {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.shoppingCartId == shoppingCartId).Include(s => s.Books).ToList());
        }
        public void ClearCart() {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.shoppingCartId == shoppingCartId);
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal() {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.shoppingCartId == shoppingCartId)
            .Select(c => c.Books.bookPrice * c.Amount).Sum();
            return total;
        }
    }
}
