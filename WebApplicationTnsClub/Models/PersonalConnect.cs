namespace WebApplicationTnsClub.Models
{
    public enum TypeConnect { 
      Parent,
      Partner,
      Coach
    }

    [Table(@"PersonalConnects")]
    public class PersonalConnect
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

        //=======================================================
        [Column(@"mentor")]
        public User? Mentor { get; set; }

        [Column(@"heir")]
        public User? Heir { get; set; }

        [Column (@"type_connect")]
        public TypeConnect? TypeConnect { get; set; }
          


    }
}
