using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Data.Migrations
{
    public partial class ExtendedUserEntityUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phostos_Users_AppUserId",
                table: "Phostos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phostos",
                table: "Phostos");

            migrationBuilder.RenameTable(
                name: "Phostos",
                newName: "Photos");

            migrationBuilder.RenameIndex(
                name: "IX_Phostos_AppUserId",
                table: "Photos",
                newName: "IX_Photos_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_AppUserId",
                table: "Photos",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_AppUserId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Phostos");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_AppUserId",
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
    }
}
