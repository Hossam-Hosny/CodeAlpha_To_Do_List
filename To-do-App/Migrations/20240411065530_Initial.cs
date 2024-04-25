using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace To_do_App.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDoSet",
                columns: new[] { "Id", "Category", "Description", "DueDate", "Status", "Task" },
                values: new object[,]
                {
                    { 1, "Work", "Colledge Math  Assignment ", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Assignment" },
                    { 2, "Shopping", "Go to Shopping Next Week ", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Buying T-Shirt" },
                    { 3, "Training", "Go to GYM For exercise ", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Exercise " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoSet");
        }
    }
}
