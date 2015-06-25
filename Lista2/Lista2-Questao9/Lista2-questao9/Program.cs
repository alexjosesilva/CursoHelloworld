using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis do sistema
            double peso, imc, pesoIdealMin, pesoIdealMax;
            int  altura;
            Boolean flag=false;

            //obtenção de dados
            Console.Out.Write("Informar o peso(gramas): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Out.Write("Informar a altura(cm): ");
            altura = Convert.ToInt32(Console.ReadLine());

            //calcudo do IMC
            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                Console.Out.WriteLine("Abaixo do Peso");
                flag = true;
            }
            else
                if (imc >= 18.5 && imc < 25)
                    Console.Out.WriteLine("Peso Normal");
                else
                    if (imc >= 25 && imc < 30)
                    {
                        Console.Out.WriteLine("Excesso Peso");
                        flag = true;
                    }
                    else
                        if (imc >= 30 && imc < 35)
                        {
                            Console.Out.WriteLine("Obesidade 1");
                            flag = true;
                        }
                        else
                            if (imc >= 35 && imc < 40)
                            {
                                Console.Out.WriteLine("Obesidade 2");
                                flag = true;
                            }
                            else
                                if (imc >= 40)
                                {
                                    Console.Out.WriteLine("Obesidade 3");
                                    flag = true;
                                }

            

            //Informar Peso normal
            if (flag == true){
                switch (altura)
                {
                    case 150:
                        pesoIdealMin = 42;
                        pesoIdealMax = 56;
                        Console.WriteLine("Peso IdealMinimo: "+pesoIdealMin+" Peso IdealMaximo: "+pesoIdealMax);
                        break;
                    case 152:
                        pesoIdealMin = 43;
                        pesoIdealMax = 57;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 154:
                        pesoIdealMin = 44;
                        pesoIdealMax = 59;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 156:
                        pesoIdealMin = 46;
                        pesoIdealMax = 60;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 158:
                        pesoIdealMin = 47;
                        pesoIdealMax = 62;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 160:
                        pesoIdealMin = 48;
                        pesoIdealMax = 64;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 162:
                        pesoIdealMin = 49;
                        pesoIdealMax = 65;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 164:
                        pesoIdealMin = 50;
                        pesoIdealMax = 67;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 166:
                        pesoIdealMin = 51;
                        pesoIdealMax = 68;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 168:
                        pesoIdealMin = 53;
                        pesoIdealMax = 70;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 170:
                        pesoIdealMin = 54;
                        pesoIdealMax = 72;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 172:
                        pesoIdealMin = 55;
                        pesoIdealMax = 73;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 174:
                        pesoIdealMin = 57;
                        pesoIdealMax = 75;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 176:
                        pesoIdealMin = 58;
                        pesoIdealMax = 77;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 178:
                        pesoIdealMin = 59;
                        pesoIdealMax = 79;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 180:
                        pesoIdealMin = 60;
                        pesoIdealMax = 81;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 182:
                        pesoIdealMin = 62;
                        pesoIdealMax = 82;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 184:
                        pesoIdealMin = 63;
                        pesoIdealMax = 84;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 186:
                        pesoIdealMin = 65;
                        pesoIdealMax = 86;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 188:
                        pesoIdealMin = 66;
                        pesoIdealMax = 88;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 190:
                        pesoIdealMin = 67;
                        pesoIdealMax = 90;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 192:
                        pesoIdealMin = 69;
                        pesoIdealMax = 92;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 194:
                        pesoIdealMin = 70;
                        pesoIdealMax = 94;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 196:
                        pesoIdealMin = 72;
                        pesoIdealMax = 96;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 198:
                        pesoIdealMin = 73;
                        pesoIdealMax = 98;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    case 200:
                        pesoIdealMin = 74;
                        pesoIdealMax = 100;
                        Console.WriteLine("Peso Ideal Minimo: " + pesoIdealMin + " Peso Ideal Maximo: " + pesoIdealMax);
                        break;
                    default:
                        Console.WriteLine("Fora da Tabela OMS");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
