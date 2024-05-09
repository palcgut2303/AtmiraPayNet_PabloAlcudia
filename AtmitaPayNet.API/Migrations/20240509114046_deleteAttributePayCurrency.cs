using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmitaPayNet.API.Migrations
{
    /// <inheritdoc />
    public partial class deleteAttributePayCurrency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentCurrency",
                table: "PaymentLetters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentCurrency",
                table: "PaymentLetters",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
