using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace StarDentApi.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accesstokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Uuid = table.Column<string>(type: "longtext", nullable: false),
                    Userid = table.Column<string>(type: "longtext", nullable: false),
                    Accesstoken = table.Column<string>(type: "longtext", nullable: false),
                    Refreshtoken = table.Column<string>(type: "longtext", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Createtime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesstokens", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roleprivileges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleID = table.Column<string>(type: "longtext", nullable: false),
                    Privilege = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roleprivileges", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Uuid = table.Column<string>(type: "longtext", nullable: false),
                    Createtime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updatetime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deletetime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Createduser = table.Column<string>(type: "longtext", nullable: false),
                    Updateduser = table.Column<string>(type: "longtext", nullable: false),
                    Deleteduser = table.Column<string>(type: "longtext", nullable: false),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tablemetaconfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<string>(type: "longtext", nullable: false),
                    Meta = table.Column<string>(type: "longtext", nullable: false),
                    Config = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablemetaconfigs", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Surname = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Phonenumber = table.Column<string>(type: "longtext", nullable: false),
                    Passwordhash = table.Column<string>(type: "longtext", nullable: false),
                    Passwordsalt = table.Column<string>(type: "longtext", nullable: false),
                    Config = table.Column<string>(type: "longtext", nullable: false),
                    Accessfailcount = table.Column<int>(type: "int", nullable: false),
                    Uuid = table.Column<string>(type: "longtext", nullable: false),
                    Createtime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updatetime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deletetime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Createduser = table.Column<string>(type: "longtext", nullable: false),
                    Updateduser = table.Column<string>(type: "longtext", nullable: false),
                    Deleteduser = table.Column<string>(type: "longtext", nullable: false),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accesstokens");

            migrationBuilder.DropTable(
                name: "Roleprivileges");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Tablemetaconfigs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
