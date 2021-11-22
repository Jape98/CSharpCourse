using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class EconomyPassenger: Passenger
    {
        double luggageWeight;
        public EconomyPassenger(double id, string forename, string surname, string phonenumber, List<Ticket> ticketList, double luggageWeight)
                          :base(id, forename, surname, phonenumber, ticketList)
        {
            this.luggageWeight = luggageWeight;
        }

        override public string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat(base.ToString());
            str.AppendFormat("LuggageWeight: " + luggageWeight + " kg");

            return str.ToString();
        }
    }
}
