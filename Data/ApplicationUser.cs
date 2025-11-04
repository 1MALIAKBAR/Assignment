using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace identitySystem.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name can't be longer than 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name can't be longer than 50 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a course.")]
        public string Course { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose your gender.")]
        [RegularExpression("Male|Female", ErrorMessage = "Invalid gender.")]
        public string Gender { get; set; } = string.Empty;
    }
}
