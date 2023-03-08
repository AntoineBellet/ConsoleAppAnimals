using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models
{
    class Animal
    {
        private string NameAnimal;

        public string Name()
        {
            NameAnimal = "Enzo";
            return NameAnimal;
        }

        public string Name(string name)
        {
            this.NameAnimal = name;
            return NameAnimal;
        }

        public void Move()
        {
            Console.WriteLine(this.NameAnimal + " Move !");
        }

        public void Sleep()
        {
            Console.WriteLine(this.NameAnimal + " Sleep !");
        }

    }
}
