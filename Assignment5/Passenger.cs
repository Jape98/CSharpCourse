using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Passenger
    {
        protected double id;
        string forename, surname, phonenumber;
        List<Ticket> ticketList = new List<Ticket>();

        public Passenger(double id, string forename, string surname, string phonenumber, List<Ticket> ticketList)
        {
            this.id = id;
            this.forename = forename;
            this.surname = surname;
            this.phonenumber = phonenumber;
            this.ticketList = ticketList;
        }
    }
}
