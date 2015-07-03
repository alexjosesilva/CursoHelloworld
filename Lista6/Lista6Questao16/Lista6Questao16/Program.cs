using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao16
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            preco = double.Parse(Console.ReadLine());

            if (preco <= 30)
            {
                preco += preco * 0;
            }
            else if (preco > 30 && preco < 100)
            {
                preco -= preco*0.10;
            }
            else if (preco > 100)
            {
                preco -= preco * 0.15;
            }

            Console.WriteLine("Preco com Desconto: {0:C}", preco);
            Console.ReadKey();
	{
		 
	}

        }
    }
}
