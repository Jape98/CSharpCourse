using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Ticket
    {
        readonly double extraTax;

        double ticketId, passengerId, price;
        Flight flight;

        public Ticket(Flight flight, double passengerId, double ticketId, double price)
        {
            this.ticketId = ticketId;
            this.passengerId = passengerId;
            this.ticketId = ticketId;
            this.flight = flight;

            if (flight.getDate().DayOfWeek.Equals(DayOfWeek.Saturday)
            ||  flight.getDate().DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                extraTax = 0.7;
                this.price = price * extraTax;
            }
            else
            {
                extraTax = 0.5;
                this.price = price * extraTax;
            }
        }
        public double GetPrice()
        {
            return price;
        }
    }
}
