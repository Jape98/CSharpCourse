using System;

namespace Assignment4
{
    public class Flight
    {
        public double id;
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
        public double getId() { return this.id; }
        public string getOrigin() { return this.origin; }
        public string getDestination() { return this.destination; }
        public double getPrice() { return this.price; }
        public String getDate() { return date.ToString(" dd/MM/yyyy H:mm"); }


        public bool CheckPrice(double price)
        {
            return (this.price <= price);
        }

        public override string ToString()
        {
            return id + " ->" + " | From: " + origin + " | To: " + destination + " | Date:" + date.ToString("dd/MM/yyyy H:mm") + " | Price:" + price;
        }
    }
}
