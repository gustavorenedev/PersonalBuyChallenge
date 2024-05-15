using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBuy.Models
{
    [Table("TB_Compra")]
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }
        [Required]
        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }
        [Required]
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        [Required]
        [Column("data_compra")]
        public DateTime DataCompra { get; set; }

    }
}
