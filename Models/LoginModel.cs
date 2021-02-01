using System.ComponentModel.DataAnnotations;

namespace BookingService.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не вказано Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не вказано пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
