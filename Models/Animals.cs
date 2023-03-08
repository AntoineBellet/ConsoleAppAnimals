using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimals.Models;

namespace ConsoleAppAnimals.Models;

public abstract class Animal
{

    private string NameAnimal;

    public Animal()
    {
         NameAnimal = "Enzo";
    }

    public Animal(string name)
    {
        NameAnimal = name;
    }
    public string Name
    {
        get { return NameAnimal; }
        private set { NameAnimal = value; }
    }

    public abstract void Move();

    public abstract void Sleep();

}


