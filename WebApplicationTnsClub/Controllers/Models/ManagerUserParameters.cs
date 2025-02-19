using WebApplicationTnsClub.Models;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class ManagerUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static CoachUserParameters FromCoachUser(Coach user)
        {
            CoachUserParameters parameters = new CoachUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public Coach ToCoachUser(Coach coachUser)
        {
            coachUser.User = this.User.ToUser(new User());
            return coachUser;
        }
    }
}
