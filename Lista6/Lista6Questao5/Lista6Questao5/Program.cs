using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pnumero, snumero;
            string mensagem = "";
            int opcao;

            //lendo os numeros
            Console.WriteLine("Informar o 1 numero: ");
            pnumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informar o 2 numero: ");
            snumero = int.Parse(Console.ReadLine());

            //exibindo a mensagem 
            mensagem = "\n 1 - Media entre dois Numeros Digitados";
            mensagem = mensagem+"\n 2 - Diferença do maior pelo menor";
            mensagem = mensagem+"\n 3 - Produto entre os números digitados";
            mensagem = mensagem+"\n 4 - Divisao do primeiro pelo segundo";

            Console.WriteLine(mensagem);

            opcao = Int32.Parse(Console.ReadLine());

            //escolha
            switch (opcao)
            {
                case 1:
                    Console.WriteLine(" Media: {0} ",(pnumero+snumero)/2);
                    break;
                case 2:
                    Console.WriteLine("Diferenca do maior pelo menor: {0} ",Math.Abs(pnumero-snumero));
                    break;
                case 3:
                    Console.WriteLine("Produto: {0} ",pnumero*snumero);                    
                    break;
                case 4:
                    if(snumero>0)
                        Console.WriteLine("Divisao do primeiro pelo segundo: {0}",pnumero/snumero);
                    else
                        Console.WriteLine("Erro: divisao por Zero!");
                    break;

                default: Console.Write("\n Erro a escolha!");
                    break;
            }//switch

            Console.ReadKey();
            
        }
    }
}
