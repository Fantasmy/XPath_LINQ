using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpath
{
    class Dog
    {
        public string Race { get; set; }

        public string Age { get; set; }
        public string Name { get; set; }

        // constructor sin parámetros
        public Dog() { }

        // constructor con parámetros
        public Dog( string race, string Age, string Name)
        {
            this.Race = Race;
            this.Age = Age;
            this.Name = Name;

        }
    }
}
