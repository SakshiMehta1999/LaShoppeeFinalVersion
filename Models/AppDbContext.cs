using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options){ 
            
        }
        public DbSet<Books> bookies { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 1, categoryName = "Fiction Genre" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 2, categoryName = "Non-Fiction Genre" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 3, categoryName = "Thrilling Genre" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 4, categoryName = "Romantic Genre" });

            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 1,
                bookName = "Onew Indian Girl",
                bookPrice = 350,
                bookDescription = "A fiction story about an indian girl by chetan bhagat",
                categoryId = 1,
                bookImageUrl = "\\Images\\OneIndianGirl.jpg",
                bookImageThumbnailUrl= "\\Images\\OneIndianGirl.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 2,
                bookName = "Ray Bearer",
                bookPrice = 399,
                bookDescription = "A fiction story about an indian girl by chetan bhagat",
                categoryId = 1,
                bookImageUrl = "\\Images\\Fictiontwo.jpg",
                bookImageThumbnailUrl = "\\Images\\Fictiontwo.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 3,
                bookName = "What People Won't Do",
                bookPrice = 999,
                bookDescription = "A fiction story about an indian girl by chetan bhagat",
                categoryId = 1,
                bookImageUrl = "\\Images\\Fictionthree.jpg",
                bookImageThumbnailUrl = "\\Images\\Fictionthree.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 4,
                bookName = "Squirrels Busy Year",
                bookPrice = 1999,
                bookDescription = "A Non-fiction story about Squirrel Busy years",
                categoryId = 2,
                bookImageUrl = "\\Images\\nonfictiononee.jpg",
                bookImageThumbnailUrl = "\\Images\\nonfictiononee.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 5,
                bookName = "Just So Stories",
                bookPrice = 899,
                bookDescription = "A Non-fiction story about elephants and animals",
                categoryId = 2,
                bookImageUrl = "\\Images\\nonfictiontwoo.jpg",
                bookImageThumbnailUrl = "\\Images\\nonfictiontwoo.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 6,
                bookName = "Penguins",
                bookPrice = 1899,
                bookDescription = "A Non-fiction story about Penguins",
                categoryId = 2,
                bookImageUrl = "\\Images\\nonfictionthreee.jpg",
                bookImageThumbnailUrl = "\\Images\\nonfictionthreee.jpg",
                bookInStock = true,
                bookOnSale = false
            });

            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 7,
                bookName = "The Leopard Princess",
                bookPrice = 599,
                bookDescription = "Adventure genre",
                categoryId = 3,
                bookImageUrl = "\\Images\\adventureone.jpg",
                bookImageThumbnailUrl = "\\Images\\adventureone.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 8,
                bookName = "Dragon Run",
                bookPrice = 479,
                bookDescription = "Adventure genre on Dragon Run",
                categoryId = 3,
                bookImageUrl = "\\Images\\adventuretwo.jpg",
                bookImageThumbnailUrl = "\\Images\\adventuretwo.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 9,
                bookName = "The Town House",
                bookPrice = 479,
                bookDescription = "Adventure genre on Dragon Run",
                categoryId = 3,
                bookImageUrl = "\\Images\\adventurethree.jpg",
                bookImageThumbnailUrl = "\\Images\\adventurethree.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 10,
                bookName = "Love Song",
                bookPrice = 879,
                bookDescription = "Romantic love story",
                categoryId = 4,
                bookImageUrl = "\\Images\\romanticone.jpg",
                bookImageThumbnailUrl = "\\Images\\romanticone.jpg",
                bookInStock = true,
                bookOnSale = false
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 11,
                bookName = "Wild In Love",
                bookPrice = 379,
                bookDescription = "Romantic love story being Wild in Love",
                categoryId = 4,
                bookImageUrl = "\\Images\\romantictwo.jpg",
                bookImageThumbnailUrl = "\\Images\\romantictwo.jpg",
                bookInStock = true,
                bookOnSale = true
            });
            modelBuilder.Entity<Books>().HasData(new Books
            {
                bookId = 12,
                bookName = "Romantic and the Clock Work Beast",
                bookPrice = 379,
                bookDescription = "Romantic love story beast",
                categoryId = 4,
                bookImageUrl = "\\Images\\romanticthree.jpg",
                bookImageThumbnailUrl = "\\Images\\romanticthree.jpg",
                bookInStock = false,
                bookOnSale = true
            });

        }
    }
}
