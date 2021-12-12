using Microsoft.EntityFrameworkCore.Migrations;

namespace Users_WebApp.Migrations.Products
{
    public partial class ProductsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "production",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "Products",
                columns: new[] { "Id", "ProductDesc", "ProductName" },
                values: new object[] { 1, "This is a test item", "Test Item" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "production");
        }
    }
}
