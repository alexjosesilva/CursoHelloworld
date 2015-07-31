using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Matematica:Perguntas
    {
        List<Matematica> mat = new List<Matematica>();

        public Matematica()
        {
                
        }

        public Matematica(string pergunta, string alt1, string alt2, string alt3, string alt4, string resp){

            this.Pergunta = pergunta;
            this.Resp = resp;
            this.Alt1 = alt1;
            this.Alt2 = alt2;
            this.Alt3 = alt3;
            this.Alt4 = alt4; 
        }

        public void listaPerguntas()
        {
            mat.Add(new Matematica("Qual o valor da soma 1+1","A-2","B-0","C-100","D- -2","A"));
            mat.Add(new Matematica("Qual o valor da soma 10+10", "A-2", "B-20", "C-100", "D- -2", "B"));
            mat.Add(new Matematica("Qual o valor da divisao 2/2", "A-2", "B-0", "C-1", "D- -2", "C"));
            mat.Add(new Matematica("Qual o valor da subtracao 0-0", "A-2", "B-0", "C-100", "D-0", "D"));

            mat.Add(new Matematica("Qual o valor da soma 2*2", "A-4", "B-0", "C-100", "D- -2", "A"));
            mat.Add(new Matematica("Qual o valor da produto 10*10", "A-2", "B-100", "C-100", "D- -2", "B"));
            mat.Add(new Matematica("Qual o valor da divisao 20/20", "A-2", "B-0", "C-1", "D- -2", "C"));
            mat.Add(new Matematica("Qual o valor da subtracao 0-10", "A-2", "B-0", "C-100", "D- -10", "D"));

            mat.Add(new Matematica("Qual o valor da soma 3+3", "A-6", "B-0", "C-100", "D- -2", "A"));
            mat.Add(new Matematica("Qual o valor da soma 11+11", "A-2", "B-22", "C-100", "D- -2", "B"));
            mat.Add(new Matematica("Qual o valor da divisao 11/11", "A-2", "B-0", "C-1", "D- -2", "C"));
            mat.Add(new Matematica("Qual o valor da subtracao 11-11", "A-2", "B-0", "C-100", "D-0", "D"));

            mat.Add(new Matematica("Qual o valor da soma 9+9", "A-18", "B-0", "C-100", "D- -2", "A"));
            mat.Add(new Matematica("Qual o valor da soma 110+110", "A-2", "B-220", "C-100", "D- -2", "B"));
            mat.Add(new Matematica("Qual o valor da divisao 110/110", "A-2", "B-0", "C-1", "D- -2", "C"));
            mat.Add(new Matematica("Qual o valor da subtracao 110-110", "A-2", "B-0", "C-100", "D-0", "D"));


        }
    }
}
