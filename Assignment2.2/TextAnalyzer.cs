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

        public TextAnalyzer(string text)
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

        public override string ToString()
        {
            return text;
        }
    }
}
