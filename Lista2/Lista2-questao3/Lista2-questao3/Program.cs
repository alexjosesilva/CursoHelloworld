using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2==0)
                Console.Out.WriteLine("Numero Par");
            else
                Console.Out.WriteLine("Numero Impar");
            Console.ReadKey();

        }
    }
}
