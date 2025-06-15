using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacaoDeTitulo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_StatusId",
                table: "Agendamentos",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_TituloId",
                table: "Agendamentos",
                column: "TituloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Status_StatusId",
                table: "Agendamentos",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Titulo_TituloId",
                table: "Agendamentos",
                column: "TituloId",
                principalTable: "Titulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Status_StatusId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Titulo_TituloId",
                table: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Titulo");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_StatusId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_TituloId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Agendamentos");
            
        }
    }
}
