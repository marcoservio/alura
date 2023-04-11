using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "8c1ed3f8-5c2e-4bc8-85ea-a27ff8afe2be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "301075cb-81ba-4fb7-93d9-dd97955fb456", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2193fd47-f00f-48f7-a2b3-c71a87889cda", "AQAAAAEAACcQAAAAEBw0fZH4XPnugrb0nqgKM8Iqw5ahSfIP9xkmSwS4HZZ+3PeTvHiUDmiK60EwKzpYLw==", "cc888701-59e4-405a-885b-10105de1b8e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "014c15d5-8c34-444a-8660-eee492af5191");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec8cab24-b353-4a51-a292-850d8c9ac26b", "AQAAAAEAACcQAAAAEMMitJ7GgicwCmwrwRIx7HeEG08zymR/1401FVjd4arxrtS6hCfUJIPajnqfukZWDg==", "db745c21-e224-47e9-bfb1-8ce73bbf3384" });
        }
    }
}
