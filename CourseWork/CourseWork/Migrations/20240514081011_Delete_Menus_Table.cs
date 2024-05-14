using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class Delete_Menus_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    dish_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    dish_name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    dish_type = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    restaurant_type = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    dish_price = table.Column<int>(type: "int", nullable: false),
                    in_stock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dishes__9F2B4CF9A543A9EF", x => x.dish_id);
                });

            migrationBuilder.CreateTable(
                name: "UserQuestions",
                columns: table => new
                {
                    question_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    question_text = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserQues__2EC215496477954B", x => x.question_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "UserQuestions");
        }
    }
}
