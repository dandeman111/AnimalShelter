using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class AnimalShelter 
    {
        public String Name { get; set; }

        public List<Animal> Animals { get;set;}

        public AnimalShelter()
        {
            this.Name = "shelterSkelter";
            
        }
        //honden of katten toevoegen
        public void addAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        public List<Animal> haalHonden()
        {
            List<Animal> dogs = new List<Animal>();
            foreach(Animal a in Animals)
            {
                if (a.GetType() == typeof(Dog))
                {
                    dogs.Add(a);
                }
            }
            return dogs;
        }
        public List<Animal> haalKatten()
        {
            List<Animal> cats = new List<Animal>();
            foreach (Animal a in Animals)
            {
                if (a.GetType() == typeof(Dog))
                {
                    cats.Add(a);
                }
            }
            return cats;
        }

        

    }
}
