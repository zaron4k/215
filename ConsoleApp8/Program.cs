using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Printedproducts> price = new List<Printedproducts>();
            price.Add(new Magazin (111));
            price.Add(new Newspaper (333));
            foreach (Printedproducts printedprodects in price)
                printedproducts.SayHello();
            Console.ReadLine();
        }
    }
}
