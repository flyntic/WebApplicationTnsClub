using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class AuthorUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static AuthorUserParameters FromAuthorUser(AuthorUser user)
        {
            AuthorUserParameters parameters = new AuthorUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public AuthorUser ToAuthorUser(AuthorUser authorUser)
        {
            authorUser.User = this.User.ToUser(new User());
            return authorUser;
        }
    }
}
