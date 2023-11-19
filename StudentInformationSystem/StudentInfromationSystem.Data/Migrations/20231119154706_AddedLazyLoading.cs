using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddedLazyLoading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7f8f65d-9c38-44e1-87fc-1631b282cb0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3560051f-858d-439f-a11a-9a2c02d3cede", "AQAAAAEAACcQAAAAECk6SpG/bYnBmIEFDLUET/2v5mIA2mjt6vpIl5RDBH9LYl4sUuvbmWfHr3v6R7Gzbg==", "083ed66e-1a68-4722-b51f-2db3cb7c0e59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85b57b7c2aac4db78a70dd2ff901b895",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "472a5ef4-f3da-4b1b-acbc-6877c0cb6b96", "AQAAAAEAACcQAAAAEMfl+SXzbF2i4I3brHo9h8am/NnaISZFanwWBCR948CEr/rxek4sCBz9Ki3C7ZNv2w==", "c2f9c366-f4c6-4934-9458-fdbe41921b40" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d54f7e6f-16ef-475a-9a3d-2557f4a24d4c", 0, "a15e53f7-3e0f-4253-88c1-19413022ae42", "1234567890", "admin@mail.com", false, "Admin", "Adminov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEJGzyPdjNsOpw/kkZ+a3oPvdwUIfP1mh8XCwt4MPew0ZF/5elAfjBk+dpDSnhp9t1g==", false, "0888123456", false, null, "ad856cc9-540c-4214-b2a5-62bb300982ff", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d54f7e6f-16ef-475a-9a3d-2557f4a24d4c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f102e8fa-d383-448c-a61b-5d970f855fe4", "AQAAAAEAACcQAAAAEHzPP/XUW+WV/n8//kGqsaIgOjBqH/3dmS8tGo9Ac4gz+7MuLqhSxlwled0qcgaqOg==", "6724129b-7d70-41b4-ad35-29e1945cc192" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85b57b7c2aac4db78a70dd2ff901b895",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1e7bf3-b300-4891-b566-b34fa2155b5b", "AQAAAAEAACcQAAAAEIglneuDtY8BbCrVIiErjh0yUWvHRrIQNBMHdy0DbNPGBnzn8PySCfFg0qxufDHLQw==", "d3e40062-3f45-408a-93fd-a813a2fb0fc8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c7f8f65d-9c38-44e1-87fc-1631b282cb0a", 0, "21c5bb70-4e6d-4c4f-a61f-47175da26e10", "1234567890", "admin@mail.com", false, "Admin", "Adminov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEAbtG6kOB0B/U5fKKmonju7DozT4+DHPGQk6eLhL7YMzluLSwwfQWX2IykYMhOu3tg==", false, "0888123456", false, null, "0fd572ce-75a2-41a8-bed3-61bb4ab6a8fa", false, "admin@mail.com" });
        }
    }
}
