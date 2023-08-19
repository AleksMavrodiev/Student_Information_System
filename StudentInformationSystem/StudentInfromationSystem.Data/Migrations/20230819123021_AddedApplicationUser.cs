using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddedApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "261cb3a2-f43b-4032-8f5c-98504c266684");

            migrationBuilder.DropColumn(
                name: "EGN",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "EGN",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PasswordRequiredChange",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "EGN", "FirstName", "LastName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f102e8fa-d383-448c-a61b-5d970f855fe4", "1234567890", "Aleksandar", "Aleksandrov", "AQAAAAEAACcQAAAAEHzPP/XUW+WV/n8//kGqsaIgOjBqH/3dmS8tGo9Ac4gz+7MuLqhSxlwled0qcgaqOg==", true, "0888123456", "6724129b-7d70-41b4-ad35-29e1945cc192" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "85b57b7c2aac4db78a70dd2ff901b895", 0, "3a1e7bf3-b300-4891-b566-b34fa2155b5b", "1234567890", "ivan.ivanov@abv.bg", false, "Ivan", "Ivanov", false, null, "ivan.ivanov@abv.bg", null, "AQAAAAEAACcQAAAAEIglneuDtY8BbCrVIiErjh0yUWvHRrIQNBMHdy0DbNPGBnzn8PySCfFg0qxufDHLQw==", true, "0888123456", false, null, "d3e40062-3f45-408a-93fd-a813a2fb0fc8", false, "ivan.ivanov@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c7f8f65d-9c38-44e1-87fc-1631b282cb0a", 0, "21c5bb70-4e6d-4c4f-a61f-47175da26e10", "1234567890", "admin@mail.com", false, "Admin", "Adminov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEAbtG6kOB0B/U5fKKmonju7DozT4+DHPGQk6eLhL7YMzluLSwwfQWX2IykYMhOu3tg==", false, "0888123456", false, null, "0fd572ce-75a2-41a8-bed3-61bb4ab6a8fa", false, "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                column: "UserId",
                value: "85b57b7c2aac4db78a70dd2ff901b895");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85b57b7c2aac4db78a70dd2ff901b895");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7f8f65d-9c38-44e1-87fc-1631b282cb0a");

            migrationBuilder.DropColumn(
                name: "EGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordRequiredChange",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "EGN",
                table: "Teachers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Teachers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Teachers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EGN",
                table: "Students",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Students",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "613cce4c-e25c-479c-97ee-a2173291a2ec", "AQAAAAEAACcQAAAAELeTEgKu8SMmSpBUvm5o0Rq7g1bRjmvVBgkh7m2F/YLTBulNYxxKW6OOZAXDmE8MNg==", null, "24af28aa-ee40-4b82-a993-f8d4459f1fa0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20661c81-53ef-45dd-ab1c-0c5aee24c90d", 0, "283ae6fc-848c-43d7-851e-3fa66d9868f5", "teacher@abv.bg", false, false, null, "teacher@abv.bg", null, "AQAAAAEAACcQAAAAEORjU99Hfga4OF6ooonqe+4lIND8ykylL3531xwsQSAlf7NIMf/7Y9pSGGL39KcEOQ==", null, false, "e5609ebf-bf82-40b7-82ea-0c8e42fddf63", false, "teacher@abv.bg" },
                    { "261cb3a2-f43b-4032-8f5c-98504c266684", 0, "f645ffdc-332b-43d4-a365-a4bcd4bc8570", "admin@mail.com", false, false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEN0TRLotAlItK3a3A35oDbTZyUs3ge6EZc4xlBzIk2CqfAKEXbGreNhCii7pgrgdwg==", null, false, "62dc6671-40dc-4ab8-b1f1-bf823fef0145", false, "admin@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                columns: new[] { "EGN", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "1234567890", "student@university.com", "Ivan", "Ivanov", "0888123456" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                columns: new[] { "EGN", "Email", "FirstName", "LastName", "PhoneNumber", "UserId" },
                values: new object[] { "1234567890", "teacher@abv.bg", "Ivan", "Ivanov", "0888123456", "20661c81-53ef-45dd-ab1c-0c5aee24c90d" });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
