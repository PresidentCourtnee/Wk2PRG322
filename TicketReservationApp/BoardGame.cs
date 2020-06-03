using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationApp
{
    public class BoardGame : Ticket
    {
        public string GameName { set; get; }
        public string GameType { set; get; }
        public string NumOfPlayers { set; get; }

        public override string ToString()
        {
            return base.ToString()+string.Format("Board Game Name: {0}\n" +
                                                 "Board Game Type: {1}\n"+
                                                 "Number of Players: {2}\n",GameName,GameType,NumOfPlayers);
        }

    }
}
