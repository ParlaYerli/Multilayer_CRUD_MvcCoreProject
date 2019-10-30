using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class assdff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    SchoolNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "Name", "SchoolNumber", "Surname" },
                values: new object[] { 1, 15, "Azra", 222, "Yerli" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "Name", "SchoolNumber", "Surname" },
                values: new object[] { 2, 23, "Hazal", 333, "Yerli" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "Name", "SchoolNumber", "Surname" },
                values: new object[] { 3, 26, "Parla", 444, "Yerli" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
