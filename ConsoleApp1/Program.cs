using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartament a1 = new Apartament();
            a1.camere = 3;
            a1.etaj = 2;
            a1.suprafata = 60.5f;
            a1.locparcare = 0;
            a1.baseImobil();
            a1.park();

            Casa a2 = new Casa();
            a2.camere = 4;
            a2.etaj = 2;
            a2.suprafata = 80.8f;
            a2.gradina = "gradia cu flori";
            a2.baseImobil();
            a2.sweet();

            Console.ReadKey();
        }
    }
}
