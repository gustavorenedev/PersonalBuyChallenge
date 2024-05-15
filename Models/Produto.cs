using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBuy.Models
{
    [Table("TB_Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required]
        [Column("nome_produto")]
        public string NomeProduto { get; set; }
        [Required]
        [Column("descricao_produto")]
        public string DescricaoProduto { get; set; }
        [Required]
        [ForeignKey("CategoriaId")]
        public CategoriaProduto CategoriaProduto { get; set; }
        [Required]
        [Column("preco_produto")]
        public double PrecoProduto { get; set; }
    }
}
