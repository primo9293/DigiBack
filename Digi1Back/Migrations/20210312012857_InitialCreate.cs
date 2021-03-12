using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Digi1Back.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    cli_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cli_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fecha_naci = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.cli_Id);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    fac_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fac_cli_Id = table.Column<int>(type: "int", nullable: false),
                    fac_inv_Id = table.Column<int>(type: "int", nullable: false),
                    fac_fecha_compra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fac_pro_Id = table.Column<int>(type: "int", nullable: false),
                    fac_cantidad = table.Column<int>(type: "int", nullable: false),
                    fac_valor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.fac_Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    inv_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inv_pro_Id = table.Column<int>(type: "int", nullable: false),
                    inv_cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.inv_Id);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    pro_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pro_precio = table.Column<int>(type: "int", nullable: false),
                    pro_medida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.pro_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
