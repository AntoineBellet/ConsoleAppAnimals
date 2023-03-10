using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models
{
    public class Chien : Animal 
    {
        public Chien() 
        {
        
        }

        public Chien(string name) 
        {
            NameAnimal = name;
        }

        public override void Moove()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
