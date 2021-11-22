using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class EconomyPassenger: Passenger
    {
        double luggageWeight;

        public EconomyPassenger(double id, string forename, string surname, string phonenumber, double luggageWeight, List<Ticket> ticketList)
                          :base(id, forename, surname, phonenumber, ticketList)
        {
            this.luggageWeight = luggageWeight;
        }

        override public string GetInfo()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat(base.GetInfo());
            str.AppendFormat("Luggage Weight: " + luggageWeight + " kg");

            return str.ToString();
        }
    }
}
