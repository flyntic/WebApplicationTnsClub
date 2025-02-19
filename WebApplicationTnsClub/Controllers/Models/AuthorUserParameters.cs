using WebApplicationTnsClub.Models;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class AuthorUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static AuthorUserParameters FromAuthorUser(Author user)
        {
            AuthorUserParameters parameters = new AuthorUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public Author ToAuthorUser(Author authorUser)
        {
            authorUser.User = this.User.ToUser(new User());
            return authorUser;
        }
    }
}
