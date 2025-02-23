using WebApplicationTnsClub.Models;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class AdminUserParameters:IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static AdminUserParameters FromAdminUser(Admin user)
        {
            AdminUserParameters parameters = new AdminUserParameters()
            {
                Id = user.Id,
                User= UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public Admin ToAdminUser(Admin adminUser)
        {
            adminUser.User = this.User.ToUser(new User());
            return adminUser;
        }

    }
}
