using Microsoft.EntityFrameworkCore.Migrations;

namespace LaShoppeeFinalVersion.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "categoryId", "categoryDescription", "categoryName" },
                values: new object[,]
                {
                    { 1, null, "Fiction Genre" },
                    { 2, null, "Non-Fiction Genre" },
                    { 3, null, "Thrilling Genre" },
                    { 4, null, "Romantic Genre" }
                });

            migrationBuilder.InsertData(
                table: "bookies",
                columns: new[] { "bookId", "bookDescription", "bookImageThumbnailUrl", "bookImageUrl", "bookInStock", "bookName", "bookOnSale", "bookPrice", "categoryId" },
                values: new object[,]
                {
                    { 1, "A fiction story about an indian girl by chetan bhagat", "\\Images\\OneIndianGirl.jpg", "\\Images\\OneIndianGirl.jpg", true, "Onew Indian Girl", false, 350m, 1 },
                    { 2, "A fiction story about an indian girl by chetan bhagat", "\\Images\\Fictiontwo.jpg", "\\Images\\Fictiontwo.jpg", true, "Ray Bearer", false, 399m, 1 },
                    { 3, "A fiction story about an indian girl by chetan bhagat", "\\Images\\Fictionthree.jpg", "\\Images\\Fictionthree.jpg", true, "What People Won't Do", false, 999m, 1 },
                    { 4, "A Non-fiction story about Squirrel Busy years", "\\Images\\nonfictiononee.jpg", "\\Images\\nonfictiononee.jpg", true, "Squirrels Busy Year", false, 1999m, 2 },
                    { 5, "A Non-fiction story about elephants and animals", "\\Images\\nonfictiontwoo.jpg", "\\Images\\nonfictiontwoo.jpg", true, "Just So Stories", false, 899m, 2 },
                    { 6, "A Non-fiction story about Penguins", "\\Images\\nonfictionthreee.jpg", "\\Images\\nonfictionthreee.jpg", true, "Penguins", false, 1899m, 2 },
                    { 7, "Adventure genre", "\\Images\\adventureone.jpg", "\\Images\\adventureone.jpg", true, "The Leopard Princess", false, 599m, 3 },
                    { 8, "Adventure genre on Dragon Run", "\\Images\\adventuretwo.jpg", "\\Images\\adventuretwo.jpg", true, "Dragon Run", false, 479m, 3 },
                    { 9, "Adventure genre on Dragon Run", "\\Images\\adventurethree.jpg", "\\Images\\adventurethree.jpg", true, "The Town House", false, 479m, 3 },
                    { 10, "Romantic love story", "\\Images\\romanticone.jpg", "\\Images\\romanticone.jpg", true, "Love Song", false, 879m, 4 },
                    { 11, "Romantic love story being Wild in Love", "\\Images\\romantictwo.jpg", "\\Images\\romantictwo.jpg", true, "Wild In Love", true, 379m, 4 },
                    { 12, "Romantic love story beast", "\\Images\\romanticthree.jpg", "\\Images\\romanticthree.jpg", false, "Romantic and the Clock Work Beast", true, 379m, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "bookies",
                keyColumn: "bookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: 4);
        }
    }
}
