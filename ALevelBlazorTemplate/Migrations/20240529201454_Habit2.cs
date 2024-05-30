using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALevelBlazorTemplate.Migrations
{
    /// <inheritdoc />
    public partial class Habit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSelected",
                table: "Habits",
                newName: "IsChecked");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "Habits",
                newName: "IsSelected");
        }
    }
}
