using WebApplicationTnsClub.Models;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class ParentUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static ParentUserParameters FromParentUser(Parent user)
        {
            ParentUserParameters parameters = new ParentUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public Parent ToParentUser(Parent parentUser)
        {
            parentUser.User = this.User.ToUser(new User());
            return parentUser;
        }
    }
}
