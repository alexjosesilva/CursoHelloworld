using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
                Console.Out.WriteLine("Numero Maior: "+numero1);
            else
                Console.Out.WriteLine("Numero Maior: " + numero2);
            
            Console.ReadKey();
        }
    }
}
