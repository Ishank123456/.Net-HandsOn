using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wipro_OnionArchitecture_Ex2.Migrations
{
    /// <inheritdoc />
    public partial class Phase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpSal = table.Column<int>(type: "int", nullable: false),
                    EmpCity = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmpGender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DepartmentDeptId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentDeptId",
                        column: x => x.DepartmentDeptId,
                        principalTable: "Departments",
                        principalColumn: "DeptId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
