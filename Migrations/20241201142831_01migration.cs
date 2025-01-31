using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolicyCustomerService.Migrations
{
    /// <inheritdoc />
    public partial class _01migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Insurance",
                table: "Insurance");

            migrationBuilder.RenameTable(
                name: "Insurance",
                newName: "Insurances");

            migrationBuilder.AlterColumn<string>(
                name: "SessionId",
                table: "Insurances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverageTypes",
                table: "Insurances",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Insurances",
                table: "Insurances",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Insurances",
                table: "Insurances");

            migrationBuilder.RenameTable(
                name: "Insurances",
                newName: "Insurance");

            migrationBuilder.AlterColumn<string>(
                name: "SessionId",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverageTypes",
                table: "Insurance",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Insurance",
                table: "Insurance",
                column: "Id");
        }
    }
}
