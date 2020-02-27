using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Imobil
    {
        public int camere;
        public int etaj;
        public float suprafata;

        public void baseImobil()
        {
            Console.Write("Camere " + camere);
            Console.WriteLine("Etaj " + etaj);
            Console.WriteLine("Suprafata " + suprafata);
        }
    }

    class Apartament : Imobil
    {
        public int locparcare;
        public void park()
        { 
            Console.WriteLine("Apartament fara parcare");
        }
    }

    class Casa : Imobil
    {
        public string gradina;
        public void sweet()
        {
            Console.WriteLine("Casa cu gradina");
        }
    }
}
