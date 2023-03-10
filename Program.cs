using System;
using System.Runtime.ConstrainedExecution;
using ConsoleAppAnimals.Models;
namespace ConsoleAppAnimals;

class Program
{


    static void Main(string[] args)
    {
        Griffin tz = new("Tz","rare",18); 
        Griffin lukas = new("Lukas", "bb", 19); 
        
        
        Dragon bastien = new("Bastien", "chiant", 22);
        Dragon yannis = new("Yannis", "arabe", 18);

        List<Dragon> listDragon = new();
        listDragon.Add(bastien);
        listDragon.Add(yannis);

        List<Griffin> listGriffin = new();
        listGriffin.Add(tz);
        listGriffin.Add(lukas);

        var dragon = listDragon.Select(dragon => (dragon.NameAnimal, dragon.Rarety, dragon.Old));
        var griffin= listGriffin.Select(griffin => (griffin.NameAnimal, griffin.Rarety, griffin.Old));

        foreach (var l1 in dragon)
        {
            Console.WriteLine(l1);
        }
        foreach (var l2 in griffin)
        {
            Console.WriteLine(l2);
        }

        

        List<Chien> listeChiens = new()
{
            new Chien("Rex","commun", 12),
            new Chien("Max","commun",8),
            new Chien("Bella", "commun", 17),
            new Chien("Charlie", "commun", 7),
            new Chien("Snow", "commun", 15)
};
        var chiens = listeChiens.Where(chien => chien.Old <= 15 && chien.Old >= 10).Select(chien => (chien.NameAnimal, chien.Old));
        foreach (var nomChien in chiens)
        {
            Console.WriteLine(nomChien);
        }


    }

}
