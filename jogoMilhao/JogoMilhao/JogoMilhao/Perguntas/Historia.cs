using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Historia:Perguntas
    {
        public List<Historia> his = new List<Historia>();
        
        public Historia()
        {
                
        }

        public Historia(string pergunta, string alt1, string alt2, string alt3, string alt4, string resp)
        {
            this.Pergunta = pergunta;
            this.Resp = resp;
            this.Alt1 = alt1;
            this.Alt2 = alt2;
            this.Alt3 = alt3;
            this.Alt4 = alt4;  
        }

        public void listaPerguntas()
        {
            his.Add(new Historia("Qual a data do descobrimento do Brasil ?", "A-1500", "B-2015", "C-1888", "D-1815", "A"));
            his.Add(new Historia("Qual a data Proclamacao da Republica ?", "A-1500", "B- 1889", "C-1888", "D-1822", "B"));
            his.Add(new Historia("Qual a data da Independecia do Brasil ?", "A-1500", "B-2000", "C-1822", "D-2015", "C"));
            his.Add(new Historia("Qual o ano da criação do dia da Bandeira ?", "A-1500", "B-1822", "C-2015", "D-1889", "D"));

            his.Add(new Historia("Qual a data da Primeira Guerra Mundial ?", "A-1914", "B-2015", "C-1888", "D-1815", "A"));
            his.Add(new Historia("Qual a data do FIM Segunda Guerra Mundial ?", "A-1500", "B- 1945", "C-1888", "D-1822", "B"));
            his.Add(new Historia("Qual a data da Guerra do Vietna ?", "A-1500", "B-2000", "C-1972", "D-2015", "C"));
            his.Add(new Historia("Qual a data do atentado World Trade Center ?", "A-1500", "B-1822", "C-2015", "D-2011", "D"));

            his.Add(new Historia("Qual o primeiro carro movido a gasolina  ?", "A-1893", "B-2015", "C-1888", "D-1815", "A"));
            his.Add(new Historia("Qual o primeiro semaforo no mundo ?", "A-1500", "B- 1840", "C-1888", "D-1822", "B"));
            his.Add(new Historia("Qual a data dos primeiro modelos de carro a álcool foram lançados ?", "A-1500", "B-2000", "C-1979", "D-2015", "C"));
            his.Add(new Historia("A primeira lei de trânsito chamava-se Lei da Bandeira Vermelha e foi promulgada em que ano ?", "A-1500", "B-1822", "C-2015", "D-1836", "D"));

            his.Add(new Historia("Qual a data da primeira igreja do Brasil ?", "A-1503", "B-2015", "C-1888", "D-1815", "A"));
            his.Add(new Historia("Qual a data primeira Vila do Brasil ?", "A-1500", "B- 1530", "C-1888", "D-1822", "B"));
            his.Add(new Historia("Qual a data da primeira capital do Brasil ?", "A-1500", "B-2000", "C-1549", "D-2015", "C"));
            his.Add(new Historia("Qual o ano da segunda capital do Brasil?", "A-1500", "B-1822", "C-2015", "D-1750", "D"));


        }

    }
}
