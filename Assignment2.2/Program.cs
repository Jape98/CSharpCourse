using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;
            TextAnalyzer rand = new TextAnalyzer(text);

            Console.WriteLine("Random String: " + rand.ToString());
        }
    }
}
