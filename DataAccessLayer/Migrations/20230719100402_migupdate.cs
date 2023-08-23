using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_AspNetUsers_UserAdminId1",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_UserAdminId1",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "UserAdminId1",
                table: "Adverts");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdminId",
                table: "Adverts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UserAdminId",
                table: "Adverts",
                column: "UserAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_AspNetUsers_UserAdminId",
                table: "Adverts",
                column: "UserAdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_AspNetUsers_UserAdminId",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_UserAdminId",
                table: "Adverts");

            migrationBuilder.AlterColumn<int>(
                name: "UserAdminId",
                table: "Adverts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserAdminId1",
                table: "Adverts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_UserAdminId1",
                table: "Adverts",
                column: "UserAdminId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_AspNetUsers_UserAdminId1",
                table: "Adverts",
                column: "UserAdminId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
