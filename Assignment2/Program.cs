using System;
using System.Collections;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            String title;
            Concert c;
            Concert c2;

            title = "ZZ Top"; table.Add(title, new Concert(title, "location1", 50, new DateTime(2021, 2, 16, 18, 10, 0)));
            title = "Tom Waits"; table.Add(title, new Concert(title, "location2", 60, new DateTime(2021, 4, 17, 19, 15, 0)));
            title = "Ben Caplan"; table.Add(title, new Concert(title, "location3", 70, new DateTime(2021, 6, 18, 20, 20, 0)));
            title = "AC/DC"; table.Add(title, new Concert(title, "location4", 80, new DateTime(2021, 8, 19, 21, 25, 0)));
            title = "Dire Straits"; table.Add(title, new Concert(title, "location5", 90, new DateTime(2021, 10, 20, 22, 30, 0)));

            c = (Concert)table["Ben Caplan"]; c--;
            c2 = (Concert)table["Tom Waits"]; c2++;


            foreach (string key in table.Keys)
            {
                Console.WriteLine(String.Format("{0}", table[key].ToString()));
            }
        }
    }
}
