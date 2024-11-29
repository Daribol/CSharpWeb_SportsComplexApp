using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsComplexApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TournamentRegistration_AspNetUsers_TournamentId",
                table: "TournamentRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentRegistration_Clients_ClientId",
                table: "TournamentRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentRegistration_Tournament_TournamentId1",
                table: "TournamentRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainersSession_AspNetUsers_TrainerId",
                table: "TrainersSession");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainersSession_Clients_ClientId",
                table: "TrainersSession");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainersSession_Trainers_TrainerId1",
                table: "TrainersSession");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainersSession",
                table: "TrainersSession");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TournamentRegistration",
                table: "TournamentRegistration");

            migrationBuilder.RenameTable(
                name: "TrainersSession",
                newName: "TrainerSessions");

            migrationBuilder.RenameTable(
                name: "TournamentRegistration",
                newName: "TournamentRegistrations");

            migrationBuilder.RenameIndex(
                name: "IX_TrainersSession_TrainerId1",
                table: "TrainerSessions",
                newName: "IX_TrainerSessions_TrainerId1");

            migrationBuilder.RenameIndex(
                name: "IX_TrainersSession_TrainerId",
                table: "TrainerSessions",
                newName: "IX_TrainerSessions_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_TournamentRegistration_TournamentId1",
                table: "TournamentRegistrations",
                newName: "IX_TournamentRegistrations_TournamentId1");

            migrationBuilder.RenameIndex(
                name: "IX_TournamentRegistration_TournamentId",
                table: "TournamentRegistrations",
                newName: "IX_TournamentRegistrations_TournamentId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "SpaReservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerSessions",
                table: "TrainerSessions",
                columns: new[] { "ClientId", "TrainerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TournamentRegistrations",
                table: "TournamentRegistrations",
                columns: new[] { "ClientId", "TournamentId" });

            migrationBuilder.CreateIndex(
                name: "IX_SpaReservations_ClientId1",
                table: "SpaReservations",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SpaReservations_Clients_ClientId1",
                table: "SpaReservations",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentRegistrations_AspNetUsers_TournamentId",
                table: "TournamentRegistrations",
                column: "TournamentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentRegistrations_Clients_ClientId",
                table: "TournamentRegistrations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentRegistrations_Tournament_TournamentId1",
                table: "TournamentRegistrations",
                column: "TournamentId1",
                principalTable: "Tournament",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSessions_AspNetUsers_TrainerId",
                table: "TrainerSessions",
                column: "TrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSessions_Clients_ClientId",
                table: "TrainerSessions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSessions_Trainers_TrainerId1",
                table: "TrainerSessions",
                column: "TrainerId1",
                principalTable: "Trainers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpaReservations_Clients_ClientId1",
                table: "SpaReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentRegistrations_AspNetUsers_TournamentId",
                table: "TournamentRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentRegistrations_Clients_ClientId",
                table: "TournamentRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentRegistrations_Tournament_TournamentId1",
                table: "TournamentRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSessions_AspNetUsers_TrainerId",
                table: "TrainerSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSessions_Clients_ClientId",
                table: "TrainerSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSessions_Trainers_TrainerId1",
                table: "TrainerSessions");

            migrationBuilder.DropIndex(
                name: "IX_SpaReservations_ClientId1",
                table: "SpaReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerSessions",
                table: "TrainerSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TournamentRegistrations",
                table: "TournamentRegistrations");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "SpaReservations");

            migrationBuilder.RenameTable(
                name: "TrainerSessions",
                newName: "TrainersSession");

            migrationBuilder.RenameTable(
                name: "TournamentRegistrations",
                newName: "TournamentRegistration");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerSessions_TrainerId1",
                table: "TrainersSession",
                newName: "IX_TrainersSession_TrainerId1");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerSessions_TrainerId",
                table: "TrainersSession",
                newName: "IX_TrainersSession_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_TournamentRegistrations_TournamentId1",
                table: "TournamentRegistration",
                newName: "IX_TournamentRegistration_TournamentId1");

            migrationBuilder.RenameIndex(
                name: "IX_TournamentRegistrations_TournamentId",
                table: "TournamentRegistration",
                newName: "IX_TournamentRegistration_TournamentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainersSession",
                table: "TrainersSession",
                columns: new[] { "ClientId", "TrainerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TournamentRegistration",
                table: "TournamentRegistration",
                columns: new[] { "ClientId", "TournamentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentRegistration_AspNetUsers_TournamentId",
                table: "TournamentRegistration",
                column: "TournamentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentRegistration_Clients_ClientId",
                table: "TournamentRegistration",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentRegistration_Tournament_TournamentId1",
                table: "TournamentRegistration",
                column: "TournamentId1",
                principalTable: "Tournament",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainersSession_AspNetUsers_TrainerId",
                table: "TrainersSession",
                column: "TrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainersSession_Clients_ClientId",
                table: "TrainersSession",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainersSession_Trainers_TrainerId1",
                table: "TrainersSession",
                column: "TrainerId1",
                principalTable: "Trainers",
                principalColumn: "Id");
        }
    }
}
