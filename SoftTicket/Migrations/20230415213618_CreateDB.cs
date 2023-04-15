using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftTicket.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketID = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    UseDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", maxLength: 50, nullable: false),
                    EntranceGate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketID",
                table: "Tickets",
                column: "TicketID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
