﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DifficultyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Difficulty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gamer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AskedQuestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DifficultLevelId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_DifficultyLevels_DifficultLevelId",
                        column: x => x.DifficultLevelId,
                        principalTable: "DifficultyLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsTrue = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "EntityStatus", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 1, 7, 13, 34, 237, DateTimeKind.Local).AddTicks(6276), 1, "Math" },
                    { 2, new DateTime(2024, 3, 1, 7, 13, 34, 239, DateTimeKind.Local).AddTicks(9850), 1, "History" },
                    { 3, new DateTime(2024, 3, 1, 7, 13, 34, 239, DateTimeKind.Local).AddTicks(9875), 1, "Geograpy" },
                    { 4, new DateTime(2024, 3, 1, 7, 13, 34, 239, DateTimeKind.Local).AddTicks(9878), 1, "litrature" }
                });

            migrationBuilder.InsertData(
                table: "DifficultyLevels",
                columns: new[] { "Id", "CreatedDate", "Difficulty", "EntityStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(291), "Easy", 1 },
                    { 2, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(575), "Medium", 1 },
                    { 3, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(583), "Hard", 1 }
                });

            migrationBuilder.InsertData(
                table: "Gamer",
                columns: new[] { "Id", "AskedQuestions", "CreatedDate", "EntityStatus", "UserName" },
                values: new object[] { 1, null, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3425), 1, "Sadiq" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "DifficultLevelId", "EntityStatus" },
                values: new object[,]
                {
                    { 1, 1, "2*2", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1073), 1, 1 },
                    { 2, 1, "2*9", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1900), 1, 1 },
                    { 3, 1, "7*8", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1911), 1, 1 },
                    { 4, 1, "sin^2a+cos^2a = ?", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1914), 2, 1 },
                    { 5, 1, "888 + 88 + 8 + 8 + 8  ?", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1916), 2, 1 },
                    { 6, 1, "-15+ (-5x) =0", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1926), 2, 1 },
                    { 7, 1, "1.92÷3", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1929), 2, 1 },
                    { 8, 1, "121 Divided by 11 is ", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1931), 3, 1 },
                    { 9, 1, " 60 Times of 8 Equals to ", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1934), 3, 1 },
                    { 10, 1, "Find the Missing Term in Multiples 6, 12, 18, 24, _, 36, 42, _ 54, 60.", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1957), 3, 1 },
                    { 11, 1, " What is the Next Prime Number after 7 ?", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1960), 3, 1 },
                    { 12, 1, "The Product of 131 × 0 × 300 × 4", new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1962), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "CreatedDate", "EntityStatus", "IsTrue", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2299), 1, 0, 1, "1" },
                    { 2, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2982), 1, 0, 1, "2" },
                    { 3, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2991), 1, 0, 1, "3" },
                    { 4, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2993), 1, 1, 1, "4" },
                    { 5, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2995), 1, 0, 2, "1" },
                    { 6, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2999), 1, 0, 2, "992" },
                    { 7, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3002), 1, 0, 2, "123" },
                    { 8, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3004), 1, 1, 2, "18" },
                    { 9, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3006), 1, 0, 3, "18" },
                    { 10, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3009), 1, 0, 3, "121" },
                    { 11, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3012), 1, 1, 3, "56" },
                    { 12, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3014), 1, 0, 3, "5kmk" },
                    { 13, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3016), 1, 1, 4, "1" },
                    { 14, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3018), 1, 0, 4, "2" },
                    { 15, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3020), 1, 0, 4, "3" },
                    { 16, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3023), 1, 0, 4, "100" },
                    { 17, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3025), 1, 1, 5, "1000" },
                    { 18, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3028), 1, 0, 5, "1001" },
                    { 19, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3030), 1, 0, 5, "1002" },
                    { 20, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3033), 1, 0, 5, "1008" },
                    { 21, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3035), 1, 1, 6, "-3" },
                    { 22, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3037), 1, 0, 6, "-5" },
                    { 23, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3039), 1, 0, 6, "-32" },
                    { 24, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3042), 1, 0, 6, "-39" },
                    { 25, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3044), 1, 0, 7, "-0.54" },
                    { 26, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3046), 1, 1, 7, "-64" },
                    { 27, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3048), 1, 0, 7, "-0.44" },
                    { 28, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3050), 1, 0, 7, "-0.541" },
                    { 29, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3053), 1, 1, 8, "11" },
                    { 30, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3055), 1, 0, 8, "10" },
                    { 31, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3057), 1, 0, 8, "19" },
                    { 32, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3059), 1, 0, 8, "18" },
                    { 33, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3062), 1, 1, 9, "480" },
                    { 34, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3065), 1, 0, 9, "300" },
                    { 35, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3068), 1, 0, 9, "250" },
                    { 36, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3070), 1, 0, 9, "400" },
                    { 37, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3072), 1, 0, 10, "32, 45" },
                    { 38, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3074), 1, 1, 10, "30, 48" },
                    { 39, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3076), 1, 0, 10, "24, 40" },
                    { 40, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3079), 1, 0, 10, "25, 49" },
                    { 41, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3081), 1, 0, 11, "13" },
                    { 42, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3083), 1, 0, 11, "12" },
                    { 43, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3085), 1, 0, 11, "14" },
                    { 44, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3088), 1, 1, 11, "11" },
                    { 45, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3090), 1, 0, 12, "11" },
                    { 46, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3092), 1, 1, 12, "0" },
                    { 47, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3094), 1, 0, 12, "46" },
                    { 48, new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3097), 1, 0, 12, "45" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_DifficultLevelId",
                table: "Questions",
                column: "DifficultLevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Gamer");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DifficultyLevels");
        }
    }
}
