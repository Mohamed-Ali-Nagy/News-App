using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFlabDay2.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    St_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.St_id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    News_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    News_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    News_reff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    News_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    News_photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    News_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.News_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_password = table.Column<int>(type: "int", nullable: false),
                    User_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_age = table.Column<int>(type: "int", nullable: false),
                    User_add = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
