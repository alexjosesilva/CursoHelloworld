using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao17
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            double pi = 3.14;

            R = double.Parse(Console.ReadLine());

            Console.WriteLine("Area do Circulo: " + (2 * pi));
            Console.WriteLine("Area do Circulo: " + (pi * (Math.Pow(R, 2))));
            Console.WriteLine("Volume do Circulo: " + (3 * (pi * (Math.Pow(R, 3)))) / 4);

            Console.ReadKey();
        }
    }
}
