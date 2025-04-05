using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace database_app.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Temperature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    temperature = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "weathers",
                columns: table => new
                {
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    timezone = table.Column<int>(type: "INTEGER", nullable: false),
                    mainId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weathers", x => x.name);
                    table.ForeignKey(
                        name: "FK_weathers_Temperature_mainId",
                        column: x => x.mainId,
                        principalTable: "Temperature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    Weathername = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Description_weathers_Weathername",
                        column: x => x.Weathername,
                        principalTable: "weathers",
                        principalColumn: "name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Description_Weathername",
                table: "Description",
                column: "Weathername");

            migrationBuilder.CreateIndex(
                name: "IX_weathers_mainId",
                table: "weathers",
                column: "mainId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "weathers");

            migrationBuilder.DropTable(
                name: "Temperature");
        }
    }
}
