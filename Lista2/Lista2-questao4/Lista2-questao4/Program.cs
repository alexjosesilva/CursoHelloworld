using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                if (numero % 2 == 0)
                    Console.Out.WriteLine("Numero Positivo e Par!");
                else
                    Console.Out.WriteLine("Numero Positivo e Impar!");
            }
            else
            {
                if (numero % 2 == 0)
                    Console.Out.WriteLine("Numero Negativo e Par!");
                else
                    Console.Out.WriteLine("Numero Negativo e Impar!");

            }
            Console.ReadKey();



        }
    }
}
