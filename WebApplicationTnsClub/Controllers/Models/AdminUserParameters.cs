using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class AdminUserParameters:IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static AdminUserParameters FromAdminUser(AdminUser user)
        {
            AdminUserParameters parameters = new AdminUserParameters()
            {
                Id = user.Id,
                User= UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public AdminUser ToAdminUser(AdminUser adminUser)
        {
            adminUser.User = this.User.ToUser(new User());
            return adminUser;
        }

    }
}
