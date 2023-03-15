using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class SemodificatablaPrendascampoCtaCte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entrega",
                table: "Prendas");

            migrationBuilder.AlterColumn<bool>(
                name: "VentaCtaCorriente",
                table: "Prendas",
                type: "bit",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condicional",
                table: "Prendas",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condicional",
                table: "Prendas");

            migrationBuilder.AlterColumn<decimal>(
                name: "VentaCtaCorriente",
                table: "Prendas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Entrega",
                table: "Prendas",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
