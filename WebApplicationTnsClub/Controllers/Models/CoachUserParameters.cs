using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class CoachUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static CoachUserParameters FromCoachUser(CoachUser user)
        {
            CoachUserParameters parameters = new CoachUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public CoachUser ToCoachUser(CoachUser coachUser)
        {
            coachUser.User = this.User.ToUser(new User());
            return coachUser;
        }
    }
}
