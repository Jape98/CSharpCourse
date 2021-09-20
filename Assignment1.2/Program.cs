using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_I_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight[] flights = new Flight[3];
            flights[0] = new Flight(10000, "Vaasa", "Helsinki");
            flights[1] = new Flight(20000, "Vaasa", "Madrid");
            flights[2] = new Flight(30000, "Helsinki", "Kreetta");

            var flightList1 = new List<int>() {10000,30000};
            var flightList2 = new List<int>() { 20000 };

            Customer[] customers = new Customer[2];
            customers[0] = new Customer(100, "Customer_1", flightList1);
            customers[1] = new Customer(200, "Customer_2", flightList2);

            CustomerFlightHandler customerFlightHandler = new CustomerFlightHandler(customers, flights);

            Console.WriteLine("Customer id?");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Results of searching customer with id " + id);
            Console.WriteLine(customerFlightHandler.SearchCustomer(id));

            Console.WriteLine("Flight id? ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Results of searching flighy with id " + id);
            Console.WriteLine(customerFlightHandler.SearchFlight(id));

            Console.WriteLine("Any key to close...");
            id = int.Parse(Console.ReadLine());
        }
    }
}
