using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Questao 3: Mostar Menor numero
namespace Lista6Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pnumero, snumero, maior;

            pnumero = Int32.Parse(Console.ReadLine());
            snumero = Int32.Parse(Console.ReadLine());

            if (pnumero<snumero)
            {
                Console.Write("\n Menor: {0} ", pnumero);
            }
            else
            {
                Console.Write("\n Menor: {0} ", snumero);
            }
           
            Console.ReadKey();
        }
    }
}
