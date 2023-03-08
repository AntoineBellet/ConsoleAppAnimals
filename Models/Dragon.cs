using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimals.Interfaces;

namespace ConsoleAppAnimals.Models;

public class Dragon : Animal, IPilotage
{
    public Dragon() : base() { }

    public Dragon(string name) : base(name) { }

    public override void Moove()
    {
        Console.WriteLine($"{Name} vole de ses propres ailes !");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} se repose en haut de son donjon.");
    }
}
