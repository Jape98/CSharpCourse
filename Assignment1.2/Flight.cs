using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_I_II
{
    class Flight
    {
        public int id;
        string origin;
        string destination;

        public Flight(int id, string origin, string destination)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;

        }

        public bool SearchFlight(int id)
        {
            if (this.id == id)
                return true;

            return false;
        }

        public override string ToString()
        {
            return id + " -> " + "|From: " + origin + "|To: " + destination + "|";
        }
    }
}
