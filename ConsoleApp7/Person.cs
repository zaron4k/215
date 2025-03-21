using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// абстрактная персона
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Абстрактный Скажи привет
        /// </summary>
        public abstract void SayHello();
    }
}
