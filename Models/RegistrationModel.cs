using System.ComponentModel.DataAnnotations;

namespace BookingService.Models
{
    public class RegistrationModel
    {

        [StringLength(30)]
        [Required(ErrorMessage = "Не вказано ім'я")]
        public string PIP { get; set; }
        [Required(ErrorMessage = "Не вказано Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не вказано пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль ведено не вірно!")]
        public string ConfirmPassword { get; set; }
    }
}
