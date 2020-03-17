using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial2_Maria.Migrations
{
    public partial class Llamadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Llamadas",
                columns: table => new
                {
                    LlamadaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamadas", x => x.LlamadaId);
                });

            migrationBuilder.CreateTable(
                name: "LlamadasDetalles",
                columns: table => new
                {
                    LlamadaDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LlamadaId = table.Column<int>(nullable: false),
                    Problema = table.Column<string>(nullable: true),
                    Solucion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LlamadasDetalles", x => x.LlamadaDetalleId);
                    table.ForeignKey(
                        name: "FK_LlamadasDetalles_Llamadas_LlamadaId",
                        column: x => x.LlamadaId,
                        principalTable: "Llamadas",
                        principalColumn: "LlamadaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Llamadas",
                columns: new[] { "LlamadaId", "Descripcion" },
                values: new object[] { 1, "No se" });

            migrationBuilder.InsertData(
                table: "LlamadasDetalles",
                columns: new[] { "LlamadaDetalleId", "LlamadaId", "Problema", "Solucion" },
                values: new object[] { 1, 1, "No se", "No se" });

            migrationBuilder.CreateIndex(
                name: "IX_LlamadasDetalles_LlamadaId",
                table: "LlamadasDetalles",
                column: "LlamadaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LlamadasDetalles");

            migrationBuilder.DropTable(
                name: "Llamadas");
        }
    }
}
