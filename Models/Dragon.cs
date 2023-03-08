using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models;

public class Dragon : Animal
{
    public Dragon() : base() { }

    public Dragon(string name) : base(name) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} Fly !");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} rests on a bed of hot coals.");
    }
}
