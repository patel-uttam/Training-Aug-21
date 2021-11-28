using Microsoft.EntityFrameworkCore.Migrations;

namespace Day17Assignment.Migrations.HospitalDB
{
    public partial class ThirdMigration_storeprocedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 /*           migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Department_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Department_Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Drug_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drug_Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Drug_Price = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((50))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Drug_Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Patient_Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patient_Id);
                });

            migrationBuilder.CreateTable(
                name: "Assistants",
                columns: table => new
                {
                    Assistant_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assistant_Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Department = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistants", x => x.Assistant_Id);
                    table.ForeignKey(
                        name: "FK_Assistant_department_id",
                        column: x => x.Department,
                        principalTable: "Departments",
                        principalColumn: "Department_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Department = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Doctor_Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Department_id",
                        column: x => x.Department,
                        principalTable: "Departments",
                        principalColumn: "Department_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drug_time",
                columns: table => new
                {
                    Patient = table.Column<int>(type: "int", nullable: true),
                    Drug = table.Column<int>(type: "int", nullable: true),
                    Morning = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    Afternoon = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    Evening = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Drug_time_drug_id",
                        column: x => x.Drug,
                        principalTable: "Drugs",
                        principalColumn: "Drug_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drug_time_patient_id",
                        column: x => x.Patient,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Patient = table.Column<int>(type: "int", nullable: true),
                    Doctor = table.Column<int>(type: "int", nullable: true),
                    Assistant1 = table.Column<int>(type: "int", nullable: true),
                    Assistant2 = table.Column<int>(type: "int", nullable: true),
                    Illness = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Treatment = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Treatment_assistant1_Id",
                        column: x => x.Assistant1,
                        principalTable: "Assistants",
                        principalColumn: "Assistant_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatment_assistant2_Id",
                        column: x => x.Assistant2,
                        principalTable: "Assistants",
                        principalColumn: "Assistant_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatment_doctor_id",
                        column: x => x.Doctor,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatment_patient_id",
                        column: x => x.Patient,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assistants_Department",
                table: "Assistants",
                column: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Department",
                table: "Doctors",
                column: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_time_Drug",
                table: "Drug_time",
                column: "Drug");

            migrationBuilder.CreateIndex(
                name: "IX_Drug_time_Patient",
                table: "Drug_time",
                column: "Patient");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Assistant1",
                table: "Treatments",
                column: "Assistant1");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Assistant2",
                table: "Treatments",
                column: "Assistant2");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Doctor",
                table: "Treatments",
                column: "Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Patient",
                table: "Treatments",
                column: "Patient");*/

            string doctor_to_patient = @"CREATE PROCEDURE Display_doctor_assign_to_patient 
                                            @doctor varchar(max)
                                            AS
                                            BEGIN
                                            SELECT d.Doctor_Name , p.Patient_Name FROM Treatments as t
                                            JOIN Doctors as d
                                            ON t.Doctor = d.Doctor_Id
                                            JOIN Patients as p
                                            ON t.Patient = p.Patient_Id
                                            WHERE d.Doctor_Name = @doctor
                                            END";
            migrationBuilder.Sql(doctor_to_patient);

            string patient_medicine = @"CREATE PROCEDURE Patient_medicine_list
                                        @patient varchar(max)
                                        AS
                                        BEGIN
                                        SELECT p.Patient_Name , d.Drug_Name FROM Drug_time as dt
                                        JOIN Patients as p
                                        ON p.Patient_Id = dt.Patient
                                        JOIN Drugs as d
                                        ON dt.Drug = d.Drug_Id
                                        WHERE p.Patient_Name = @patient
                                        END";
            migrationBuilder.Sql(patient_medicine);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        /*    migrationBuilder.DropTable(
                name: "Drug_time");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Assistants");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Departments");*/
            string doctor_to_patient = @"DROP PROCEDURE Display_doctor_assign_to_patient 
                                            @doctor varchar(max)
                                            AS
                                            BEGIN
                                            SELECT d.Doctor_Name , p.Patient_Name FROM Treatments as t
                                            JOIN Doctors as d
                                            ON t.Doctor = d.Doctor_Id
                                            JOIN Patients as p
                                            ON t.Patient = p.Patient_Id
                                            WHERE d.Doctor_Name = @doctor
                                            END";
            migrationBuilder.Sql(doctor_to_patient);

            string patient_medicine = @"DROP PROCEDURE Patient_medicine_list
                                        @patient varchar(max)
                                        AS
                                        BEGIN
                                        SELECT p.Patient_Name , d.Drug_Name FROM Drug_time as dt
                                        JOIN Patients as p
                                        ON p.Patient_Id = dt.Patient
                                        JOIN Drugs as d
                                        ON dt.Drug = d.Drug_Id
                                        WHERE p.Patient_Name = @patient
                                        END";
            migrationBuilder.Sql(patient_medicine);
        }
    }
}
