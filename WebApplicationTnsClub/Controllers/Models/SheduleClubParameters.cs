using WebApplicationTnsClub.Models;
using WebApplicationTnsClub.Models.AboutClub;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class SheduleClubParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public ClubParameters? Club { get; set; }
        public SessionParameters?[] Sessions { get; set; }

        public static SheduleClubParameters FromSheduleClub(SheduleClub sheduleClub)
        {
            SheduleClubParameters sheduleClubParameters = new SheduleClubParameters()
            {
                Id = sheduleClub.Id,
                Club = ClubParameters.FromClub(sheduleClub.Club),
           //     Sessions= new SessionParameters[sheduleClub.Sessions]()
            };

            foreach (var s in sheduleClub.Sessions) {
                sheduleClubParameters.Sessions.Append(SessionParameters.FromSession(s));
            }

            return sheduleClubParameters;
        }
        public SheduleClub ToSheduleClub(SheduleClub s)
        {
             
            s.Club = this.Club.ToClub(new Club());
            return s;
        }
    }
}
