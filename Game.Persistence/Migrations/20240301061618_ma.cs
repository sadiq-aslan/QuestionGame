using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Gamer",
                table: "Gamer");

            migrationBuilder.RenameTable(
                name: "Gamer",
                newName: "Gamers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gamers",
                table: "Gamers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 190, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Gamers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6278));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Gamers",
                table: "Gamers");

            migrationBuilder.RenameTable(
                name: "Gamers",
                newName: "Gamer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gamer",
                table: "Gamer",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 237, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 239, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 239, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 239, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Gamer",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 1, 7, 13, 34, 240, DateTimeKind.Local).AddTicks(1962));
        }
    }
}
