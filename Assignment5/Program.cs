using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists l = new Lists();
            List<Ticket> result = new List<Ticket>();

            while (true)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Type 1 to search passenger with user ID\n" +
                              "Type 2 to search ticket with user ID\n" +
                              "Type 'exit' to exit");
                string search = Console.ReadLine();
                result.Clear();

                switch (search)
                {
                    case "1":
                        Console.WriteLine("\nEnter passenger id >");
                        double id = double.Parse(Console.ReadLine());
                        Console.WriteLine("Results for " + l.SearchPassenger(id).GetInfo() + "\n");

                        result = l.SearchTicketByUserId(id);
                        Console.WriteLine("Passenger " + id + " flight information");

                        foreach (Ticket t in result)
                        {
                            Console.WriteLine(t.GetFlight().ToString());
                            //Console.WriteLine();
                        }
                    break;

                    case "2":
                        Console.WriteLine("Enter passenger id > ");
                        id = double.Parse(Console.ReadLine());
                        result = l.SearchTicketByUserId(id);
                        Console.WriteLine("Passenger " + id + " tickets and flight information");

                        foreach (Ticket t in result)
                        {
                            Console.WriteLine(t.ToString() +" | "+ t.GetFlight().ToString());
                        }
                    break;

                    case "exit":
                        Environment.Exit(0);
                    break;
                }
            }
        }
    }
}
