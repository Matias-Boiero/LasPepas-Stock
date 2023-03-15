using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class CambiosenlatablaCajas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalBancarizado",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "TotalEfectivo",
                table: "Cajas");

            migrationBuilder.RenameColumn(
                name: "formaPago_2",
                table: "Cajas",
                newName: "FormaPago_2");

            migrationBuilder.RenameColumn(
                name: "formaPago_1",
                table: "Cajas",
                newName: "FormaPago_1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormaPago_2",
                table: "Cajas",
                newName: "formaPago_2");

            migrationBuilder.RenameColumn(
                name: "FormaPago_1",
                table: "Cajas",
                newName: "formaPago_1");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalBancarizado",
                table: "Cajas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalEfectivo",
                table: "Cajas",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
