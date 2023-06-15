using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{
    internal class Task3
    {
        public static void Run()
        {
            List<Gadget> gadgets1 = new List<Gadget>()
            {
                new Gadget("TV", "LG", 2000),
                new Gadget("Iphone", "Apple", 1200),
                new Gadget("Kettle", "Electro CO", 20),
                new Gadget("Laptop", "Asus", 500),
                new Gadget("Laptop", "Aser", 600)
            };
            List<Gadget> gadgets2 = new List<Gadget>()
            {
                new Gadget("Shoes drier", "Electro CO", 15),
                new Gadget("Fen", "El ink", 25),
                new Gadget("Razor", "China", 13),
                new Gadget("3d Printer", "Printy", 1800),
            };
            List<Gadget> result;

            Console.WriteLine("First list elements:");
            Task1.Show(gadgets1, "\n");
            Console.WriteLine("\nSecond list elements:");
            Task1.Show(gadgets2, "\n");

            Console.WriteLine("\nElements from first list not found in second:");
            result = gadgets1.Where(gad => gadgets2.FindIndex(el => el.Manufacturer == gad.Manufacturer) == -1).ToList();
            Task1.Show(result, "\n");

            Console.WriteLine("\nCommon elements for two lists:");
            result = gadgets1.Where(gad => gadgets2.FindIndex(el => el.Manufacturer == gad.Manufacturer) != -1).ToList();
            Task1.Show(result, "\n");

            Console.WriteLine("\nDistinct elements from two lists:");
            result = gadgets1.Concat(gadgets2).DistinctBy(el => el.Manufacturer).ToList();
            Task1.Show(result, "\n");
        }
    }

    internal class Gadget
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public Gadget(string name, string manufacturer, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public Gadget() : this("", "", 0)
        { }

        public override string ToString()
        {
            return $"{Name};{Manufacturer};{Price}";
        }
    }
}
