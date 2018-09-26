using Microsoft.EntityFrameworkCore.Migrations;

namespace inventory.Migrations
{
    public partial class migr0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Devices");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "DeviceTypes");

            migrationBuilder.AddColumn<string>(
                name: "SerialNoRegex",
                table: "DeviceTypes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeviceTypes",
                table: "DeviceTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceTypes",
                table: "DeviceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "SerialNoRegex",
                table: "DeviceTypes");

            migrationBuilder.RenameTable(
                name: "DeviceTypes",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "Devices",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");
        }
    }
}
