using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalBuy.Migrations
{
    /// <inheritdoc />
    public partial class Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CategoriaProduto",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_categoria = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    descricao_categoria = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CategoriaProduto", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "TB_Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_cliente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    cpf_cliente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email_cliente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    telefone_cliente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    endereco_cliente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    cep_cleinte = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "TB_Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_produto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    descricao_produto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    preco_produto = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Produto", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_TB_Produto_TB_CategoriaProduto_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TB_CategoriaProduto",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Pedido",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    data_pedido = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    status_pedido = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    total_pedido = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Pedido", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_TB_Pedido_TB_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProdutoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    data_compra = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Compra", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_TB_Compra_TB_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "TB_Pedido",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_Compra_TB_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "TB_Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Compra_PedidoId",
                table: "TB_Compra",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Compra_ProdutoId",
                table: "TB_Compra",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Pedido_ClienteId",
                table: "TB_Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Produto_CategoriaId",
                table: "TB_Produto",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Compra");

            migrationBuilder.DropTable(
                name: "TB_Pedido");

            migrationBuilder.DropTable(
                name: "TB_Produto");

            migrationBuilder.DropTable(
                name: "TB_Cliente");

            migrationBuilder.DropTable(
                name: "TB_CategoriaProduto");
        }
    }
}
