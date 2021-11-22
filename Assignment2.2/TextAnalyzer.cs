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
                char c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }
            this.text = builder.ToString();
        }

        public List<string> CountLetters(string text)
        {
            // Array to store frequencies.
            int[] freq = new int[(int)char.MaxValue];

            

            // Iterate over each character.
            foreach (char t in text)
            {
                // Increment table.
                freq[(int)t]++;
            }

            

            List<string> ready = new List<string>();
            // Write all letters found.
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (freq[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    string temp = "Letter: " + (char)i + " Frequency: " + freq[i];
                    ready.Add(temp);
                }
            }
            return ready;
        }
        
        public override string ToString()
        {
            return text;
        }
    }
}
