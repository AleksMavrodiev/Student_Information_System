using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddedPasswordsToSeededUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fe00ca87-1230-491f-ae93-e28a3d62720f"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e1ad3aa4-7f5a-423d-aaa1-5e3d5b78da17", null, "bc033a32-17b3-4d48-9396-a9ac23b3c0a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb5157e-c923-486b-84de-2130f08454f2", null, "219ed87d-334b-4ba5-97b0-187cb9a38625" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EGN", "Email", "FacultyNumber", "FirstName", "IsActive", "IsForeign", "LastName", "PhoneNumber", "SpecialtyId", "UserId" },
                values: new object[] { new Guid("fe00ca87-1230-491f-ae93-e28a3d62720f"), "1234567890", "student@university.com", "123456789", "Ivan", true, false, "Ivanov", "0888123456", 1, "47af10f2-ef33-4637-a18f-40c27c56acb7" });
        }
    }
}
