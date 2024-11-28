using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTnsClub.Models
{
    [Table(@"Tickets")]
    public class Ticket:BaseId
    {
        [Column(@"id", TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Column(@"datecreate")]
        public DateTime DateCreate { get; set; }

        [Column(@"dateupdate")]
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        [Column(@"isdeleted")]
        public bool IsDeleted { get; set; }

        [Column(@"datedelete")]
        public DateTime? DateDelete { get; set; }

        //======================================================

        [Column(@"bookings")]
        public Booking?[] Bookings { get; set; }

        [Column(@"shedules")]
        public Shedule?[] Shedules { get; set; }

        [Column(@"price")]
        public int? Price { get; set; }

        [Column(@"isautorenewal")]
        public bool? isAutorenewal { get; set; }

        [Column(@"state")]
        public string? State { get; set; }

        [Column(@"comment")]
        public string? Comment { get; set; }


    }
}
