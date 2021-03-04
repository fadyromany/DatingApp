using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Data.Migrations
{
    public partial class ExtendedUserEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Users_AppUserId",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Phostos");

            migrationBuilder.RenameColumn(
                name: "LookinfFor",
                table: "Users",
                newName: "LookingFor");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_AppUserId",
                table: "Phostos",
                newName: "IX_Phostos_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phostos",
                table: "Phostos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phostos_Users_AppUserId",
                table: "Phostos",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phostos_Users_AppUserId",
                table: "Phostos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phostos",
                table: "Phostos");

            migrationBuilder.RenameTable(
                name: "Phostos",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "Users",
                newName: "LookinfFor");

            migrationBuilder.RenameIndex(
                name: "IX_Phostos_AppUserId",
                table: "Photo",
                newName: "IX_Photo_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Users_AppUserId",
                table: "Photo",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
