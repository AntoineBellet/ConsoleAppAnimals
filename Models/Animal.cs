using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimals.Models;

namespace ConsoleAppAnimals.Models;

public abstract class Animal
{

    public string NameAnimal { get; set; }
    
    public string Rarety { get; set; }

    public Animal()
    {
         NameAnimal = "Enzo";
         Rarety = "commun";
    }

    public Animal(string name, string rarety)
    {
        NameAnimal = name;
        Rarety = rarety;
    }

    public abstract void Moove();

    public abstract void Sleep();

}


