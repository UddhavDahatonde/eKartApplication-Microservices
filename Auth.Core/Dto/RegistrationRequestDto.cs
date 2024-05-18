using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Auth.Core.Dto
{
    public class RegistrationRequestDto
    {
        [Required]
        [StringLength(100)]
        public string? UserName { get; set; }
        [StringLength(100)]
        [Required]
        public string? Email { get; set; }
        [StringLength(10)]
        [Required]
        public string? PhoneNumber { get; set; }
        [StringLength(10)]
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        public string? Role { get; set; }
    }
}
