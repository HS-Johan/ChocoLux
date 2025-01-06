using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoLux.Migrations
{
    /// <inheritdoc />
    public partial class Chocolate_06Jan25_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chocolate",
                columns: table => new
                {
                    ChocolateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChocolateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChocolatePrice = table.Column<double>(type: "float", nullable: false),
                    ChocolateImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChocolateAmmount = table.Column<int>(type: "int", nullable: false),
                    ChocolateIsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chocolate", x => x.ChocolateId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chocolate");
        }
    }
}
