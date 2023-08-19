using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    public partial class AddedAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283ae6fc-848c-43d7-851e-3fa66d9868f5", "AQAAAAEAACcQAAAAEORjU99Hfga4OF6ooonqe+4lIND8ykylL3531xwsQSAlf7NIMf/7Y9pSGGL39KcEOQ==", "e5609ebf-bf82-40b7-82ea-0c8e42fddf63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47af10f2-ef33-4637-a18f-40c27c56acb7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "613cce4c-e25c-479c-97ee-a2173291a2ec", "AQAAAAEAACcQAAAAELeTEgKu8SMmSpBUvm5o0Rq7g1bRjmvVBgkh7m2F/YLTBulNYxxKW6OOZAXDmE8MNg==", "24af28aa-ee40-4b82-a993-f8d4459f1fa0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "261cb3a2-f43b-4032-8f5c-98504c266684", 0, "f645ffdc-332b-43d4-a365-a4bcd4bc8570", "admin@mail.com", false, false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEN0TRLotAlItK3a3A35oDbTZyUs3ge6EZc4xlBzIk2CqfAKEXbGreNhCii7pgrgdwg==", null, false, "62dc6671-40dc-4ab8-b1f1-bf823fef0145", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "261cb3a2-f43b-4032-8f5c-98504c266684");

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
    }
}
