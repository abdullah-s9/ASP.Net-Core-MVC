using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaudiGuide.Migrations
{
    /// <inheritdoc />
    public partial class n01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
    name: "Reservations",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
        Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
        Date = table.Column<DateTime>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Cities", x => x.Id);
    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

        }
    }
}
