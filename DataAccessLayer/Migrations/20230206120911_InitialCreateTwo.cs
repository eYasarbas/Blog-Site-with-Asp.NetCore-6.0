﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class InitialCreateTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutMapApplication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ConnectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectionUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConnectionStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.ConnectionID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
