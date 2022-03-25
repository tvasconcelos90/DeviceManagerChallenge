using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManager_WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Info = table.Column<string>(type: "TEXT", nullable: false),
                    Temperature = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Info", "Name", "Status", "Temperature", "Type" },
                values: new object[] { 1, "Personal smartphone", "Personal Phone", "Available", 28m, "smartphone" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Info", "Name", "Status", "Temperature", "Type" },
                values: new object[] { 2, "Samsung Tablet", "Work Tablet", "Offline", 33m, "tablet" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Info", "Name", "Status", "Temperature", "Type" },
                values: new object[] { 3, "Company's Computer", "Work Computer", "Available", 48m, "computer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
