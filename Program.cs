using System;
using System.Runtime.ConstrainedExecution;
using ConsoleAppAnimals.Models;
namespace ConsoleAppAnimals;

class Program
{


    static void Main(string[] args)
    {
        Animal animal1 = new Animal();         
        Animal animal2 = new Animal();

        animal1.Name();
        animal2.Name("Bastien");
        animal1.Move();
        animal2.Sleep();
    }

}
