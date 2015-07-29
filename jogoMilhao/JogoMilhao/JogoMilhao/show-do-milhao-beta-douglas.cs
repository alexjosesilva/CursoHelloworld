using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace show_do_milhão_beta
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            string[] perguntas = new string[16];
            string [] respostas = new string[16];


            Console.WriteLine("                      Bem vindo ao show do milhão");

            Console.WriteLine("  ");
            Console.WriteLine("Escolha o numero da categoria que você deseja");
            Console.WriteLine("  ");
            Console.WriteLine("1º) Historia");
            Console.WriteLine("2º) Geografia");
            Console.WriteLine("3º) Inglês");
            Console.WriteLine("4º) Português");
            Console.WriteLine("5º) Espanhol");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                perguntas[0] = "Presidente dos Estados Unidos durante a Guerra de 1914 – 1918:";
                respostas[0] = "c";
                perguntas[1] = "Qual dos fatores abaixo NÃO está ligado à I Guerra Mundial enquanto causa?";
                respostas[1] = "c";

                for (int cont = 0; cont <= 15; cont++)
                {
                     int premio= 1000,desistir;
                    string resposta;
                    Console.WriteLine("A 1 pergunta é : "+perguntas[cont]);
                    Console.WriteLine("a) Franklin Roosevelt     b) Churchill  ");
                    Console.WriteLine("c) Wilson                 d) Theodore Roosevelt");
                    resposta=Console.ReadLine();
                    Console.WriteLine(" ");
                    if (respostas[cont] == resposta) 
                    {
                        Console.WriteLine("Parabens você acertou seu premio é de: "+premio+" se deseja continuar aperte 1 se deseja parar aperte 2");
                        desistir = int.Parse(Console.ReadLine());
                        if (desistir == 2) 
                        { premio = 0;

                        Console.WriteLine("Você desistiu seu premio é de : "+premio);
                        cont = 43;
                        
                        }
                    }
                }
            }


            Console.ReadKey();
        }
        
    }
}
