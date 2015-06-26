using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Soma dos Angulos internos de um triangulo

namespace Lista3_Questao23
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo1, angulo2,angulo3;

            angulo1 = double.Parse(Console.ReadLine());
            angulo2 = double.Parse(Console.ReadLine());

            angulo3 = 180 - (angulo1 + angulo2);

            Console.Write("\n Angulo 3: {0}", angulo3);
            Console.ReadKey();
            
        }
    }
}
