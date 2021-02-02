using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Models
{
    public class CommentModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string ContentComent { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { set; get; }
        public double Score { get; set; }
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }
        [ForeignKey("HousePostId")]
        public virtual ICollection<HousePost> HousePosts { get; set; }
    }
}
