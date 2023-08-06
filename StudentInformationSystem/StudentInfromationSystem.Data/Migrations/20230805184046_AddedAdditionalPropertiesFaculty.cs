using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddedAdditionalPropertiesFaculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Faculties",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad6684f6-1c61-4777-a3c8-9c396d3bb9cc", "AQAAAAEAACcQAAAAEFTilUyj98YZKB8R/iEdhZfzg4K75lZ4Je87Ntz+9Ab0n5sTWJ3+UXJq7XG4oluOow==", "ae93c3a0-4b8d-4fb5-aa83-b5d7abb15701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d19585b-a4c2-4bc0-8608-a54a82cd9d5f", "AQAAAAEAACcQAAAAEMh31RN/+gxsj4pthbV24nkcc+6sWU3p+cHjh27XFtMObDxtfipLAeP9tQnBpQ3vuQ==", "8d2c5d81-9169-46e1-b42f-2a4de3a2d43b" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "The Faculty of Mathematics and Informatics is one of the largest faculties of Sofia University. It was founded in 1888. In 1963 the Faculty of Mathematics and Mechanics was divided into two separate faculties: the Faculty of Mathematics and the Faculty of Mechanics.", "https://www.uni-sofia.bg/images/stories/faculties/fmi/fmi_logo.png" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "The Faculty of Economics and Business Administration is the oldest and largest faculty of Sofia University. It was founded in 1905 as a Higher School of Commerce. In 1920 it was transformed into the Faculty of Commerce and Economics, and in 1940 it was renamed the Faculty of Economics.", "https://www.uni-sofia.bg/images/stories/faculties/ikonomika/ikonomika_logo.png" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "The Faculty of Law is the oldest faculty of Sofia University. It was founded in 1892 as a Higher School of Law. In 1904 it was transformed into the Faculty of Law.", "https://www.uni-sofia.bg/images/stories/faculties/pravo/pravo_logo.png" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "The Faculty of German Engineering was founded in 1941 as a Higher School of Mechanical and Electrical Engineering. In 1945 it was renamed the Higher School of Mechanical and Electrical Engineering in German. In 1947 it was transformed into the Faculty of German Engineering.", "https://www.uni-sofia.bg/images/stories/faculties/german/german_logo.png" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "The Faculty of Philosophy is the oldest faculty of Sofia University. It was founded in 1888 as a Higher School of Philosophy. In 1904 it was transformed into the Faculty of Philosophy.", "https://www.uni-sofia.bg/images/stories/faculties/filosofski/filosofski_logo.png" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "The Faculty of Computer Systems and Control was founded in 1963 as a Higher School of Computer Systems and Control. In 1963 it was transformed into the Faculty of Computer Systems and Control.", "https://www.uni-sofia.bg/images/stories/faculties/fksu/fksu_logo.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Faculties");

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
        }
    }
}
