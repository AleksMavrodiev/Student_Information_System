using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AzureConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8fe80d5a-1065-47df-899f-812da655685d", "AQAAAAEAACcQAAAAEOgF8cBpIEPWok1xG/L8AN5PN+pfgszffTHpnE7QGsxLfxl3bkg29fYJuL4tpiuFOg==", "a68dc2d6-5358-4a0c-820f-78ef918501b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85b57b7c2aac4db78a70dd2ff901b895",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ada324a0-1a52-413b-800b-7d2bb1411bf1", "AQAAAAEAACcQAAAAEFe2q9zm61XewbnW2xu6pUZCTkfjRee9hmUJo9T25JeLTaLbIv8DEztRuOxXaQqV6Q==", "e1a963a8-5305-44fd-8e17-d947be157c5e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordRequiredChange", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df7a801b-6684-4e12-b6c0-24147028c2e8", 0, "bb641195-f201-41ac-b08f-46e9171c9aa6", "1234567890", "admin@mail.com", false, "Admin", "Adminov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEPAfqgCbLjjiHnBCxegS3UKdE4Eg1n2Pai/chkw7fJMH7/eFUsVZNHV5T0zJceuM3A==", false, "0888123456", false, null, "e86059d5-2d6a-472f-8cfa-2f4de962dc76", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7a801b-6684-4e12-b6c0-24147028c2e8");

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
    }
}
