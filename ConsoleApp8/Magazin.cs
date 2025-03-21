using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Magazin : Printedproducts
    {
        private int circulation;
        private double price;
        

        public Magazin() { }

      

        public Magazin(string name, int circulation, double price) : base(name)
        {
            this.Circulation = circulation; Price = price;
        }
        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override double Cost()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
