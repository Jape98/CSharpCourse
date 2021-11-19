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
            luggageWeight = this.luggageWeight;
        }
    }
}
