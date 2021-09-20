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

            title = "title1"; table.Add(title, new Concert(title, "location1", 50, new DateTime(2021, 9, 20, 18, 0 ,0)));
            title = "title2"; table.Add(title, new Concert(title, "location2", 60, new DateTime(2021, 9, 20, 19, 0, 0)));
            title = "title3"; table.Add(title, new Concert(title, "location3", 70, new DateTime(2021, 9, 20, 20, 0, 0)));
            title = "title4"; table.Add(title, new Concert(title, "location4", 80, new DateTime(2021, 9, 20, 21, 0, 0)));
            title = "title5"; table.Add(title, new Concert(title, "location5", 90, new DateTime(2021, 9, 20, 22, 0, 0)));

            Console.WriteLine(tempDate.ToString("MMMM dd, yyyy"));


            foreach (string key in table.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1}", key, table[key].ToString("MMMM dd, yyyy")));
            }
        }
    }
}
