using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmitaPayNet.API.Migrations
{
    /// <inheritdoc />
    public partial class rol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56979d03-2587-49f5-ad6a-b58a8e552da7", null, "Empleado", "EMPLEADO" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56979d03-2587-49f5-ad6a-b58a8e552da7");
        }
    }
}
