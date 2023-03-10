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

    public int Old { get; set; }

    public Animal()
    {
        NameAnimal = "Enzo";
        Rarety = "commun";
        Old = 19;
    }


    public abstract void Moove();

    public abstract void Sleep();

}


