using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class PlayerUserParameters : IBaseParameters<long>
    {
        public long Id { get; set; }

        public UserParameters? User { get; set; }

        public static PlayerUserParameters FromPlayerUser(PlayerUser user)
        {
            PlayerUserParameters parameters = new PlayerUserParameters()
            {
                Id = user.Id,
                User = UserParameters.FromUser(user.User)
            };
            return parameters;
        }
        public PlayerUser ToPlayerUser(PlayerUser playerUser)
        {
            playerUser.User = this.User.ToUser(new User());
            return playerUser;
        }
    }
}
