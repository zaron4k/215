using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class English : Person
    {
        public English(string name) { Name = name; }
        public override void SayHello()
        {
            throw new NotImplementedException();
            {
                Console.WriteLine($"{Name} say: Hello!");
            }
        }
    }
}
