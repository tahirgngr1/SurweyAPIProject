using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Surweys_surweyId",
                table: "Option");

            migrationBuilder.RenameColumn(
                name: "surweyId",
                table: "Option",
                newName: "survey_id");

            migrationBuilder.RenameIndex(
                name: "IX_Option_surweyId",
                table: "Option",
                newName: "IX_Option_survey_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Surweys_survey_id",
                table: "Option",
                column: "survey_id",
                principalTable: "Surweys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Surweys_survey_id",
                table: "Option");

            migrationBuilder.RenameColumn(
                name: "survey_id",
                table: "Option",
                newName: "surweyId");

            migrationBuilder.RenameIndex(
                name: "IX_Option_survey_id",
                table: "Option",
                newName: "IX_Option_surweyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Surweys_surweyId",
                table: "Option",
                column: "surweyId",
                principalTable: "Surweys",
                principalColumn: "Id");
        }
    }
}
