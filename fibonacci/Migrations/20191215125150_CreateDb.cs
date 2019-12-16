using Microsoft.EntityFrameworkCore.Migrations;

namespace fibonacci.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FibonacciNumbers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Previous = table.Column<int>(nullable: false),
                    Next = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FibonacciNumbers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FibonacciNumbers_Value",
                table: "FibonacciNumbers",
                column: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FibonacciNumbers");
        }
    }
}
