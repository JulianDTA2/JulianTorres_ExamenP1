using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JulianTorres_ExamenP1.Migrations
{
    public partial class InicioDBJulianTorres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JTTabla",
                columns: table => new
                {
                    JTTablaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JTTablaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JTTablaValue = table.Column<float>(type: "real", nullable: false),
                    JTIsTabla = table.Column<bool>(type: "bit", nullable: false),
                    JTEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JTFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JTTablaPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JTTabla", x => x.JTTablaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JTTabla");
        }
    }
}
