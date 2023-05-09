using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Authentication_Authorization.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleDescr",
                table: "UserDetails",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleDescr",
                table: "UserDetails");
        }
    }
}
