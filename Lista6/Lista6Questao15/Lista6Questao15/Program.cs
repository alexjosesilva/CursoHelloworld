using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double valorInvestimento;
            int tipo;
            string mensagem = "";

            //leitura
            Console.WriteLine("Informe o valor do investimento: ");
            valorInvestimento = double.Parse(Console.ReadLine());

            mensagem = "\n 1-Poupança ";
            mensagem = mensagem + "\n 2-Fundo de Renda Fixa ";

            Console.WriteLine(mensagem);
            tipo = int.Parse(Console.ReadLine());


            switch (tipo)
            {
                case 1:
                    Console.WriteLine("Poupança - Resultado: {0} ", valorInvestimento + (valorInvestimento * 0.03));
                    break;
                case 2:
                    Console.WriteLine("Fundo de Renda Fixa - Resultado: {0} ", valorInvestimento + (valorInvestimento * 0.04));
                    break;
                default:
                    Console.WriteLine("Erro:Escolha invalida!");
                    break;

            }
            Console.ReadKey();  
        }
    }
}
