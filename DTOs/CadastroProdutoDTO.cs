using PersonalBuy.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonalBuy.DTOs
{
    public class CadastroProdutoDTO
    {
        [Required]
        public string NomeProduto { get; set; }
        [Required]
        public string DescricaoProduto { get; set; }
        [Required]
        public string CategoriaProduto { get; set; }
        [Required]
        public double PrecoProduto { get; set; }
    }
}
