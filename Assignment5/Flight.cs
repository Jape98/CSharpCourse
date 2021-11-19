using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Flight
    {
        double id;
        string origin;
        string destination;
        DateTime date;

        public Flight(double id, string origin, string destination, DateTime date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public DateTime getDate() { return this.date; }

        public override string ToString()
        {
            return id + " ->" + " | From: " + origin + " | To: " + destination + " | Date: " + date.ToString("dd/MM/yyyy H:mm");
        }
    }
}
