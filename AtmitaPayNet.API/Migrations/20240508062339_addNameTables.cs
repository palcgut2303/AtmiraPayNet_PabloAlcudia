using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmitaPayNet.API.Migrations
{
    /// <inheritdoc />
    public partial class addNameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccount_Bank_BankId",
                table: "BankAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLetters_BankAccount_DestinationBankId",
                table: "PaymentLetters");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLetters_BankAccount_InterBankId",
                table: "PaymentLetters");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLetters_BankAccount_OriginBankId",
                table: "PaymentLetters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankAccount",
                table: "BankAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bank",
                table: "Bank");

            migrationBuilder.RenameTable(
                name: "BankAccount",
                newName: "BankAccounts");

            migrationBuilder.RenameTable(
                name: "Bank",
                newName: "Banks");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccount_BankId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankAccounts",
                table: "BankAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banks",
                table: "Banks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Banks_BankId",
                table: "BankAccounts",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLetters_BankAccounts_DestinationBankId",
                table: "PaymentLetters",
                column: "DestinationBankId",
                principalTable: "BankAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLetters_BankAccounts_InterBankId",
                table: "PaymentLetters",
                column: "InterBankId",
                principalTable: "BankAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLetters_BankAccounts_OriginBankId",
                table: "PaymentLetters",
                column: "OriginBankId",
                principalTable: "BankAccounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Banks_BankId",
                table: "BankAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLetters_BankAccounts_DestinationBankId",
                table: "PaymentLetters");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLetters_BankAccounts_InterBankId",
                table: "PaymentLetters");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLetters_BankAccounts_OriginBankId",
                table: "PaymentLetters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banks",
                table: "Banks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankAccounts",
                table: "BankAccounts");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Bank");

            migrationBuilder.RenameTable(
                name: "BankAccounts",
                newName: "BankAccount");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccount",
                newName: "IX_BankAccount_BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bank",
                table: "Bank",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankAccount",
                table: "BankAccount",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccount_Bank_BankId",
                table: "BankAccount",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLetters_BankAccount_DestinationBankId",
                table: "PaymentLetters",
                column: "DestinationBankId",
                principalTable: "BankAccount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLetters_BankAccount_InterBankId",
                table: "PaymentLetters",
                column: "InterBankId",
                principalTable: "BankAccount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLetters_BankAccount_OriginBankId",
                table: "PaymentLetters",
                column: "OriginBankId",
                principalTable: "BankAccount",
                principalColumn: "Id");
        }
    }
}
