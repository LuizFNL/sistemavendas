using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class AddUrlImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URLImagemItem",
                table: "Itens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URLImagemItem",
                table: "Itens");
        }
    }
}
