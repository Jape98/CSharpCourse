using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Flight
    {
        double id;
        string origin;
        string destination;
        DateTime date;
        double price;

        public Flight(double id, string origin, string destination, DateTime date, double price)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.price = price;
            this.date = date;
        }
        public override string ToString()
        {
            return id + " ->" + " | From: " + origin + " | To: " + destination + " | Date:" + date.ToString("dd/MM/yyyy H:mm") + " | Price:" + price;
        }
        public bool CompareId(double id)
        {
            if (this.id == id)
                return true;
            return false;
        }
    }
}
