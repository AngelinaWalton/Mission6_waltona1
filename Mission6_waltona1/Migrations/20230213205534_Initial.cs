using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_waltona1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true),
                    edited = table.Column<bool>(nullable: false),
                    lent = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.FormId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Comedy", "Not Sure", false, "no", "N/A", "PG-13", "Glass Onion", 2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Adventure", "Not Sure", false, "yes", "N/A", "PG-13", "Red Notice", 2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Drama", "Not Sure", false, "yes", "N/A", "PG-13", "Me Before You", 2016 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
