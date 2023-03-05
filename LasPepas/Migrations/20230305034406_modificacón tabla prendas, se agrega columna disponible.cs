using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class modificacóntablaprendasseagregacolumnadisponible : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Prendas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Prendas");
        }
    }
}
