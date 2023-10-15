using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAppCli.Migrations
{
    public partial class AddedIsFinished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Todos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Todos");
        }
    }
}
