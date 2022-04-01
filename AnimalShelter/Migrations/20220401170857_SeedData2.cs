using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Adopted", "Age", "Name", "Sex", "Species" },
                values: new object[] { 14, false, 21, "Lola", "Female", "Cat" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Adopted", "Age", "Name", "Sex", "Species" },
                values: new object[] { 15, true, 17, "Steve", "Male", "Cat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Adopted", "Age", "Name", "Sex", "Species" },
                values: new object[] { 1, false, 21, "Lola", "Female", "Cat" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Adopted", "Age", "Name", "Sex", "Species" },
                values: new object[] { 2, true, 17, "Steve", "Male", "Cat" });
        }
    }
}
