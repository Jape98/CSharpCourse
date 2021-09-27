using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Concert
    {
        string title;
        string location;
        DateTime date;
        double price;

        public Concert(string title, string location, double price, DateTime date)
        {
            this.title = title;
            this.location = location;
            this.date = date;
            this.price = price;
        }

        public override string ToString()
        {
            return "Title: " + title + ", Price: " + price + ", Location: " + location + ", Date: " + date.ToString("dd/MM/yyyy H:mm");
        }
        public static Concert operator ++(Concert concert)
        {
            concert.price += 5;
            return concert;
        }
        public static Concert operator --(Concert concert)
        {
            concert.price -= 5;
            return concert;
        }
        public static  Concert operator <(Concert concert, Concert otherConcert)
        {
            if(concert.price > otherConcert.price)
            {
                Console.WriteLine(concert.title + " costs more than " + otherConcert.title);
                return null;
            }
            else
            {
                Console.WriteLine(otherConcert.title + " costs more than " + concert.title);
                return null;
            }
            
        }
        public static Concert operator >(Concert concert, Concert otherConcert)
        {
         
        if(concert.price > otherConcert.price)
            {
                Console.WriteLine(concert.title + " costs more than " + otherConcert.title);
                return null;
            }
            else
            {
                Console.WriteLine(otherConcert.title + " costs more than " + concert.title);
                return null;
            }
        }
    }
}
