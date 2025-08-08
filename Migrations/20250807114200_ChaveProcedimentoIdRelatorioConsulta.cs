using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class ChaveProcedimentoIdRelatorioConsulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProcedimentoId",
                table: "RelatoriosConsultas",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcedimentoId",
                table: "RelatoriosConsultas");
        }
    }
}
