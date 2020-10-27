using Microsoft.EntityFrameworkCore.Migrations;

namespace TRMR.Data.Migrations
{
    public partial class MID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movies_Movie",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_User",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_User",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Review",
                newName: "User_Name");

            migrationBuilder.RenameColumn(
                name: "Movie",
                table: "Review",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_Movie",
                table: "Review",
                newName: "IX_Review_MovieId");

            migrationBuilder.AddColumn<int>(
                name: "Movie_Id",
                table: "Review",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "User_Id1",
                table: "Review",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_User_Id1",
                table: "Review",
                column: "User_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movies_MovieId",
                table: "Review",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_User_Id1",
                table: "Review",
                column: "User_Id1",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movies_MovieId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_User_Id1",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_User_Id1",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Movie_Id",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "User_Id1",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "User_Name",
                table: "Review",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Review",
                newName: "Movie");

            migrationBuilder.RenameIndex(
                name: "IX_Review_MovieId",
                table: "Review",
                newName: "IX_Review_Movie");

            migrationBuilder.CreateIndex(
                name: "IX_Review_User",
                table: "Review",
                column: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movies_Movie",
                table: "Review",
                column: "Movie",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_User",
                table: "Review",
                column: "User",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
