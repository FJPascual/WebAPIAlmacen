using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAlmacen.Migrations
{
    public partial class Distribuidores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistribuidorProducto",
                columns: table => new
                {
                    DistribuidoresId = table.Column<int>(type: "int", nullable: false),
                    ProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidorProducto", x => new { x.DistribuidoresId, x.ProductosId });
                    table.ForeignKey(
                        name: "FK_DistribuidorProducto_Distribuidores_DistribuidoresId",
                        column: x => x.DistribuidoresId,
                        principalTable: "Distribuidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistribuidorProducto_Productos_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistribuidorProducto_ProductosId",
                table: "DistribuidorProducto",
                column: "ProductosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistribuidorProducto");

            migrationBuilder.DropTable(
                name: "Distribuidores");
        }
    }
}
