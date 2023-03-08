using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models
{
    public class Vehicule
    {
        public void Embarquement()
        {
            Console.WriteLine("J'embarque !");
        }
        public void Moove()
        {
            Console.WriteLine("J'avance!");
        }
        public void Stop()
        {
            Console.WriteLine("Je m'arrête !");
        }

    }
}
