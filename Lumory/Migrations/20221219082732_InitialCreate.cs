﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumory.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Website = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StreetAddress = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true, defaultValueSql: "CURRENT_TIMESTAMP(6)"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true, defaultValueSql: "CURRENT_TIMESTAMP(6)"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
            
            migrationBuilder.CreateTable(
                    name: "UserQuestionnaire",
                    columns: table => new
                    {
                        Id = table.Column<int>(type: "int", nullable: false)
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                        FirstName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        LastName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Email = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        Password = table.Column<string>(type: "longtext", nullable: false)
                            .Annotation("MySql:CharSet", "utf8mb4"),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true, defaultValueSql: "CURRENT_TIMESTAMP(6)"),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Users", x => x.Id);
                    })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Users");
            
            migrationBuilder.DropTable(
                name: "UserQuestionnaire");
            
        }
    }
}