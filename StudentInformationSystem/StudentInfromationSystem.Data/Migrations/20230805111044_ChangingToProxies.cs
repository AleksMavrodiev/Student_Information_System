using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class ChangingToProxies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
