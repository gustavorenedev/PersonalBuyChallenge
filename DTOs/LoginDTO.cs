using System.ComponentModel.DataAnnotations;

namespace PersonalBuy.DTOs
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
