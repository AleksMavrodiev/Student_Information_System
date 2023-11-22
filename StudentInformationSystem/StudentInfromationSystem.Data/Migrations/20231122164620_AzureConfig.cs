using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AzureConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "fc70eed6-440c-4313-8efd-9a9fd1b3e882", "AQAAAAEAACcQAAAAEFgkHlLxgyhr3v66IGzpxbKiKYr2KGA5p59NOIFst3jpb3qvqkT++gbVfmt0pxq1kA==", "1c2eec99-06b7-4030-8906-81f3e6b6759d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85b57b7c2aac4db78a70dd2ff901b895",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cccde19b-5238-4617-9595-08f74d7de7bf", "AQAAAAEAACcQAAAAEIN2Ksph2uk+mwI1IcOjw8uQxTOi2yH/k1z6SAcavNJY6tPQBKEQlFLyB5KjYNcvLw==", "6ab4bf62-1777-410e-ad88-4d601521f4aa" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eff57fdf-ca22-480b-85e1-982d1943adbf", 0, "8ea33f6f-daae-464b-ae7a-5f7ae247cd4c", "1234567890", "admin@mail.com", false, "Admin", "Adminov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEB6dAsyuSsBBJL/vQmDn0J/7KNnJuRcCFQf95Lbsk53YWSAsnkOSQWWy7+HnOzc5hQ==", false, "0888123456", false, null, "b1611a16-b467-4873-92ba-28967560d08a", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eff57fdf-ca22-480b-85e1-982d1943adbf");

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
    }
}
