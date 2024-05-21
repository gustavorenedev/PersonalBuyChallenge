using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalBuy.Migrations
{
    /// <inheritdoc />
    public partial class RemovendoCategoria2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Produto_TB_CategoriaProduto_CategoriaId",
                table: "TB_Produto");

            migrationBuilder.DropIndex(
                name: "IX_TB_Produto_CategoriaId",
                table: "TB_Produto");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "TB_Produto",
                newName: "categoria_produto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "categoria_produto",
                table: "TB_Produto",
                newName: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Produto_CategoriaId",
                table: "TB_Produto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Produto_TB_CategoriaProduto_CategoriaId",
                table: "TB_Produto",
                column: "CategoriaId",
                principalTable: "TB_CategoriaProduto",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
