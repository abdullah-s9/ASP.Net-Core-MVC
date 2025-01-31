using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaudiGuide.Migrations
{
    /// <inheritdoc />
    public partial class no03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Reservations");
        }
    }
}
