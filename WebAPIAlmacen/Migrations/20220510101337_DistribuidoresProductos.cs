using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAlmacen.Migrations
{
    public partial class DistribuidoresProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistribuidoresProductos",
                columns: table => new
                {
                    DistribuidorId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    UnidadesVendidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidoresProductos", x => new { x.DistribuidorId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_DistribuidoresProductos_Distribuidores_DistribuidorId",
                        column: x => x.DistribuidorId,
                        principalTable: "Distribuidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistribuidoresProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistribuidoresProductos_ProductoId",
                table: "DistribuidoresProductos",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistribuidoresProductos");
        }
    }
}
