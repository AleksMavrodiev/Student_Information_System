using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class ConfiguringMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("93023d3d-629f-4c90-9dd4-e4b25e2921da"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26f04b54-0243-443c-824d-573e1d739d71", "AQAAAAEAACcQAAAAEKwcPlcivrqzSqP63hAPNCKb3xV44/47aam6vMLvHK7OFzdHu32ZtYgpikxFXn2jIQ==", "8f103e25-31ce-46f5-a33a-db4bb86f9488" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf09da4c-cd88-4785-ac6f-a3a053d6c55b", "AQAAAAEAACcQAAAAEFaQLBlmQ3KG8bl4ITA3NPicZVvs9G/to2rEWf6Ggin9zME3rV6DxGMx7WOs8TQJXg==", "79a61458-0eec-449e-969e-cc6ba9186720" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EGN", "Email", "FacultyNumber", "FirstName", "IsActive", "IsForeign", "LastName", "PhoneNumber", "SpecialtyId", "UserId" },
                values: new object[] { new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"), "1234567890", "student@university.com", "123456789", "Ivan", true, false, "Ivanov", "0888123456", 1, "47af10f2-ef33-4637-a18f-40c27c56acb7" });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId", "Grade" },
                values: new object[] { 1, new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"), 0.0 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId", "Grade" },
                values: new object[] { 2, new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"), 0.0 });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId", "Grade" },
                values: new object[] { 3, new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"), 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d80e7c2-7861-4761-875c-12a03f87a0de", "AQAAAAEAACcQAAAAEE+3pJq+zFMIx+NlUT2UVHwPRNZ187yv4+CnGnR6M8TLMAGNE4dYRkqKKsDxJ0jc9A==", "d8686444-0816-40f8-9f04-fa90f30856a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0079c2f5-2b47-49b8-84b9-f9fea1f0fe41", "AQAAAAEAACcQAAAAEEL6VPWdSOGurc+x4jVCbPRzDxgc8J+U0Glk2FNa6lr//7s8GaEg6YRXWftuhMf6PA==", "3bd233f2-8606-40e1-88d9-5f8eb23839b2" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EGN", "Email", "FacultyNumber", "FirstName", "IsActive", "IsForeign", "LastName", "PhoneNumber", "SpecialtyId", "UserId" },
                values: new object[] { new Guid("93023d3d-629f-4c90-9dd4-e4b25e2921da"), "1234567890", "student@university.com", "123456789", "Ivan", true, false, "Ivanov", "0888123456", 1, "47af10f2-ef33-4637-a18f-40c27c56acb7" });
        }
    }
}
