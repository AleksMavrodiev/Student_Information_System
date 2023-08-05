using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Start",
                table: "Courses",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "End",
                table: "Courses",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20661c81-53ef-45dd-ab1c-0c5aee24c90d", 0, "e1ad3aa4-7f5a-423d-aaa1-5e3d5b78da17", "teacher@abv.bg", false, false, null, "teacher@abv.bg", null, null, null, false, "bc033a32-17b3-4d48-9396-a9ac23b3c0a2", false, "teacher@abv.bg" },
                    { "47af10f2-ef33-4637-a18f-40c27c56acb7", 0, "bcb5157e-c923-486b-84de-2130f08454f2", "student@university.com", false, false, null, "student@university.com", "student@university.com", null, null, false, "219ed87d-334b-4ba5-97b0-187cb9a38625", false, "student@university.com" }
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "Address", "Name", "PostCode" },
                values: new object[,]
                {
                    { 1, "8 Kliment Ohridski Blvd., 1000 Sofia, Bulgaria", "Technical University of Sofia", "1257" },
                    { 2, "15 Tsar Osvoboditel Blvd., 1504 Sofia, Bulgaria", "Sofia University St. Kliment Ohridski", "1257" },
                    { 3, "8 Kliment Ohridski Blvd., 1000 Sofia, Bulgaria", "University of National and World Economy", "1257" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Name", "UniversityId" },
                values: new object[,]
                {
                    { 1, "Faculty of Mathematics and Informatics", 1 },
                    { 2, "Faculty of Economics and Business Administration", 2 },
                    { 3, "Faculty of Law", 3 },
                    { 4, "Faculty of German Engineering", 1 },
                    { 5, "Faculty of Philosophy", 2 },
                    { 6, "Faculty of Computer Systems and Control", 1 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "EGN", "Email", "FirstName", "LastName", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d"), "1234567890", "teacher@abv.bg", "Ivan", "Ivanov", "0888123456", "20661c81-53ef-45dd-ab1c-0c5aee24c90d" });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Computer Science" },
                    { 2, 1, "Software Engineering" },
                    { 3, 2, "Business Administration" },
                    { 4, 3, "Law" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Description", "End", "LectureRoom", "Name", "SpecialtyId", "Start", "TeacherId" },
                values: new object[,]
                {
                    { 1, 6, "Mathematics is the study of numbers, shapes and patterns. The word comes from the Greek word (mathema), meaning science, knowledge, or learning, and is sometimes shortened to maths (in England, Australia, Ireland, and New Zealand) or math (in the United States and Canada).", new TimeSpan(0, 11, 30, 0, 0), 101, "Mathematics", 1, new TimeSpan(0, 10, 0, 0, 0), new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d") },
                    { 2, 10, "An algorithm is a set of instructions designed to perform a specific task. This can be a simple process, such as multiplying two numbers, or a complex operation, such as playing a compressed video file. Search engines use proprietary algorithms to display the most relevant results from their search index for specific queries.", new TimeSpan(0, 13, 30, 0, 0), 102, "Algorithms and Data Structures", 1, new TimeSpan(0, 12, 0, 0, 0), new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d") },
                    { 3, 8, "Object-oriented programming (OOP) is a programming paradigm based on the concept of \"objects\", which can contain data and code: data in the form of fields (often known as attributes or properties), and code, in the form of procedures (often known as methods).", new TimeSpan(0, 15, 30, 0, 0), 103, "Object-Oriented Programming", 1, new TimeSpan(0, 14, 0, 0, 0), new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d") },
                    { 4, 8, "Software engineering is the systematic application of engineering approaches to the development of software. Software engineering is a computing discipline.", new TimeSpan(0, 17, 30, 0, 0), 104, "Software Engineering", 2, new TimeSpan(0, 16, 0, 0, 0), new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d") },
                    { 5, 8, "Business administration is the process of managing a business or non-profit organization so that it remains stable and continues to grow. This consists of a number of areas, ranging from operations to management.", new TimeSpan(0, 11, 30, 0, 0), 201, "Business Administration", 3, new TimeSpan(0, 10, 0, 0, 0), new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d") },
                    { 6, 8, "Law is a system of rules created and enforced through social or governmental institutions to regulate behavior, with its precise definition a matter of longstanding debate. It has been variously described as a science and the art of justice.", new TimeSpan(0, 13, 30, 0, 0), 202, "Law", 4, new TimeSpan(0, 12, 0, 0, 0), new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EGN", "Email", "FacultyNumber", "FirstName", "IsActive", "IsForeign", "LastName", "PhoneNumber", "SpecialtyId", "UserId" },
                values: new object[] { new Guid("fe00ca87-1230-491f-ae93-e28a3d62720f"), "1234567890", "student@university.com", "123456789", "Ivan", true, false, "Ivanov", "0888123456", 1, "47af10f2-ef33-4637-a18f-40c27c56acb7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fe00ca87-1230-491f-ae93-e28a3d62720f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7");

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);
        }
    }
}
