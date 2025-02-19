using WebApplicationTnsClub.Models;
using WebApplicationTnsClub.Models.Users;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class PlayerUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static PlayerUserParameters FromPlayerUser(Player user)
        {
            PlayerUserParameters parameters = new PlayerUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public Player ToPlayerUser(Player playerUser)
        {
            playerUser.User = this.User.ToUser(new User());
            return playerUser;
        }
    }
}
