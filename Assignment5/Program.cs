using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {  
            AirlineCompany airlinecompany = new AirlineCompany();




             double price = double.Parse(Console.ReadLine());




            double id = 1;
            while (id != 0)
            {
                Console.WriteLine("Flight id? (0 to exit)");

                id = double.Parse(Console.ReadLine());
                Console.WriteLine("Results of searching flight with id " + id);

                Flight flight = airlinecompany.FindFlight(id);

                if (flight != null)
                    Console.WriteLine(flight.ToString());
                else
                    Console.WriteLine("Flight not found!\n");
            }
        }
    }
}
