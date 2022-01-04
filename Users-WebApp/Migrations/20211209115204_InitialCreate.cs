using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Users_WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "production",
                columns: table => new
                {
                    OrdersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderProductQuantity = table.Column<int>(nullable: false),
                    OrderTotalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrdersID);
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "Orders",
                columns: new[] { "OrdersID", "CustomerID", "OrderDate", "OrderProductQuantity", "OrderTotalPrice", "ProductDescription", "ProductID", "ProductName" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 13, "This is an example item", 1, "Example Item" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders",
                schema: "production");
        }
    }
}
