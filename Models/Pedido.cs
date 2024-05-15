using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBuy.Models
{
    [Table("TB_Pedido")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        [Required]
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [Required]
        [Column("data_pedido")]
        public DateTime DataPedido { get; set; }
        [Required]
        [Column("status_pedido")]
        public int StatusPedido { get; set; }
        [Required]
        [Column("total_pedido")]
        public double TotalPedido { get; set; }
    }
}
