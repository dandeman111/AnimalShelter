using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat : Animal
    {
        public string badhadbits { get; set; }

        public Cat(String name, bool isman, int age, string badhabits): base(name , isman, age)
        {
            this.badhadbits = badhadbits;
        }
    }
}
