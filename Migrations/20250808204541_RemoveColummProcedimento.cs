using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColummProcedimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "RelatoriosConsultas");

            migrationBuilder.DropColumn(
                name: "ProcedimentoId",
                table: "RelatoriosConsultas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "RelatoriosConsultas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ProcedimentoId",
                table: "RelatoriosConsultas",
                type: "INTEGER",
                nullable: true);
        }
    }
}
