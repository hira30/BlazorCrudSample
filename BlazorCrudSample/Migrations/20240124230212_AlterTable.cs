using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCrudSample.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublihedYear",
                table: "Books",
                newName: "PublishedYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishedYear",
                table: "Books",
                newName: "PublihedYear");
        }
    }
}
