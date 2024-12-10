using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationTnsClub.Migrations
{
    /// <inheritdoc />
    public partial class smallChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Prices_RateId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Prices_PricesId",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "PricesId",
                table: "Sessions",
                newName: "PriceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_PricesId",
                table: "Sessions",
                newName: "IX_Sessions_PriceId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Prices",
                newName: "tariff");

            migrationBuilder.RenameColumn(
                name: "RateId",
                table: "Bookings",
                newName: "PriceId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_RateId",
                table: "Bookings",
                newName: "IX_Bookings_PriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Prices_PriceId",
                table: "Bookings",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Prices_PriceId",
                table: "Sessions",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Prices_PriceId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Prices_PriceId",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "PriceId",
                table: "Sessions",
                newName: "PricesId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_PriceId",
                table: "Sessions",
                newName: "IX_Sessions_PricesId");

            migrationBuilder.RenameColumn(
                name: "tariff",
                table: "Prices",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "PriceId",
                table: "Bookings",
                newName: "RateId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_PriceId",
                table: "Bookings",
                newName: "IX_Bookings_RateId");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Bookings",
                type: "integer",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Prices_RateId",
                table: "Bookings",
                column: "RateId",
                principalTable: "Prices",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Prices_PricesId",
                table: "Sessions",
                column: "PricesId",
                principalTable: "Prices",
                principalColumn: "id");
        }
    }
}
