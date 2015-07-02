using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            double pnumero, snumero;
            string mensagem = " ";
            int opcao;

            //Leitura
            Console.WriteLine("Inserir 1 numero: ");
            pnumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserir 2 numero: ");
            snumero = int.Parse(Console.ReadLine());

            //Menu
            mensagem = "\n 1 - Media entre dois Numeros ";
            mensagem = mensagem + "\n 2 - Diferença entre dois numeros";
            mensagem = mensagem + "\n 3 - O produto entre os dois numeros";
            Console.WriteLine(mensagem);
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Media: {0}", (pnumero+snumero)/2);
                    break;
                case 2:
                    Console.WriteLine("Diferenca: {0}",Math.Abs(pnumero-snumero));
                    break;
                case 3:
                    Console.WriteLine("Produto: {0}",pnumero*snumero);
                    break;
                default:
                    Console.WriteLine("Erro: escolha invalida!");
                    break;
            }

            

            Console.ReadKey();

        }
    }
}
