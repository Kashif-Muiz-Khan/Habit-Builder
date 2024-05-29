using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALevelBlazorTemplate.Migrations
{
    /// <inheritdoc />
    public partial class Habit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Habits",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Habits",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Habits");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Habits");
        }
    }
}
