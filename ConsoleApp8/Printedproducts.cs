using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class Printedproducts
    {
        private string name;
        public Printedproducts() { }
        public Printedproducts(string name) { Name = name; }
        public string Name
        {
            get { return name; }
            set { name = (value != "") ? value : "soName"; } }
        public abstract void Print();
        public abstract double Cost();

        }
    }
