using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAppCli.Migrations
{
    public partial class RenamedTimeToFinishTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Todos",
                newName: "FinishTarget");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishTarget",
                table: "Todos",
                newName: "Time");
        }
    }
}
