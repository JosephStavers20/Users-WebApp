using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Users_WebApp.Migrations.ProductReview
{
    public partial class ProductReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                schema: "production",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductReviewHeader = table.Column<string>(nullable: true),
                    ProductReviewContent = table.Column<string>(nullable: true),
                    ProductReviewDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "ProductReviews",
                columns: new[] { "Id", "ProductReviewContent", "ProductReviewDateTime", "ProductReviewHeader" },
                values: new object[] { 1, "This Item very good", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductReviews",
                schema: "production");
        }
    }
}
