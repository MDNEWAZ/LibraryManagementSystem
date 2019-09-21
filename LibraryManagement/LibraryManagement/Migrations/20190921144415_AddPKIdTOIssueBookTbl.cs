using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class AddPKIdTOIssueBookTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReturnBooks",
                table: "ReturnBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IssueBook",
                table: "IssueBook");

            migrationBuilder.AlterColumn<string>(
                name: "BookBarCode",
                table: "ReturnBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "IssueBook",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReturnBooks",
                table: "ReturnBooks",
                columns: new[] { "StudentId", "BookBarCode" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IssueBook",
                table: "IssueBook",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IssueBook_StudentId",
                table: "IssueBook",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReturnBooks",
                table: "ReturnBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IssueBook",
                table: "IssueBook");

            migrationBuilder.DropIndex(
                name: "IX_IssueBook_StudentId",
                table: "IssueBook");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IssueBook");

            migrationBuilder.AlterColumn<string>(
                name: "BookBarCode",
                table: "ReturnBooks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReturnBooks",
                table: "ReturnBooks",
                columns: new[] { "StudentId", "BookId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IssueBook",
                table: "IssueBook",
                columns: new[] { "StudentId", "bookId" });
        }
    }
}
