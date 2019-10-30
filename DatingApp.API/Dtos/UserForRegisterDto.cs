using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "Password needs to be 8 to 10 characters")]
        public string Password { get; set; }
    }
}