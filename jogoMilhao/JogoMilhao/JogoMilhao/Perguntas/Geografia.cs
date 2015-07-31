using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Geografia:Perguntas
    {
        public List<Geografia> geo = new List<Geografia>();

        public Geografia(string pergunta, string alt1, string alt2, string alt3, string alt4, string resp)
        {
            this.Pergunta = pergunta;
            this.Resp = resp;
            this.Alt1 = alt1;
            this.Alt2 = alt2;
            this.Alt3 = alt3;
            this.Alt4 = alt4;

        }

        public Geografia ()
	    {

	    }

        public void listaPerguntas()
        {
            geo.Add(new Geografia("\n Qual a capital do Brasil ?","\n A- Recife","\n B-Maceio","\n C-Brasilia","\n D-Sao Paulo","C"));
            geo.Add(new Geografia("\n Qual a capital do Brasil Como se chama o lago salgado, que é parte mais baixa da Terra, situado na Palestina?", "\n A- Mar Morto", "\n B- Mar Cáspio", "\n C-Mar Mediterrâneo", "\n D-SMar do Caribeo", "A"));
            geo.Add(new Geografia("\n Qual a capital do Pernambuco ?", "\n A- Recife", "\n B-Maceio", "\n C-Brasilia", "\n D-Sao Paulo", "A"));
            geo.Add(new Geografia("\n Qual a capital do Alagoas  ?", "\n A- Recife", "\n B-Maceio", "\n C-Brasilia", "\n D-Sao Paulo", "B"));
            
            geo.Add(new Geografia("\n Qual a capital do Ceara  ?", "\n A- Recife", "\n B-Maceio", "\n C-Fortaleza", "\n D-Sao Paulo", "C"));
            geo.Add(new Geografia("\n Qual a capital do Bahia  ?", "\n A- Recife", "\n B-Maceio", "\n C-Fortaleza", "\n D-Salvador", "D"));
            geo.Add(new Geografia("\n Qual a capital do Tocantis  ?", "\n A- Palmas", "\n B-Maceio", "\n C-Fortaleza", "\n D-Salvador", "A"));
            geo.Add(new Geografia("\n Qual a capital do Rio Grande do Norte  ?", "\n A- Recife", "\n B-Natal", "\n C-Fortaleza", "\n D-Salvador", "B"));

            geo.Add(new Geografia("\n Qual a capital da Amazonas  ?", "\n A- Manaus", "\n B-Maceio", "\n C-Fortaleza", "\n D-Sao Paulo", "A"));
            geo.Add(new Geografia("\n Qual a capital do Acre  ?", "\n A- Recife", "\n B-Rio Branco", "\n C-Fortaleza", "\n D-Salvador", "B"));
            geo.Add(new Geografia("\n Qual a capital do Rio Grande do Sul  ?", "\n A- Palmas", "\n B-Maceio", "\n C-Campo Grande", "\n D-Salvador", "C"));
            geo.Add(new Geografia("\n Qual a capital de Goias  ?", "\n A- Recife", "\n B-Natal", "\n C-Fortaleza", "\n D-Goiana", "D"));

            geo.Add(new Geografia("\n Qual a capital do Rio de Janeiro  ?", "\n A- Rio de Janeiro", "\n B-Maceio", "\n C-Fortaleza", "\n D-Sao Paulo", "A"));
            geo.Add(new Geografia("\n Qual a capital do Sao Paulo  ?", "\n A- Recife", "\n B-Sao Paulo", "\n C-Fortaleza", "\n D-Salvador", "B"));
            geo.Add(new Geografia("\n Qual a capital de Acre  ?", "\n A- Palmas", "\n B-Maceio", "\n C-Rio Branco", "\n D-Salvador", "C"));
            geo.Add(new Geografia("\n Qual a capital do Roraima  ?", "\n A- Recife", "\n B-Natal", "\n C-Fortaleza", "\n D-Boa Vista", "D"));
        }
    }
}
