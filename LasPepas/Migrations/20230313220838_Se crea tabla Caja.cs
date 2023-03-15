using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class SecreatablaCaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "VentaCtaCorriente",
                table: "Prendas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Condicional",
                table: "Prendas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cajas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    formaPago_1 = table.Column<int>(type: "int", nullable: true),
                    formaPago_2 = table.Column<int>(type: "int", nullable: true),
                    IngresoEfectivo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IngresoBancario = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NroCuotas = table.Column<int>(type: "int", nullable: true),
                    Egreso = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoEgreso = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cambio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalEfectivo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalBancarizado = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cajas");

            migrationBuilder.AlterColumn<bool>(
                name: "VentaCtaCorriente",
                table: "Prendas",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Condicional",
                table: "Prendas",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
