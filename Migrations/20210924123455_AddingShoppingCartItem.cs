using Microsoft.EntityFrameworkCore.Migrations;

namespace LaShoppeeFinalVersion.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    shoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shoppingCartId = table.Column<string>(nullable: true),
                    BooksbookId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.shoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_bookies_BooksbookId",
                        column: x => x.BooksbookId,
                        principalTable: "bookies",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_BooksbookId",
                table: "ShoppingCartItems",
                column: "BooksbookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");
        }
    }
}
