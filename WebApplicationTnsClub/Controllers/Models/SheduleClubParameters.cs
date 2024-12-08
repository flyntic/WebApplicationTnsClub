using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class SheduleClubParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public Club? Club { get; set; }
        public Session?[] Sessions { get; set; }

        public SheduleClubParameters FromSheduleClub(SheduleClub sheduleClub)
        {
           SheduleClubParameters sheduleClubParameters = new SheduleClubParameters()
            {
                Id = sheduleClub.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return sheduleClubParameters;
        }
        public SheduleClub ToSheduleClub()
        {
            SheduleClub s = new SheduleClub() { };
            return s;
        }
    }
}
