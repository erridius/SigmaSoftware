using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService.Models
{
    public class GuestJournal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("LineId")]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public virtual User LodgerId { set; get; }

        [ForeignKey("HousePostId")]
        public virtual HousePost HousePost { set; get; }
    }
}
