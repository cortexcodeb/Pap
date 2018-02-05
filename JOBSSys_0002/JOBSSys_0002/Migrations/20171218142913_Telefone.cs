using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace JOBSSys_0002.Migrations
{
    public partial class Telefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Pessoa",
                newName: "Telefone");

            migrationBuilder.AddColumn<decimal>(
                name: "TaxaVisitacao",
                table: "Pessoa",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxaVisitacao",
                table: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Pessoa",
                newName: "Preco");
        }
    }
}
