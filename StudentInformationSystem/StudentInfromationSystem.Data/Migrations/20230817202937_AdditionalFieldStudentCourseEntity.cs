using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AdditionalFieldStudentCourseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnrolled",
                table: "StudentCourses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c053d3b1-75de-4a2e-9018-7db0c4857ef7", "AQAAAAEAACcQAAAAEC2W8icFs3C39TVZBO4DPErjcvAhZWqd5dWGUjArJYq9dTzV9Y39E9stKpjzJAp2jg==", "6514c68e-a6e8-4b0b-ace7-8dd431a30a31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fed2db7-b6c3-4d61-b025-b6f1681ff3d7", "AQAAAAEAACcQAAAAEFmBjLYonYqxJMF+4HrNqihFop9k7QLB1TZV/24BdOFghyPmzGIciqe4KW2pJP484g==", "9a582b76-be0a-4e89-a8a5-408da30664a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnrolled",
                table: "StudentCourses");

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
    }
}
