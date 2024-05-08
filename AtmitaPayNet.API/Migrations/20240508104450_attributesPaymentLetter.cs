using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmitaPayNet.API.Migrations
{
    /// <inheritdoc />
    public partial class attributesPaymentLetter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PDF",
                table: "PaymentLetters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "PaymentLetters",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PDF",
                table: "PaymentLetters");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PaymentLetters");
        }
    }
}
