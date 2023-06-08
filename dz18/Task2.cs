using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{
    internal class Task2
    {
        public static void Run()
        {
            List<string> countries1 = new List<string>()
            {
                "Ukraine",
                "Poland",
                "Germany",
                "Autria",
                "Australia",
                "Sweden",
                "Poland"
            };
            List<string> countries2 = new List<string>()
            {
                "USA",
                "UK",
                "Germany",
                "Ireland",
                "French",
                "Sweden"
            };
            Console.WriteLine("\nFirst country list:");
            Task1.Show(countries1, "\n");
            Console.WriteLine("Second country list:");
            Task1.Show(countries2, "\n");
            Console.WriteLine("\nCountries from first list not found in second:");
            Task1.Show(countries1.Where(count => !countries2.Exists(el => el == count)).ToList(), "\n");

            Console.WriteLine("\nCountries from first list found in second:");
            Task1.Show(countries1.Where(count => countries2.Exists(el => el == count)).ToList(), "\n");

            Console.WriteLine("\nCountries from both list without reps:");
            Task1.Show(countries1.Concat(countries2).Distinct().ToList(), "\n");


            Console.WriteLine("\nCountries from first list without reps:");
            Task1.Show(countries1.Distinct().ToList(), "\n");

        }
    }
}
