using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao19
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            int sexo;
            string mensagem = "";

            Console.WriteLine("informar a altura: ");
            altura = double.Parse(Console.ReadLine());
            
            mensagem = "\n 1-Homem";
            mensagem = mensagem + "\n 2-Mulher";

            Console.WriteLine(mensagem);
            Console.WriteLine("Informar a sexo: ");
            sexo = int.Parse(Console.ReadLine());

            switch (sexo)
            {
                case 1:
                    Console.WriteLine("Peso ideal Homem: {0:F}",(72.7*altura)-58);
                    break;
                case 2:
                    Console.WriteLine("Peso ideal Homem: {0:F}",(62.1*altura)-44.7);
                    break;
                default: 
                    Console.WriteLine("Erro na Escolha do Sexo!");
                    break;
            }

            Console.ReadKey();


        }
    }
}
