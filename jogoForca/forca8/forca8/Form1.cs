using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forca8
{

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //VARIAVEIS DO SISTEMA
        bool start;
        PictureBox[] Pcb;
        string Palavra;
        Int32 Erro = 1;

        //CADASTRAR PALAVRAS NO SISTEMA
        String[] pal = new String[30];

       

        private void button1_Click(object sender, EventArgs e)
        {
            Pcb = new PictureBox[textBox1.Text.Length];
            
            Palavra = textBox1.Text.ToLower();

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                Pcb[i]          = new PictureBox();
                Pcb[i].Width    = 50;
                Pcb[i].Height   = 50;

                Pcb[i].Paint += new PaintEventHandler(Pintar);
                
                flowLayoutPanel1.Controls.Add(Pcb[i]);
            }

            BtnStart.Enabled = false;
            textBox1.Enabled = false;
            start = true;
          }


        //desanhar as lacunas da letras da palvra
        private void Pintar(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, 45, 45, 45);
        }

            //monitorar as teclas digitadas
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData){
                
                if (!start){  return false; }


                if(textBox1.Text.ToLower().Contains(keyData.ToString().ToLower())){  
                  Acertou(keyData.ToString());
                }
                else{
                    Errou();
                }

                return base.ProcessCmdKey(ref msg, keyData);
            }
            
            //reiniciar jogada
        private void Reiniciar(){
            BtnStart.Enabled = true;
            textBox1.Enabled = true;
            start = false;
            textBox1.Text = "";
            pictureBox1.Image = null;
            Erro = 0;
            flowLayoutPanel1.Controls.Clear();
        }

        ///Erro e inserir a imagem no picture box
        private void Errou(){
            switch (Erro){
                case 1: pictureBox1.Image = Properties.Resources.pic2; break;
                case 2: pictureBox1.Image = Properties.Resources.pic3; break;
                case 3: pictureBox1.Image = Properties.Resources.pic3; break;
                case 4: pictureBox1.Image = Properties.Resources.pic4; break;
                case 5: pictureBox1.Image = Properties.Resources.pic5; break;
                case 6: pictureBox1.Image = Properties.Resources.pic6; break;
                case 7: pictureBox1.Image = Properties.Resources.pic7; 
                    MessageBox.Show("VC PERDEU!");
                   //reiniciar a jogada
                   Reiniciar();
                   break;
            }

            //contagem do erros
            Erro++;
	    }

        //acertou
        private void Acertou(string key){
            for (int i = 0; i <textBox1.Text.Length; i++)
			{
			    if (textBox1.Text[i].ToString().ToLower() == key.ToLower()){

                    Graphics Gra = Pcb[i].CreateGraphics();
                    Gra.DrawString(key, new Font("Arial",25), new SolidBrush(Color.CornflowerBlue),0,0);

                    Palavra = Palavra.Replace(key.ToLower()," ");
                }
             }

            if (Palavra.Trim() == ""){
                MessageBox.Show("Terminou Jogo!..");
                Reiniciar();
            }
	     }
        }//acertou
		 
	
        

}
