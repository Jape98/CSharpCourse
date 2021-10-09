using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_I_II
{
    class CustomerFlightHandler
    {
        Customer[] customers;
        Flight[] flights;

        public CustomerFlightHandler(Customer[] customers, Flight[] flights)
        {
            this.customers = customers;
            this.flights = flights;
        }

        public String SearchCustomer(int id) {

            StringBuilder searchResult = new StringBuilder();

            for(int i=0; i<customers.Length; i++)
            {
                if (customers[i].SearchCustomer(id))
                {
                    searchResult.AppendLine(customers[i].ToString());

                    foreach(var flightId in customers[i].flightID)
                    {
                        foreach (var flights in flights)
                        {
                            if (flightId == flights.id)
                            {
                                searchResult.AppendLine(flights.ToString());
                            }
                        }
                    }
                }     
            }

            if (searchResult.Length == 0)
            {
                return "Customer with id=" + id + " not found!";
            }
            return searchResult.ToString();
        }

        public String SearchFlight(int id)
        {

            StringBuilder searchResult = new StringBuilder();

            for (int i = 0; i < flights.Length; i++)
            {

                if (flights[i].SearchFlight(id))
                {
                    searchResult.AppendLine(flights[i].ToString());

                    foreach (var customer in customers)
                    {
                        if (customer.flightID.Contains(id))
                        {
                            searchResult.AppendLine(customer.ToString());
                        }
                    }
                }
            }
            return searchResult.ToString();
        }
    }
}
