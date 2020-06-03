using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationApp
{
    public class Plays : Ticket
    {
     public string Seat { set; get; }
     public string VenueLocal { set; get; }
     public string Theater { set; get; }
     public string Cast { set; get; }
     public string Director { set; get; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Venue: {0}\n" +
                                                  "Theater: {1}\n" +
                                                  "Director: {2}\n" +
                                                  "Cast: {3}\n" +
                                                  "Seat: {4}\n\n", VenueLocal, Theater, Director, Cast, Seat);

        }
    }
}
