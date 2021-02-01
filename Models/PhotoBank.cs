using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService.Models
{
    public class PhotoBank
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        public string PhotoPath { get; set; }
        [ForeignKey("HousePostId")]
        public virtual HousePost HousePost { set; get; }
    }
}
