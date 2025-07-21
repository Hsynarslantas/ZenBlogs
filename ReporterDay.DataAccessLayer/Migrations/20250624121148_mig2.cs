using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReporterDay.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticalId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticalId",
                table: "Comments",
                column: "ArticalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Articals_ArticalId",
                table: "Comments",
                column: "ArticalId",
                principalTable: "Articals",
                principalColumn: "ArticalId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Articals_ArticalId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ArticalId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ArticalId",
                table: "Comments");
        }
    }
}
