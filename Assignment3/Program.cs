﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airlinecompany = new AirlineCompany();

            airlinecompany[2] = new Flight(300, "Kuopio", "Bermuda Triangle", new DateTime(2021, 10, 10, 7, 0, 0), 10000);

            double id = 1;
            while (id != 0)
            {
                Console.WriteLine("Flight id? (0 to exit)");

                id = double.Parse(Console.ReadLine());
                Console.WriteLine("Results of searching flight with id " + id);

                Flight flight = airlinecompany.FindFlight(id);
                if (flight != null)
                    Console.WriteLine(flight.ToString());
                Console.WriteLine("Flight not found!\n");

            }
        }
    }
}
