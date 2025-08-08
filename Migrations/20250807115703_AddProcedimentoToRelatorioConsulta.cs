using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class AddProcedimentoToRelatorioConsulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Procedimento",
                table: "RelatoriosConsultas");

            migrationBuilder.CreateIndex(
                name: "IX_RelatoriosConsultas_ProcedimentoId",
                table: "RelatoriosConsultas",
                column: "ProcedimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoriosConsultas_Procedimentos_ProcedimentoId",
                table: "RelatoriosConsultas",
                column: "ProcedimentoId",
                principalTable: "Procedimentos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatoriosConsultas_Procedimentos_ProcedimentoId",
                table: "RelatoriosConsultas");

            migrationBuilder.DropIndex(
                name: "IX_RelatoriosConsultas_ProcedimentoId",
                table: "RelatoriosConsultas");

            migrationBuilder.AddColumn<string>(
                name: "Procedimento",
                table: "RelatoriosConsultas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
