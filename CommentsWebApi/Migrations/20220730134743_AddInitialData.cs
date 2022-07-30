using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommentsWebApi.Migrations
{
    public partial class AddInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ArticleId", "DateTime", "Text", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 10, 18, 30, 15, 0, DateTimeKind.Unspecified), "Test Text", "Sergiy" },
                    { 2, 1, new DateTime(2022, 3, 10, 15, 14, 13, 0, DateTimeKind.Unspecified), "Alex's comment", "Alex" },
                    { 3, 2, new DateTime(2022, 5, 1, 1, 2, 3, 0, DateTimeKind.Unspecified), "I like it", "Bob" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
