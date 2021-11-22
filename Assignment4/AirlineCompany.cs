using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class AirlineCompany
    {
        public List<Flight> flightList = new List<Flight>();

        public AirlineCompany()
        {
            flightList.Add(new Flight(100, "Vaasa", "Helsinki", new DateTime(2021, 10, 2, 21, 0, 0), 150));
            flightList.Add(new Flight(200, "Helsinki", "Amsterdam", new DateTime(2021, 10, 3, 20, 0, 0), 500));
            flightList.Add(new Flight(300, "Amsterdam", "Nairobi", new DateTime(2021, 10, 4, 19, 0, 0), 1000));
            flightList.Add(new Flight(400, "Nairobi", "Cape Town", new DateTime(2021, 10, 5, 1, 0, 0), 800));
        }

        public List<Flight> getFlightList()
        {
            return this.flightList;
        }

        public Flight FindFlight(double id)
        {
            foreach (Flight f in flightList)
            {
                if (f.id == id)
                    return f;  
            }
            return null;
        }

        //Here we call a passed-in delegate on each item to process it
        public void ProcessCheapFlights(ProcessFlightDelegate processItemDelegate, double price)
        {
            foreach (Flight f in flightList)
            {
                if (f.CheckPrice(price))
                    processItemDelegate(f);
            }
        }

        public static void DisplayItemInfo(Flight item)
        {
            Console.WriteLine(item.ToString());
        }
        public static void DisplayRoute(Flight item)
        {
            Console.WriteLine("From " + item.getOrigin() + " To " + item.getDestination());
        }
        public static bool MoreThan(Flight f)
        {
            if (f.getPrice()>250)
                return true;
            else
                return false;
        }

        public static void DoWorkWithTwoParameters(int arg1, int arg2)
        {
            Console.WriteLine(arg1 + "-" + arg2);
        }
    }
}
