using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class AirlineCompany
    {

        Flight[] flights = new Flight[3];
        private readonly string name;
        //int nextIndex = 0;

        public AirlineCompany()
        {
            this.name = "KLM Royal Dutch Airlines";
            flights[0] = new Flight(100, "Vaasa", "Helsinki", new DateTime(2021, 10, 2, 21, 0, 0), 150);
            flights[1] = new Flight(200, "Helsinki", "Amsterdam", new DateTime(2021, 10, 3, 20, 0, 0), 500);
            flights[2] = new Flight(300, "Amsterdam", "Nairobi", new DateTime(2021, 10, 4, 19, 0, 0), 1000);
        }

        //indexer
        public Flight this[int i]
        {
            get => flights[i];
            set => flights[i] = value;
        }


        public Flight FindFlight(double id)
        {
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].CompareId(id))
                {
                    return flights[i];
                }
            }
            return null;
        }
    }
}
