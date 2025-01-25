using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wipro_API_EmployeeService_Ex2.Migrations
{
    /// <inheritdoc />
    public partial class Phase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpAge = table.Column<int>(type: "int", nullable: false),
                    EmpEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpQualification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
