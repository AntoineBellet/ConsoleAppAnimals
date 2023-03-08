using System;
using System.Runtime.ConstrainedExecution;
using ConsoleAppAnimals.Models;
namespace ConsoleAppAnimals;

class Program
{


    static void Main(string[] args)
    {
        Griffin griffin = new Griffin("Tz"); 
        Griffin griffin1 = new Griffin("Lukas"); 
        
        
        Dragon dragon = new Dragon("Bastien");
        Dragon dragon1 = new Dragon();

        dragon.Move();
        dragon1.Sleep();

        griffin1.Sleep();
        griffin.Move();
    }

}
