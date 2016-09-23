using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class AnimalShelter
    {
        public String Name { get; set; }

        public List<Animal> Animals { get;set;}

        public AnimalShelter()
        {
            this.Name = "shelterSkelter";
            
        }
        // de honden en katten appart in de lijst van dieren doen
        public void addAnimal(Dog dog)
        {
            Animals.Add(dog);

        }
        public void addAnimal(Cat cat)
        {
            Animals.Add(cat);
        }
        //of moet ik het zo doen
        public void addAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        

    }
}
