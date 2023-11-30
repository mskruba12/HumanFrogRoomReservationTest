using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class Update2RemoveRR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomsToReservations");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Reservations");

            migrationBuilder.CreateTable(
                name: "RoomsToReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsToReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomsToReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomsToReservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomsToReservations_ReservationId",
                table: "RoomsToReservations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsToReservations_RoomId",
                table: "RoomsToReservations",
                column: "RoomId");
        }
    }
}
