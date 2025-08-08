using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class AddColunaAgendamentoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatoriosConsultas_Procedimentos_ProcedimentoId",
                table: "RelatoriosConsultas");

            migrationBuilder.DropIndex(
                name: "IX_RelatoriosConsultas_ProcedimentoId",
                table: "RelatoriosConsultas");

            migrationBuilder.AddColumn<int>(
                name: "AgendamentoId",
                table: "RelatoriosConsultas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelatoriosConsultas_AgendamentoId",
                table: "RelatoriosConsultas",
                column: "AgendamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoriosConsultas_Agendamentos_AgendamentoId",
                table: "RelatoriosConsultas",
                column: "AgendamentoId",
                principalTable: "Agendamentos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatoriosConsultas_Agendamentos_AgendamentoId",
                table: "RelatoriosConsultas");

            migrationBuilder.DropIndex(
                name: "IX_RelatoriosConsultas_AgendamentoId",
                table: "RelatoriosConsultas");

            migrationBuilder.DropColumn(
                name: "AgendamentoId",
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
    }
}
