using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devPartnerTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaFiscais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroNf = table.Column<int>(type: "int", nullable: false),
                    valorTotal = table.Column<double>(type: "float", nullable: false),
                    dataNf = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cnpjEmissorNf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnpjDestinatarioNf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscais", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaFiscais");
        }
    }
}
