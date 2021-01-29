using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("UserId")]
        public int Id { get; set; }
        [Required]
        public string Full_name { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public virtual ICollection<HousePost>? HousePosts { get; set; }
    }
}
