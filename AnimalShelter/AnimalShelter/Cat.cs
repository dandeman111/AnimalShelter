using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public class Cat : Animal
    {
        public String Badhadbits { get; set; }

        public Cat(String name, bool isman, int age, String badhabits): base(name , isman, age)
        {
            this.Badhadbits = badhabits;
        }
    }
}
