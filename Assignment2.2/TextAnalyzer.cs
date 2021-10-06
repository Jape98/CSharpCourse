using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class TextAnalyzer
    {
        string text;
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public TextAnalyzer()
        {
            const string pool = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < 50; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }
            this.text = builder.ToString();
        }

        public List<string> CountLetters(string text)
        {
            // Array to store frequencies.
            int[] c = new int[(int)char.MaxValue];

            var letters = new List<string>();

            // Iterate over each character.
            foreach (char t in text)
            {
                // Increment table.
                c[(int)t]++;
            }

            // Write all letters found.
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    string temp = "Letter: " + (char)i + " Frequency: " + c[i];
                    letters.Add(temp);
                }
            }
            return letters;
        }
        
        public override string ToString()
        {
            return text;
        }
    }
}
