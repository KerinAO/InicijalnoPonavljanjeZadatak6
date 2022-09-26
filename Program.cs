using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeZadatak6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brojClanova;
            double suma = 0;
            double broj = 1;

            Console.WriteLine("Unesi broj članova reda: ");
            brojClanova = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < brojClanova; i++)
            {
                broj = broj * 3;
                suma = suma + (1 / broj);
            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
