using System.ComponentModel.DataAnnotations;

namespace identitySystem.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First name required")]
        [StringLength(50, ErrorMessage = "First name max 50 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name required")]
        [StringLength(50, ErrorMessage = "Last name max 50 characters")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a course")]
        public string Course { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a gender")]
        public string Gender { get; set; } = string.Empty;
    }
}
