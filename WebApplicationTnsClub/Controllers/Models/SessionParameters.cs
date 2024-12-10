using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class SessionParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public TypeOfDay? TypeOfDay { get; set; }

        public string? Time { get; set; }
        public int? Length { get; set; }

        public static SessionParameters FromSession(Session session)
        {
            SessionParameters parameters = new SessionParameters()
            {
                Id = session.Id,
                //ApiUser?[] Users { get; set; }
                //ApiClub? Club { get; set; }
                //ApiRate? Rate { get; set; }
                //public ApiUser? UserOfSale { get; set; }

                // Comment = club.Comment
            };

            return parameters;
        }
        public Session ToSession(Session session)
        {
           //  = new Session() { };
           // session.Id=this.Id;
            return session;
        }
    }
}
