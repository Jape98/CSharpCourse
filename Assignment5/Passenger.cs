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
        override public string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Id:" + id);
            str.AppendFormat("\nForename: " + forename + ", Surname: " +surname);
            str.AppendFormat("\nPhone"+phonenumber);

            str.AppendFormat("\nCustomers tickets: ");
            foreach (Ticket ticket in ticketList)
            {
                str.AppendFormat("\n"+ticket.ToString());
            }

            return str.ToString()+"\n";
        }
    }
}
