using Microsoft.EntityFrameworkCore.Migrations;

namespace Users_WebApp.Migrations.Customers
{
    public partial class InitialCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanOrder",
                schema: "production",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "production",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FlaggedForDelete",
                schema: "production",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "production",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "production",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "production",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "production",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                schema: "production",
                table: "Customers",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "FirstName", "LastName", "Postcode" },
                values: new object[] { "whatever street", "John", "Doe", "sr8 543" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "production",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "production",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "production",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Postcode",
                schema: "production",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "CanOrder",
                schema: "production",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "production",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FlaggedForDelete",
                schema: "production",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "production",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "JohnDoe@Example.com", "John Doe" });
        }
    }
}
