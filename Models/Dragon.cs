using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimals.Interfaces;

namespace ConsoleAppAnimals.Models;

public class Dragon : Animal, IPilotage
{
    public Dragon(string name, string rarety, int old)
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
        Console.WriteLine($"{NameAnimal} se repose en haut de son donjon.");
    }
}
