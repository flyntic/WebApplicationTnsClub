using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class ParentUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static ParentUserParameters FromParentUser(ParentUser user)
        {
            ParentUserParameters parameters = new ParentUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public ParentUser ToParentUser(ParentUser parentUser)
        {
            parentUser.User = this.User.ToUser(new User());
            return parentUser;
        }
    }
}
