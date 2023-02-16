using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisOleoChangeBlazor.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filtros",
                columns: table => new
                {
                    FiltroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    TipoFiltro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filtros", x => x.FiltroId);
                });

            migrationBuilder.CreateTable(
                name: "Oleos",
                columns: table => new
                {
                    OleoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    TipoOleo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oleos", x => x.OleoId);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoFabricacao = table.Column<int>(type: "int", nullable: false),
                    TipoVeiculo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                });

            migrationBuilder.CreateTable(
                name: "TrocaOleo",
                columns: table => new
                {
                    TrocaOleoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeiculoId = table.Column<int>(type: "int", nullable: false),
                    OleoId = table.Column<int>(type: "int", nullable: false),
                    FiltroId = table.Column<int>(type: "int", nullable: false),
                    KmAtual = table.Column<int>(type: "int", nullable: false),
                    KmProximaTroca = table.Column<int>(type: "int", nullable: false),
                    QuantidadeOleo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataProximaTroca = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrocaOleo", x => x.TrocaOleoId);
                    table.ForeignKey(
                        name: "FK_TrocaOleo_Filtros_FiltroId",
                        column: x => x.FiltroId,
                        principalTable: "Filtros",
                        principalColumn: "FiltroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrocaOleo_Oleos_OleoId",
                        column: x => x.OleoId,
                        principalTable: "Oleos",
                        principalColumn: "OleoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrocaOleo_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "VeiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrocaOleo_FiltroId",
                table: "TrocaOleo",
                column: "FiltroId");

            migrationBuilder.CreateIndex(
                name: "IX_TrocaOleo_OleoId",
                table: "TrocaOleo",
                column: "OleoId");

            migrationBuilder.CreateIndex(
                name: "IX_TrocaOleo_VeiculoId",
                table: "TrocaOleo",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrocaOleo");

            migrationBuilder.DropTable(
                name: "Filtros");

            migrationBuilder.DropTable(
                name: "Oleos");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
