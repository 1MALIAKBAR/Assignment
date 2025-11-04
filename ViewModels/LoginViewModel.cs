using System.ComponentModel.DataAnnotations;

namespace identitySystem.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
