using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddingProfilePicturePropertiesToTeacherAndStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Teachers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Students",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bab98f03-db9b-42c7-88f8-ade873c56298", "AQAAAAEAACcQAAAAEJyaiblodBlAEm06RoNLrkx0lpA0WdMSEknb9yjTgAP+CRpXyzau99lc5cgZmLyjVg==", "483a145d-0de3-458c-a824-b57eeb69a62e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3db2a5a0-58b1-4e40-ad37-9a8e43fc61be", "AQAAAAEAACcQAAAAEJ4ZaTE3Vc4YFaLXHJQwriXbc5YJV2FDh/YZL3On/mys63d819YShIyGzZm+cHJR4A==", "8444882d-671f-4c0b-ba04-09bee6ae6585" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3d1478-b7fc-494d-b828-eedd70da0845", "AQAAAAEAACcQAAAAENK+BKsbUxyAZUgbl095oMVrBoSbsPSjjPLMFTq363623IpgL68/Gvr8DbyYDHpbDA==", "6cdb90bc-d946-4aa4-bba3-d59e001e5096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72c82f7e-a51c-4b04-8355-07c1111ac36d", "AQAAAAEAACcQAAAAEFflJs+9IVuosThwOZHQhGqwuaxc4Pc9TYk4t60BvbfTuHdCffRuAMNUGpsQ+L2vMA==", "56c418f4-6582-4174-ba9b-07304291cfd6" });
        }
    }
}
