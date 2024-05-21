using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalBuy.Migrations
{
    /// <inheritdoc />
    public partial class TrocaCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cep_cleinte",
                table: "TB_Cliente",
                newName: "cep_cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cep_cliente",
                table: "TB_Cliente",
                newName: "cep_cleinte");
        }
    }
}
