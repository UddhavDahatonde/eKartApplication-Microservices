using System.ComponentModel.DataAnnotations;

namespace Auth.Core.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
