using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Concert
    {
        string title;
        string location;
        DateTime dateTime;
        double price;

        public Concert(string title, string location, double price, DateTime dateTime)
        {
            this.title = title;
            this.location = location;
            this.dateTime = dateTime;
            this.price = price;

        }
    }
}
