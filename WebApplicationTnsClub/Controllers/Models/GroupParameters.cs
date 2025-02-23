using WebApplicationTnsClub.Models.AboutClub;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class GroupParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public string? Name { get; set; }

        public UserParameters? Organizator { get; set; }

        public ClubParameters? Club { get; set; }
        public SessionParameters?[] Sessions { get; set; }

        public PriceParameters?[] Prices { get; set; }

        public UserParameters?[] Players { get; set; }
        public string? State { get; set; }
        

        public static GroupParameters FromGroup( Group group)
        {
          

            GroupParameters parameters = new GroupParameters()
            {
                Id = group.Id,
                Name=group.Name,
            //    Organizator=new UserParameters().FromUser(group.CoachUser.User),
            //    Club =group.Club,
               // Sessions=group.Shedules,
               // Prices
               // Players
                State=group.State
    };

            return parameters;
        }

        public Group ToGroup(Group group)
        {
             //= new Group()
          //  {
             //   Id = Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }
                //     Date = this.Date,
                //     Time = this.Time,
                //    Length = this.Length,
                //    StateBooking = this.StateBooking,
                //    Price = this.Price, //Next=booking.Next,
                //    DateOfSale = this.DateOfSale,
                //Comment = Comment
         //   };

            return group;
        }


    }
}
