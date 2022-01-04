using Microsoft.EntityFrameworkCore.Migrations;

namespace Users_WebApp.Migrations.Customers
{
    public partial class CustomersCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "production",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    CanOrder = table.Column<bool>(nullable: false),
                    FlaggedForDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "Customers",
                columns: new[] { "Id", "CanOrder", "Email", "FlaggedForDelete", "Name", "PhoneNumber" },
                values: new object[] { 1, false, "JohnDoe@Example.com", false, "John Doe", "123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers",
                schema: "production");
        }
    }
}
