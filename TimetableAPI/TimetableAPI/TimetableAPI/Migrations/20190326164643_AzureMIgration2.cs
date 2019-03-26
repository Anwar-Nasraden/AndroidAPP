using Microsoft.EntityFrameworkCore.Migrations;

namespace TimetableAPI.Migrations
{
    public partial class AzureMIgration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Room",
                newName: "IsBusy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsBusy",
                table: "Room",
                newName: "Status");
        }
    }
}
