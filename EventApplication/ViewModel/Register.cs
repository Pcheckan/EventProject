using System.ComponentModel.DataAnnotations;

namespace EventApplication.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string State { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string phoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string dateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string interestOne { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string interestTwo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string interestThree { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Passwords do not match")]
        public string confirmPassword { get; set; } 
    }
}
