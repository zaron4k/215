using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Newspaper
    {
        private int numberofsheets;
        private double costpersheets;
        private double circulation;
        

        public Newspaper() { }

       
        public Newspaper(string name, int numberofsheets, double costpersheets, double circulation) : base()
        {
            this.Numberofsheets = numberofsheets;
            this.Costpersheets = costpersheets;
            this.Circulation = circulation; ;
        }
        public int Numberofsheets
        {
            get { return numberofsheets; }
            set { numberofsheets = value; }
        }
        public double Costpersheets
        {
            get { return costpersheets; }
            set { costpersheets = value; }
        }
        public double Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }

    }
}
