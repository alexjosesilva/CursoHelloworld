using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4) Ler diversos números reais e exibir a quantidade e o somatório total dos números digitados. 
// O valor -1 é o código de fim de entrada. 
namespace Lista5_Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd=0;
            float soma=0;
            float numero;

            do{
                Console.Write("\n ");
                numero = float.Parse(Console.ReadLine());
                if (numero!=-1)
                {
                    soma += numero;
                    qtd++;     
                }
               
                
            } while (numero != -1);

            Console.Write("\n Quantidade: {0} Soma:{1} ",qtd,soma);
            Console.ReadKey();

        }
    }
}
