using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                   name: "Courses",
                   columns: table => new
                   {
                       Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                       Code = table.Column<string>(maxLength: 50, nullable: true),
                       TitleEng = table.Column<string>(maxLength: 1000, nullable: true),
                       TitleFre = table.Column<string>(maxLength: 1000, nullable: true),
                       DescEng = table.Column<string>(maxLength: 4000, nullable: true),
                       DescFre = table.Column<string>(maxLength: 4000, nullable: true),
                       LangEng = table.Column<string>(maxLength: 100, nullable: true),
                       LangFre = table.Column<string>(maxLength: 100, nullable: true),
                       Hours = table.Column<string>(maxLength: 30, nullable: true),
                       Active = table.Column<int>(nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_Courses", x => x.Id);
                   });

            migrationBuilder.CreateTable(
                   name: "Departments",
                   columns: table => new
                   {
                       Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                       NameEng = table.Column<string>(maxLength: 1000, nullable: true),
                       NameFre = table.Column<string>(maxLength: 1000, nullable: true),
                       Active = table.Column<int>(nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_Departments", x => x.Id);
                   });

            migrationBuilder.CreateTable(
                   name: "Disciplines",
                   columns: table => new
                   {
                       Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                       NameEng = table.Column<string>(maxLength: 1000, nullable: true),
                       NameFre = table.Column<string>(maxLength: 1000, nullable: true),
                       Active = table.Column<int>(nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_Disciplines", x => x.Id);
                   });

            migrationBuilder.CreateTable(
                   name: "CourseTypes",
                   columns: table => new
                   {
                       Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                       NameEng = table.Column<string>(maxLength: 1000, nullable: true),
                       NameFre = table.Column<string>(maxLength: 1000, nullable: true),
                       Active = table.Column<int>(nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_CourseTypes", x => x.Id);
                   });

            migrationBuilder.CreateTable(
                   name: "Programs",
                   columns: table => new
                   {
                       Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                       CodeEng = table.Column<string>(maxLength: 50, nullable: true),
                       CodeFre = table.Column<string>(maxLength: 50, nullable: true),
                       NameEng = table.Column<string>(maxLength: 1000, nullable: true),
                       NameFre = table.Column<string>(maxLength: 1000, nullable: true),
                       Active = table.Column<int>(nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_Programs", x => x.Id);
                   });

            migrationBuilder.CreateTable(
                   name: "YearLevels",
                   columns: table => new
                   {
                       Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                       LevelValue = table.Column<string>(maxLength: 50, nullable: false),
                       Active = table.Column<int>(nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_YearLevels", x => x.Id);
                   });
        }

        
    }
}
