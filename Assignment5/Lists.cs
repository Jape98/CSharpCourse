using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Lists
    {
        List<Flight> flightList = new List<Flight>();
        List<Ticket> ticketlist = new List<Ticket>();
        List<Passenger> passengerlist = new List<Passenger>();
        public Lists()
        {
            flightList.Add(new Flight(100, "Vaasa", "Helsinki", new DateTime(2021, 11, 20, 21, 0, 0)));
            flightList.Add(new Flight(200, "Helsinki", "Amsterdam", new DateTime(2021, 11, 21, 20, 0, 0)));
            flightList.Add(new Flight(300, "Amsterdam", "Nairobi", new DateTime(2021, 11, 22, 19, 0, 0)));
            flightList.Add(new Flight(400, "Nairobi", "Cape Town", new DateTime(2021, 11, 23, 21, 0, 0)));

            ticketlist.Add(new Ticket(flightList[0], 1, 10, 100));
            ticketlist.Add(new Ticket(flightList[1], 1, 20, 300));
            ticketlist.Add(new Ticket(flightList[2], 1, 30, 800));
            ticketlist.Add(new Ticket(flightList[3], 1, 40, 150));
            ticketlist.Add(new Ticket(flightList[0], 2, 50, 85));
            ticketlist.Add(new Ticket(flightList[1], 2, 60, 300));
            ticketlist.Add(new Ticket(flightList[0], 3, 70, 300));

            passengerlist.Add(new FirstClassPassenger(1, "Biggus", "Dickus", "(+358)44-285-0673", 100, ticketlist));
            passengerlist.Add(new FirstClassPassenger(2, "Sillius", "Soddus", "(+358)44-244-5544", 50, ticketlist));
            passengerlist.Add(new EconomyPassenger(3, "Brian", "Cohen", "(+358)44-445-2864", 10, ticketlist));
        }

        public Passenger SearchPassenger(double id)
        {
            foreach (Passenger p in passengerlist)
            {
                if (p.GetId() == id)
                {
                    return p;
                }
            }
            return null;
        }

        public List<Ticket> SearchTicketByUserId(double id)
        {
            List<Ticket> result = new List<Ticket>();
            foreach (Ticket t in ticketlist)
            {
                if (t.GetPassengerId() == id)
                {
                    result.Add(t); 
                }
            }
            return result;
        }
    }
}
