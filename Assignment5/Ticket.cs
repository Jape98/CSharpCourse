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
            this.price = price;
            this.flight = flight;
        }
    }
}
