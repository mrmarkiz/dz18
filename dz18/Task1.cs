using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{
    internal class Task1
    {
        public static void Run()
        {
            List<int> array = new List<int>()
            {
                121,75,81,200,99,212
            };
            int choice;
            do
            {
                Console.WriteLine("Enter how to sort(1-by descending, 2-by ascending):");
                if (!int.TryParse(Console.ReadLine(), out choice))
                    break;
                switch (choice)
                {
                    case 1:
                        array.Sort(DigitComp);
                        array.Reverse();
                        break;
                    case 2:
                        array.Sort(DigitComp);
                        break;
                }
                Console.WriteLine("Current array:");
                Show(array, ", ");
            } while (true);
        }

        public static int DigitSum(int num)
        {
            int res = 0;
            while (num != 0)
            {
                res += num % 10;
                num /= 10;
            }
            return res;
        }

        public static void Show<T>(List<T> array, string sep)
        {
            Console.WriteLine(string.Join(sep, array));
        }
        private static int DigitComp(int x, int y)
        {
            if (DigitSum(x) < DigitSum(y))
                return -1;
            if (DigitSum(x) > DigitSum(y))
                return 1;
            return 0;
        }
    }
}
