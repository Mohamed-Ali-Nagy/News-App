﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFlabDay2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cat_id",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogSt_id",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_id1",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_News_CatalogSt_id",
                table: "News",
                column: "CatalogSt_id");

            migrationBuilder.CreateIndex(
                name: "IX_News_User_id1",
                table: "News",
                column: "User_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Categories_CatalogSt_id",
                table: "News",
                column: "CatalogSt_id",
                principalTable: "Categories",
                principalColumn: "St_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_User_id1",
                table: "News",
                column: "User_id1",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Categories_CatalogSt_id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_User_id1",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CatalogSt_id",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_User_id1",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Cat_id",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CatalogSt_id",
                table: "News");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "News");

            migrationBuilder.DropColumn(
                name: "User_id1",
                table: "News");
        }
    }
}
