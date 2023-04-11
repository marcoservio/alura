using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "8af037af-1712-4580-b281-91535dfd14c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "b8fce1b0-dc5e-4dfa-b52d-1bc4b51b02f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d0cb765-11d9-4824-99bd-d0f0e93f4ac7", "AQAAAAEAACcQAAAAEOlPO6DOvKIRxBLeWEKmyWHfMFS6w79P8NGGRftnUIpqwiNGKBR78nD0A/x37BLFsw==", "2c86009b-ce3c-4631-aeff-4caff99907d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "301075cb-81ba-4fb7-93d9-dd97955fb456");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "8c1ed3f8-5c2e-4bc8-85ea-a27ff8afe2be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2193fd47-f00f-48f7-a2b3-c71a87889cda", "AQAAAAEAACcQAAAAEBw0fZH4XPnugrb0nqgKM8Iqw5ahSfIP9xkmSwS4HZZ+3PeTvHiUDmiK60EwKzpYLw==", "cc888701-59e4-405a-885b-10105de1b8e4" });
        }
    }
}
