using Microsoft.EntityFrameworkCore.Migrations;

namespace LaShoppeeFinalVersion.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "bookies",
                columns: table => new
                {
                    bookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookName = table.Column<string>(nullable: true),
                    bookDescription = table.Column<string>(nullable: true),
                    bookPrice = table.Column<decimal>(nullable: false),
                    bookImageUrl = table.Column<string>(nullable: true),
                    bookImageThumbnailUrl = table.Column<string>(nullable: true),
                    bookInStock = table.Column<bool>(nullable: false),
                    bookOnSale = table.Column<bool>(nullable: false),
                    categoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookies", x => x.bookId);
                    table.ForeignKey(
                        name: "FK_bookies_categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookies_categoryId",
                table: "bookies",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookies");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
