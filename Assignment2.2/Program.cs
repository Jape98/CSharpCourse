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
            List<string> letters = new List<string>();
            TextAnalyzer rand = new TextAnalyzer();
            Console.WriteLine("Random String: " + rand.ToString());

            letters = rand.CountLetters(rand.ToString());

            foreach (var letter in letters)
            {
                Console.Write(letter + "\n");
            }
        }
    }
}
