using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafioMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class Npus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Npu",
                table: "Npu");

            migrationBuilder.RenameTable(
                name: "Npu",
                newName: "Npus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Npus",
                table: "Npus",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Npus",
                table: "Npus");

            migrationBuilder.RenameTable(
                name: "Npus",
                newName: "Npu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Npu",
                table: "Npu",
                column: "id");
        }
    }
}
