using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    [Table(@"SheduleClubOpenBookings")]
    public class SheduleClubOpenBooking
    {
        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(@"datecreate")]
        public DateTime DateCreate { get; set; }

        [Column(@"dateupdate")]
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        [Column(@"isdeleted")]
        public bool IsDeleted { get; set; }

        [Column(@"datedelete")]
        public DateTime? DateDelete { get; set; }

        //======================================================

        [Column(@"sheduleclub")]
        public SheduleClub? SheduleClub { get; set; }

        [Column(@"date")]
        public Date? Date { get; set; }

        [Column(@"state_booking")]
        public StateBooking? StateBooking { get; set; }


    }
}
