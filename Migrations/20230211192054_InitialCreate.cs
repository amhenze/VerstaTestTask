using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VerstaTestTask.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderCity = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    SendersAddress = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ShippingCity = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    RecipientsAddress = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    PickupDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
