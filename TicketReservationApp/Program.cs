using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plays plays = new Plays();
            plays.CustName="Courtnee";
            plays.CustPhone = "801-123-4567";
            plays.EventName = "End of Time";
            plays.description = "Say Good-Bye";
            plays.EventTime = "12/7/2007 8:45:06 AM";
            plays.TicketAmount = 3000;
            plays.Seat = "Seat 69 row 666";
            plays.Theater = "Taylorsville";
            plays.VenueLocal = "Nelson Home";
            plays.Cast = "Nelson Family";
            plays.Director = "Keith";

            Console.WriteLine(plays);

            DragRace drag = new DragRace();
            drag.CustName = "Taz";
            drag.CustPhone = "801-123-4567";
            drag.EventName = "Night of Fire";
            drag.description = "Fast Lane";
            drag.EventTime = "4/5/2002 3:15:06 PM";
            drag.TicketAmount = 10;
            drag.Seat = "Seat 2 Row 1";
            drag.VenueLocal = "Magna";
            drag.Type = "Quarter Mile";
            drag.ClassType = "Nitro";
            drag.MainDriver = "Emi";

            Console.WriteLine(drag);

            BoardGame bored = new BoardGame();
            bored.CustName = "Sandra";
            bored.CustPhone = "789-456-1230";
            bored.EventName = "Life";
            bored.description = "Funny";
            bored.EventTime = "6/2/2020 12:00:00 PM";
            bored.TicketAmount = 120000;
            bored.GameName = "Sufferance";
            bored.GameType = "Purge";
            bored.NumOfPlayers = "4";

            Console.WriteLine(bored);
        }
    }
}
