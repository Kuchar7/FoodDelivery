using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDelivery.Persistence.Migrations
{
    public partial class seed_DishType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DishTypes",
                columns: new[] { "Id", "DateCreated", "LastDateModified", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kebab" });

            migrationBuilder.InsertData(
                table: "DishTypes",
                columns: new[] { "Id", "DateCreated", "LastDateModified", "Name" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pizza" });

            migrationBuilder.InsertData(
                table: "DishTypes",
                columns: new[] { "Id", "DateCreated", "LastDateModified", "Name" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butter Chicken" });

            migrationBuilder.CreateIndex(
                name: "IX_DishTypes_Name",
                table: "DishTypes",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DishTypes_Name",
                table: "DishTypes");

            migrationBuilder.DeleteData(
                table: "DishTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DishTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DishTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
