using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis do sistema
            double peso, imc,altura;
            int idade;
            
            //obtenção de dados
            Console.Out.Write("Informar o peso(KG): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Out.Write("Informar a altura(M): ");
            altura = Convert.ToDouble(Console.ReadLine());
            
            Console.Out.Write("Informar a idade(anos): ");
            idade = Convert.ToInt32(Console.ReadLine());
           

            //calcudo do IMC
            imc = peso / Math.Pow(altura,2);

            if (imc < 18.5)
                Console.Out.WriteLine("Abaixo do Peso");
            else
                if(imc >= 18.5 && imc<25)
                    Console.Out.WriteLine("Peso Normal");
            else
                if(imc>=25 && imc<30)
                    Console.Out.WriteLine("Excesso Peso");
            else
                if(imc>=30 && imc<35)
                    Console.Out.WriteLine("Obesidade 1");
            else
                if(imc>=35 && imc<40)
                    Console.Out.WriteLine("Obesidade 2");
           else
                if(imc>=40)
                    Console.Out.WriteLine("Obesidade 3");
            
            Console.ReadKey();

        }
    }
}
