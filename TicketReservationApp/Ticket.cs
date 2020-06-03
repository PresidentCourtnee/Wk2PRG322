using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationApp
{
    public abstract class Ticket
    {
        public string EventTime { set; get; }
        public string description { set; get; }
        public string EventName { set; get; }
        public decimal TicketAmount { set; get; }
        public string CustName { set; get; }
        public string CustPhone { set; get; }

        public override string ToString()
        {
            return string.Format("Customer Name: {0}\n" +
                                 "Customer Phone: {1}\n" +
                                 "Event: {2}\n" +
                                 "Description: {3}\n" +
                                 "Event Date: {4}\n" +
                                 "Ticket Amount: {5}\n"
                                 , CustName, CustPhone, EventName, description, EventTime, TicketAmount);
        }
    }

}
