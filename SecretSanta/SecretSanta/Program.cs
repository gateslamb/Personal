using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Bryndi", "Jez", "Taryn", "Tyvor", "Texy", "Tyzek",
                "Garson", "Ashton", "Asher", "Nova", "Colette", "Gunnar", "Syndey", "Lennon", "Silas", "Madi",
                "Gates", "Hannah", "Graci"};

            List<string> matches = new List<string> { "Bryndi", "Jez", "Taryn", "Tyvor", "Texy", "Tyzek",
                "Garson", "Ashton", "Asher", "Nova", "Colette", "Gunnar", "Syndey", "Lennon", "Silas", "Madi",
                "Gates", "Hannah", "Graci"};

            int count = names.Count();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                string first = names[i];
                int two = rnd.Next(0, matches.Count());
                string second = matches[two];
                while (first.Equals(second))
                {
                    two = rnd.Next(0, matches.Count());
                    second = names[two];
                }
                matches.Remove(second);
                Console.WriteLine(first + " has " + second + "\n");
            }
            Console.ReadLine();
        }
    }
}
