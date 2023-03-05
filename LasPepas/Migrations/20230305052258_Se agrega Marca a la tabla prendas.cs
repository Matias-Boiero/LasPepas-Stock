using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class SeagregaMarcaalatablaprendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Marca",
                table: "Prendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Prendas");
        }
    }
}
