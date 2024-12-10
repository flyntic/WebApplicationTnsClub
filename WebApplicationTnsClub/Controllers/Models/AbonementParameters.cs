using Microsoft.AspNet.Identity;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public class AbonementParameters : IBaseParameters<long>
    {
        public long Id { get; set; }
        public BookingParameters[]? Bookings { get; set; }
        public SessionParameters[]? Sessions { get; set; }
        public int? Price { get; set; }
        public bool? IsAutorenewal { get; set; }
        public string? State { get; set; }

        public static AbonementParameters FromAbonement(Abonement abonement)
        {

            AbonementParameters parameters = new AbonementParameters()
            {
                 Id = abonement.Id,
               //  Bookings = abonement.Bookings?.ToArray<BookingParameters>().ForEach(a=>a.toBookingparameters),
                // Sessions= abonement.Sessions.ToArray<Session>().ForEach(a=>a.toSessionparameters)            
                Price = abonement.Price,
                IsAutorenewal = abonement.IsAutorenewal,
                State = abonement.State

            };
            return parameters;
        }
        public Abonement ToAbonement(Abonement item)
        {
            // = new Abonement() {
            //    Id = this.Id,
            // Bookings = abonement.Bookings.ToArray<Booking>().ForEach(a=>a.toBookingparameters),
            // Sessions= abonement.Sessions.ToArray<Session>().ForEach(a=>a.toSessionparameters)            
            item.Price = this.Price;
            item.IsAutorenewal = this.IsAutorenewal;
            item.State = this.State;

           
            return item;
        }
    }
}
