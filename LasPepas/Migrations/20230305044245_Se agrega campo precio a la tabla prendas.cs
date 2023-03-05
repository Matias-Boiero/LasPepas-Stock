﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasPepas.Migrations
{
    public partial class Seagregacampoprecioalatablaprendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Prendas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Prendas");
        }
    }
}
