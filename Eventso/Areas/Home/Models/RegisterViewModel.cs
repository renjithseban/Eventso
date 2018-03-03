using System.ComponentModel.DataAnnotations;

namespace Evento.Areas.Home.Models
{
    public class RegisterViewModel
    {
        public int UserId { get; set; }

        [Display(Name = "First Name", Description = "First name of the user")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(100, ErrorMessage = "First name shouldn't exceed 100 characters")]

        public string FirstName { get; set; }

        [Display(Name = "Last Name", Description = "Last name of the user")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(100, ErrorMessage = "Last name shouldn't exceed 100 characters")]

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email", Description = "E-mail of the user")]
        [Required(ErrorMessage = "E-mail is required")]
        [StringLength(100, ErrorMessage = "Email shouldn't exceed 100 characters")]

        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Mobile is required")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [Display(Name = "Mobile")]
        public string ContactNo { get; set; }

        public bool IsEmailVerfied { get; set; }

        public bool IsMobileVerified { get; set; }
    }
}