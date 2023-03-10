using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimals.Models;

namespace ConsoleAppAnimals.Models;

public class Griffin : Animal
{
    public Griffin(string name, string rarety, int old)
    {
        NameAnimal = name;
        Rarety = rarety;
        Old = old;
    }


    public override void Moove()
    {
        Console.WriteLine($"{NameAnimal} vole de ses propres ailes !");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{NameAnimal} est perché !");
    }
}
