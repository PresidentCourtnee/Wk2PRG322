using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationApp
{
    public class DragRace : Ticket
    {
        public string Seat { set; get; }
        public string VenueLocal { set; get; }
        public string Type { set; get; }
        public string MainDriver {set; get;}
        public string ClassType { set; get; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Venue: {0}\n" + 
                                                   "Type: {1}\n"+
                                                   "Class Type: {2}\n"+
                                                   "Main Driver: {3}\n"+
                                                   "Seat: {4}\n",VenueLocal,Type,ClassType,MainDriver,Seat);
        }

    }
}
