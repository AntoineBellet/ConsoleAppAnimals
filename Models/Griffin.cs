using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimals.Models;

namespace ConsoleAppAnimals.Models;

public class Griffin : Animal
{
    public Griffin() : base() { }

    public Griffin(string name) : base(name) { }


    public override void Moove()
    {
        Console.WriteLine($"{Name} vole de ses propres ailes !");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} est perché !");
    }
}
