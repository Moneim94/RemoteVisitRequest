using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Order.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNotifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Country_CountryId",
                table: "UserInfo");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_CountryId",
                table: "UserInfo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_CountryId",
                table: "UserInfo",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Country_CountryId",
                table: "UserInfo",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
