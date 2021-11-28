using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day15Assignment.API.Migrations
{
    public partial class FirstMigration_day15assignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipId = table.Column<long>(type: "bigint", nullable: false),
                    CitizenshipLegislationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrespondenceLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriversLicenseExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriversLicenseId = table.Column<long>(type: "bigint", nullable: false),
                    DriversLicenseIssuingCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeFaxAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxLegislationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneLegislationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Honors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalEntityId = table.Column<long>(type: "bigint", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryVetStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIdCountry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeeId);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionReasonCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualTerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignmentCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentProjectEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentStatusTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BuisnessUnitID = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DefualtExpenseAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    EffectiveEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullPartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeID = table.Column<long>(type: "bigint", nullable: false),
                    GradeLadderId = table.Column<long>(type: "bigint", nullable: false),
                    JobId = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalEntityID = table.Column<long>(type: "bigint", nullable: false),
                    LocationID = table.Column<long>(type: "bigint", nullable: false),
                    ManagerAssignmentId = table.Column<long>(type: "bigint", nullable: false),
                    ManagerID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                    table.ForeignKey(
                        name: "FK_Assignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_EmployeeId",
                table: "Assignments",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
