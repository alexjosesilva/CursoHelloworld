using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis 
            double saldoMedio;

            //leitura 
            Console.WriteLine("Informe o saldo Medio : ");
            saldoMedio = double.Parse(Console.ReadLine());

            //condicional
            if (saldoMedio > 400)
            {
                Console.WriteLine("Saldo Medio Reajustado: {0}", saldoMedio + (saldoMedio * 0.30));
            }
            else if (saldoMedio <= 400 && saldoMedio > 300 )
            {
                Console.WriteLine("Saldo Medio Reajustado: {0}", saldoMedio + (saldoMedio * 0.25));
            }
            else if (saldoMedio <= 300 && saldoMedio > 200)
            {
                Console.WriteLine("Saldo Medio Reajustado: {0}", saldoMedio + (saldoMedio * 0.20));
            }
            else if (saldoMedio <= 200)
            {
                Console.WriteLine("Saldo Medio Reajustado: {0}", saldoMedio + (saldoMedio * 0.10));
            }

            Console.ReadLine();
        }
    }
}
