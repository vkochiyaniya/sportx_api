using System.ComponentModel.DataAnnotations;

namespace sportx_api.DTOs.UserDTOs
{
    public class LoginDTO
    {
        [Required]
        public string Email { get; set; } = null!;

        [Required]

        public string Password { get; set; } = null!;
    }
}
