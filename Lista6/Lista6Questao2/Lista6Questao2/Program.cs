using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis da classe
            double pnota, snota, media;
            string mensagem = "";

            //recebendo a 1 nota
            Console.WriteLine("\n inserir a 1 nota:");
            pnota = Int32.Parse(Console.ReadLine());

            //recebendo a 2 nota
            Console.WriteLine("\n inserir a 2 nota:");
            snota = Int32.Parse(Console.ReadLine());
     

            //Calculo
            media = (pnota + snota) / 2;
            Console.WriteLine("Media do aluno: {0}", media);

            mensagem = "\n 0,0 |--- 4,0    Reprovado ";
            mensagem = "\n 4,0 |--- 7,0    Exame " + mensagem;
            mensagem = "\n 7,0 |--- 10,0   Aprovado " + mensagem;

            Console.WriteLine(mensagem);            
            
            Console.ReadKey();
        }
    }
}
