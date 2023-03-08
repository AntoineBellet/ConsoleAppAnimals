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

        

        List<Chien> listeChiens = new List<Chien>()
{
            new Chien("Rex"),
            new Chien("Max"),
            new Chien("Bella"),
            new Chien("Charlie"),
            new Chien("Snow")
};
        var chiens = listeChiens.Where(chien => chien.Name != "Snow").Select(chien => chien.Name);
        foreach (var nomChien in chiens)
        {
            Console.WriteLine(nomChien);
        }


    }

}
