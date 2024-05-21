using System.ComponentModel.DataAnnotations;

namespace PersonalBuy.DTOs
{
    public class CadastroClienteDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Cep { get; set; }
    }
}
