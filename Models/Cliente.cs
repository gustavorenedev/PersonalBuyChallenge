using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBuy.Models
{
    [Table("TB_Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [Column("nome_cliente")]
        public string Nome { get; set; }
        [Required]
        [Column("cpf_cliente")]
        public string Cpf { get; set; }
        [Required]
        [Column("email_cliente")]
        public string Email { get; set; }
        [Required]
        [Column("telefone_cliente")]
        public string Telefone { get; set; }
        [Required]
        [Column("endereco_cliente")]
        public string Endereco { get; set; }
        [Required]
        [Column("cep_cleinte")]
        public string Cep { get; set; }
    }
}
