using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBuy.Models
{
    [Table("TB_CategoriaProduto")]
    public class CategoriaProduto
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [Column("nome_categoria")]
        public string NomeCategoria { get; set; }
        [Required]
        [Column("descricao_categoria")]
        public string DescricaoCategoria { get; set; }
    }
}
