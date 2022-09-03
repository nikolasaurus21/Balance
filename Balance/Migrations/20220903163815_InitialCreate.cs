using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Balance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoneyBalances",
                columns: table => new
                {
                    Id = table.Column<double>(type: "double precision", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Balance = table.Column<double>(type: "double precision", nullable: false),
                    SavedAmount = table.Column<double>(type: "double precision", nullable: false),
                    Expenses = table.Column<double>(type: "double precision", nullable: false),
                    Salary = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyBalances", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneyBalances");
        }
    }
}
