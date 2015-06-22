using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiro = new int[5];
            int soma=0;

            //entrada de dados && soma dos dados
            for (int i = 0; i < arrayInteiro.Length; i++)
            {
                arrayInteiro[i] = int.Parse(Console.ReadLine());
                soma += arrayInteiro[i];
            }

            Console.WriteLine(" Soma: "+soma);
            Console.ReadKey();
        }
    }
}
