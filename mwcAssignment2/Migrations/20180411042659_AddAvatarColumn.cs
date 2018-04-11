using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace mwcAssignment2.Migrations
{
    public partial class AddAvatarColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleIntro",
                table: "Blog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Blog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Blog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Blog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Blog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Blog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Views",
                table: "Blog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleIntro",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Blog");
        }
    }
}
