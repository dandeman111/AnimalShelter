using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public class Dog : Animal
    {
        public DateTime lastwalk { get; set; }

        public Dog(String name, bool isman, int age):base(name,isman,age)
        {

        }
        public void walkDog(DateTime time)
        {
            lastwalk = time;
        }
    }
}
