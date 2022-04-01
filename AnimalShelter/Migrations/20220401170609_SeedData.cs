using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Adopted", "Age", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, false, 21, "Lola", "Female", "Cat" },
                    { 2, true, 17, "Steve", "Male", "Cat" },
                    { 3, false, 15, "Reggie", "Male", "Dog" },
                    { 4, true, 13, "Silver", "Male", "Dog" },
                    { 5, false, 3, "Goldie", "Female", "Bird" },
                    { 6, false, 1, "Prince", "Male", "Dog" },
                    { 7, true, 1, "Alf", "Female", "Mouse" },
                    { 8, true, 5, "Sam", "Male", "Dog" },
                    { 9, false, 4, "Teenager", "Male", "Bird" },
                    { 10, true, 28, "Cranston", "TG", "Human" },
                    { 11, false, 77, "Snoop", "Female", "Turtle" },
                    { 12, false, 10, "Klingon", "Male", "Dog" },
                    { 13, true, 999, "Trenton", "TG", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);
        }
    }
}
