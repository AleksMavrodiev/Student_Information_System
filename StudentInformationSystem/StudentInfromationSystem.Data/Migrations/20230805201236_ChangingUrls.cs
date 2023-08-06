using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class ChangingUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3d1478-b7fc-494d-b828-eedd70da0845", "AQAAAAEAACcQAAAAENK+BKsbUxyAZUgbl095oMVrBoSbsPSjjPLMFTq363623IpgL68/Gvr8DbyYDHpbDA==", "6cdb90bc-d946-4aa4-bba3-d59e001e5096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72c82f7e-a51c-4b04-8355-07c1111ac36d", "AQAAAAEAACcQAAAAEFflJs+9IVuosThwOZHQhGqwuaxc4Pc9TYk4t60BvbfTuHdCffRuAMNUGpsQ+L2vMA==", "56c418f4-6582-4174-ba9b-07304291cfd6" });

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.fmi.uni-sofia.bg/sites/default/files/fmi.jpg");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/d/db/FEBA-SPRING.jpg");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://law.uni-sofia.bg/sites/default/files/2019-09/429_2.jpg");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://fdiba.tu-sofia.bg/wp-content/uploads/2022/02/Building-10B-1.jpg");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://phls.uni-sofia.bg/documents/articles/111/colliseum-4.jpg");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.tu-college.com/wp-content/uploads/2020/06/cropped-tu.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "ImageUrl",
                value: "https://www.uni-sofia.bg/images/stories/faculties/fmi/fmi_logo.png");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.uni-sofia.bg/images/stories/faculties/ikonomika/ikonomika_logo.png");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.uni-sofia.bg/images/stories/faculties/pravo/pravo_logo.png");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.uni-sofia.bg/images/stories/faculties/german/german_logo.png");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.uni-sofia.bg/images/stories/faculties/filosofski/filosofski_logo.png");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.uni-sofia.bg/images/stories/faculties/fksu/fksu_logo.png");
        }
    }
}
