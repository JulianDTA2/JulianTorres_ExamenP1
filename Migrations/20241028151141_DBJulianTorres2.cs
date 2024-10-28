using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JulianTorres_ExamenP1.Migrations
{
    public partial class DBJulianTorres2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JTTablaValue",
                table: "JTTabla",
                newName: "JTCostoBruto");

            migrationBuilder.RenameColumn(
                name: "JTTablaPrice",
                table: "JTTabla",
                newName: "JTPVP");

            migrationBuilder.RenameColumn(
                name: "JTTablaName",
                table: "JTTabla",
                newName: "JTTablaObjeto");

            migrationBuilder.RenameColumn(
                name: "JTIsTabla",
                table: "JTTabla",
                newName: "JTALaVenta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JTTablaObjeto",
                table: "JTTabla",
                newName: "JTTablaName");

            migrationBuilder.RenameColumn(
                name: "JTPVP",
                table: "JTTabla",
                newName: "JTTablaPrice");

            migrationBuilder.RenameColumn(
                name: "JTCostoBruto",
                table: "JTTabla",
                newName: "JTTablaValue");

            migrationBuilder.RenameColumn(
                name: "JTALaVenta",
                table: "JTTabla",
                newName: "JTIsTabla");
        }
    }
}
