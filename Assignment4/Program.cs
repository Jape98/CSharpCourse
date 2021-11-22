using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {  
        public static void Main()
        {
            AirlineCompany airlinecompany = new AirlineCompany();
            
            double id = 1;
            while (id != 0)
            {
                Console.WriteLine("Flight id? (0 to continue)");

                id = double.Parse(Console.ReadLine());
                if (id != 0)
                    Console.WriteLine("Results of searching flight with id " + id);
                Flight flight = airlinecompany.FindFlight(id);

                if (flight != null)
                    Console.WriteLine(flight.ToString() + "\n");
                else if (id == 0)
                    Console.WriteLine("\nPrice search");
                else
                    Console.WriteLine("Flight not found!\n");
            }

            double price = 1;
            while (price != 0)
            {
                Console.WriteLine("Flight Price? (0 to exit)");
                price = double.Parse(Console.ReadLine());
                Console.WriteLine("Results of searching flight with price: " + price +"\n");

                ProcessFlightDelegate pid = new ProcessFlightDelegate(AirlineCompany.DisplayRoute);
                Console.WriteLine("Calling DisplayRoute() with the delegate: ");
                airlinecompany.ProcessCheapFlights(pid, price);

                pid = new ProcessFlightDelegate(AirlineCompany.DisplayItemInfo);
                Console.WriteLine("\nFull flight info: ");
                airlinecompany.ProcessCheapFlights(pid, price);
                Console.WriteLine(" ");
            }
        }
    }
}
