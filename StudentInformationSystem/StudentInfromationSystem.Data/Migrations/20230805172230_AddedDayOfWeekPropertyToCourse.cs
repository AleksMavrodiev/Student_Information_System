using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddedDayOfWeekPropertyToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "867cac39-9977-45ea-86a6-0cd04535ec30", "AQAAAAEAACcQAAAAEDA63n7bXBCA8k0uO4iJN3mGS7nGLE2WwOpbfbHu0c/emPTnoCxuH8EisJPdkDD9hA==", "6fb5e7a4-da27-4a7d-9070-fb68c9d7b821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d8f2c16-42ff-477e-ad0c-a7f887d70358", "AQAAAAEAACcQAAAAEA4xo3mESScgWxbuX/xYtvZoC0eSm/0eB45xCftZdw8J8Q88ViHn+gkt+itni1uZyg==", "f3dc7149-28b9-494e-8838-c92834988536" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DayOfWeek",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DayOfWeek",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DayOfWeek",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DayOfWeek",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DayOfWeek",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d614423c-b588-4757-82e9-ad46fafc136c", "AQAAAAEAACcQAAAAEAoRro4BsI82d73b9BJNCqkubKb0VSfhTC2ScvxCsIHlh0BBQrNe+RvjBuoOMXVb4g==", "7778bff9-f82e-40ef-8d23-57d3c41a8929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddf252d1-9aae-43c3-8582-88271510742f", "AQAAAAEAACcQAAAAEM6o1blz/V5AMvA8v7VGcJzQrdL7XzSkLxhsgbE8E9xf9KzAUwfdQh5SV2YNlcggRQ==", "e6cc0f11-1fed-4b38-8bd3-18dce382916e" });
        }
    }
}
