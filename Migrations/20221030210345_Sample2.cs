using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class Sample2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyBoolean",
                table: "Samples");

            migrationBuilder.RenameColumn(
                name: "MyDecimal",
                table: "Samples",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "MyDateTime",
                table: "Samples",
                newName: "CreatedTimestamp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Samples",
                newName: "MyDecimal");

            migrationBuilder.RenameColumn(
                name: "CreatedTimestamp",
                table: "Samples",
                newName: "MyDateTime");

            migrationBuilder.AddColumn<bool>(
                name: "MyBoolean",
                table: "Samples",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
