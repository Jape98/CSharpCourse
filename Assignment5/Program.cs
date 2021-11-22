using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flight> flightList = new List<Flight>();
            List<EconomyPassenger> economyClassList = new List<EconomyPassenger>();
            List<FirstClassPassenger> firstClassCList = new List<FirstClassPassenger>();
            List<Ticket> pass1tickets = new List<Ticket>();
            List<Ticket> pass2tickets = new List<Ticket>();
            List<Ticket> pass3tickets = new List<Ticket>();

            //Flight: id, origin, destination, date
            flightList.Add(new Flight(100, "Vaasa", "Helsinki", new DateTime(2021, 11, 2, 21, 0, 0)));
            flightList.Add(new Flight(200, "Helsinki", "Amsterdam", new DateTime(2021, 11, 8, 20, 0, 0)));
            flightList.Add(new Flight(300, "Amsterdam", "Nairobi", new DateTime(2021, 11, 14, 19, 0, 0)));
            flightList.Add(new Flight(400, "Nairobi", "Cape Town", new DateTime(2021, 11, 20, 1, 0, 0)));

            pass1tickets.Add(new Ticket(flightList[0], 1, 10, 85));
            pass1tickets.Add(new Ticket(flightList[1], 1, 20, 300));
            pass1tickets.Add(new Ticket(flightList[2], 1, 30, 800));
            pass1tickets.Add(new Ticket(flightList[3], 1, 40, 150));
            pass2tickets.Add(new Ticket(flightList[0], 2, 50, 85));
            pass2tickets.Add(new Ticket(flightList[1], 2, 60, 300));
            pass3tickets.Add(new Ticket(flightList[0], 3, 70, 300));

            firstClassCList.Add(new FirstClassPassenger(1, "Biggus", "Dickus", "(+358)44-285-0673", pass1tickets, 100));
            firstClassCList.Add(new FirstClassPassenger(2, "Sillius", "Soddus", "(+358)44-244-5544", pass2tickets, 50));
            economyClassList.Add(new EconomyPassenger(3, "Brian", "Cohen", "(+358)44-244-5544", pass3tickets, 10));
        }
    }
}
