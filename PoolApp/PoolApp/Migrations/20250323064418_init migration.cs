using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolApp.Migrations
{
    /// <inheritdoc />
    public partial class initmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pool",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recentServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nextServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    chlorineLevel = table.Column<int>(type: "int", nullable: false),
                    alkalinityLevel = table.Column<int>(type: "int", nullable: false),
                    recentVac = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pool", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pool");
        }
    }
}
