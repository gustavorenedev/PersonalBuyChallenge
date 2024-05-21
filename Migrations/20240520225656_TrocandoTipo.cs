using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalBuy.Migrations
{
    /// <inheritdoc />
    public partial class TrocandoTipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "categoria_produto",
                table: "TB_Produto",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "categoria_produto",
                table: "TB_Produto",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");
        }
    }
}
