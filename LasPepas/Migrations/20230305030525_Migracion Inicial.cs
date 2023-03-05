using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prendas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoPrenda = table.Column<int>(type: "int", nullable: false),
                    Temporada = table.Column<int>(type: "int", nullable: false),
                    Descripción = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Talle = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VentaContado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VentaCtaCorriente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VentaTarjeta = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoVenta = table.Column<int>(type: "int", nullable: true),
                    Cliente = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prendas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prendas");
        }
    }
}
