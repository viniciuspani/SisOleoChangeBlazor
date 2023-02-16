using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisOleoChangeBlazor.Migrations
{
    public partial class CorrecaoTrocaOleo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrocaOleo_Filtros_FiltroId",
                table: "TrocaOleo");

            migrationBuilder.DropForeignKey(
                name: "FK_TrocaOleo_Oleos_OleoId",
                table: "TrocaOleo");

            migrationBuilder.DropForeignKey(
                name: "FK_TrocaOleo_Veiculos_VeiculoId",
                table: "TrocaOleo");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "TrocaOleo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantidadeOleo",
                table: "TrocaOleo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OleoId",
                table: "TrocaOleo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KmProximaTroca",
                table: "TrocaOleo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KmAtual",
                table: "TrocaOleo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FiltroId",
                table: "TrocaOleo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TrocaOleo_Filtros_FiltroId",
                table: "TrocaOleo",
                column: "FiltroId",
                principalTable: "Filtros",
                principalColumn: "FiltroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrocaOleo_Oleos_OleoId",
                table: "TrocaOleo",
                column: "OleoId",
                principalTable: "Oleos",
                principalColumn: "OleoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrocaOleo_Veiculos_VeiculoId",
                table: "TrocaOleo",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "VeiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrocaOleo_Filtros_FiltroId",
                table: "TrocaOleo");

            migrationBuilder.DropForeignKey(
                name: "FK_TrocaOleo_Oleos_OleoId",
                table: "TrocaOleo");

            migrationBuilder.DropForeignKey(
                name: "FK_TrocaOleo_Veiculos_VeiculoId",
                table: "TrocaOleo");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "TrocaOleo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantidadeOleo",
                table: "TrocaOleo",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "OleoId",
                table: "TrocaOleo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KmProximaTroca",
                table: "TrocaOleo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KmAtual",
                table: "TrocaOleo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FiltroId",
                table: "TrocaOleo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TrocaOleo_Filtros_FiltroId",
                table: "TrocaOleo",
                column: "FiltroId",
                principalTable: "Filtros",
                principalColumn: "FiltroId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrocaOleo_Oleos_OleoId",
                table: "TrocaOleo",
                column: "OleoId",
                principalTable: "Oleos",
                principalColumn: "OleoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrocaOleo_Veiculos_VeiculoId",
                table: "TrocaOleo",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "VeiculoId");
        }
    }
}
