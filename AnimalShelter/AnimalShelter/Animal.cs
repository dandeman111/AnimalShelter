using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Animal
    {
        protected String animalName;
        protected bool gereserveerd;
        protected bool isman;
        protected int age;



        public String AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }


        public bool Gereserveerd
        {
            get { return this.gereserveerd; }
            set { this.gereserveerd = value; }
        }
        public bool IsMan
        {
            get { return this.isman; }    
        }
        public int Age
        {
            get { return this.age; }
        }


        public Animal(string name, bool isman, int age)
        {
            this.AnimalName = name;
            this.isman = isman;
            this.Gereserveerd = false;
            this.age = age;
        }

    }
   
}
