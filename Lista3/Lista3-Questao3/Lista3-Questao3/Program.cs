using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Out.WriteLine("Resultado da divisao: "+(numero1/numero2));

            Console.ReadKey();
        }
    }
}
