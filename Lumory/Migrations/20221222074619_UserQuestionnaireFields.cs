using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumory.Migrations
{
    public partial class UserQuestionnaireFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestionnaires_Users_UserId",
                table: "UserQuestionnaires");

            migrationBuilder.DropIndex(
                name: "IX_UserQuestionnaires_UserId",
                table: "UserQuestionnaires");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "UserQuestionnaires",
                newName: "Teamwork");

            migrationBuilder.AddColumn<float>(
                name: "AverageGrade",
                table: "UserQuestionnaires",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DateStart",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Days",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EducationalInstitution",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Hours",
                table: "UserQuestionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InternshipType",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Mentorship",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Problem",
                table: "UserQuestionnaires",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sector",
                table: "UserQuestionnaires",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SkillsToLearn",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StrongQualities",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StrongSkills",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Study",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StudyDirection",
                table: "UserQuestionnaires",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StudyNiveau",
                table: "UserQuestionnaires",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserQuestionnaires",
                type: "datetime(6)",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageGrade",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "EducationalInstitution",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "InternshipType",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "Mentorship",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "Problem",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "Sector",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "SkillsToLearn",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "StrongQualities",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "StrongSkills",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "Study",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "StudyDirection",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "StudyNiveau",
                table: "UserQuestionnaires");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "UserQuestionnaires");

            migrationBuilder.RenameColumn(
                name: "Teamwork",
                table: "UserQuestionnaires",
                newName: "Skills");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionnaires_UserId",
                table: "UserQuestionnaires",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestionnaires_Users_UserId",
                table: "UserQuestionnaires",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
