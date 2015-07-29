
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

public class frm_forca : System.Windows.Forms.Form
{

    //Form overrides dispose to clean up the component list.
    [System.Diagnostics.DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    //Required by the Windows Form Designer

    private System.ComponentModel.IContainer components;
    //NOTE: The following procedure is required by the Windows Form Designer
    //It can be modified using the Windows Form Designer.  
    //Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
            this.btn_novapal = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.lbl_9 = new System.Windows.Forms.Label();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.txt_letra = new System.Windows.Forms.TextBox();
            this.btn_testa = new System.Windows.Forms.Button();
            this.lbl_digiteletra = new System.Windows.Forms.Label();
            this.lbl_dica = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_11 = new System.Windows.Forms.Label();
            this.lbl_12 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.txt_banco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novapal
            // 
            this.btn_novapal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novapal.Location = new System.Drawing.Point(12, 366);
            this.btn_novapal.Name = "btn_novapal";
            this.btn_novapal.Size = new System.Drawing.Size(86, 41);
            this.btn_novapal.TabIndex = 0;
            this.btn_novapal.Text = "Nova Palavra";
            this.btn_novapal.UseVisualStyleBackColor = true;
            // 
            // lbl_1
            // 
            this.lbl_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.Black;
            this.lbl_1.Location = new System.Drawing.Point(196, 260);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(25, 25);
            this.lbl_1.TabIndex = 7;
            // 
            // lbl_2
            // 
            this.lbl_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.Color.Black;
            this.lbl_2.Location = new System.Drawing.Point(219, 260);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(25, 25);
            this.lbl_2.TabIndex = 8;
            // 
            // lbl_3
            // 
            this.lbl_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.Color.Black;
            this.lbl_3.Location = new System.Drawing.Point(242, 260);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(25, 25);
            this.lbl_3.TabIndex = 9;
            // 
            // lbl_4
            // 
            this.lbl_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.ForeColor = System.Drawing.Color.Black;
            this.lbl_4.Location = new System.Drawing.Point(265, 260);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(25, 25);
            this.lbl_4.TabIndex = 10;
            // 
            // lbl_5
            // 
            this.lbl_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.ForeColor = System.Drawing.Color.Black;
            this.lbl_5.Location = new System.Drawing.Point(288, 260);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(25, 25);
            this.lbl_5.TabIndex = 11;
            // 
            // lbl_6
            // 
            this.lbl_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.ForeColor = System.Drawing.Color.Black;
            this.lbl_6.Location = new System.Drawing.Point(311, 260);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(25, 25);
            this.lbl_6.TabIndex = 12;
            // 
            // lbl_7
            // 
            this.lbl_7.BackColor = System.Drawing.Color.Transparent;
            this.lbl_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.ForeColor = System.Drawing.Color.Black;
            this.lbl_7.Location = new System.Drawing.Point(334, 260);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(25, 25);
            this.lbl_7.TabIndex = 13;
            // 
            // lbl_8
            // 
            this.lbl_8.BackColor = System.Drawing.Color.Transparent;
            this.lbl_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.ForeColor = System.Drawing.Color.Black;
            this.lbl_8.Location = new System.Drawing.Point(357, 260);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(25, 25);
            this.lbl_8.TabIndex = 14;
            // 
            // lbl_9
            // 
            this.lbl_9.BackColor = System.Drawing.Color.Transparent;
            this.lbl_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_9.ForeColor = System.Drawing.Color.Black;
            this.lbl_9.Location = new System.Drawing.Point(380, 260);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Size = new System.Drawing.Size(25, 25);
            this.lbl_9.TabIndex = 15;
            // 
            // lbl_10
            // 
            this.lbl_10.BackColor = System.Drawing.Color.Transparent;
            this.lbl_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10.ForeColor = System.Drawing.Color.Black;
            this.lbl_10.Location = new System.Drawing.Point(403, 260);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(25, 25);
            this.lbl_10.TabIndex = 16;
            // 
            // txt_letra
            // 
            this.txt_letra.Location = new System.Drawing.Point(406, 27);
            this.txt_letra.MaxLength = 1;
            this.txt_letra.Name = "txt_letra";
            this.txt_letra.Size = new System.Drawing.Size(36, 20);
            this.txt_letra.TabIndex = 17;
            this.txt_letra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_testa
            // 
            this.btn_testa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testa.Location = new System.Drawing.Point(449, 20);
            this.btn_testa.Name = "btn_testa";
            this.btn_testa.Size = new System.Drawing.Size(75, 33);
            this.btn_testa.TabIndex = 18;
            this.btn_testa.Text = "Testar (?)";
            this.btn_testa.UseVisualStyleBackColor = true;
            // 
            // lbl_digiteletra
            // 
            this.lbl_digiteletra.AutoSize = true;
            this.lbl_digiteletra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_digiteletra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_digiteletra.Location = new System.Drawing.Point(299, 28);
            this.lbl_digiteletra.Name = "lbl_digiteletra";
            this.lbl_digiteletra.Size = new System.Drawing.Size(101, 16);
            this.lbl_digiteletra.TabIndex = 19;
            this.lbl_digiteletra.Text = "Digite a Letra:";
            // 
            // lbl_dica
            // 
            this.lbl_dica.AutoSize = true;
            this.lbl_dica.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dica.ForeColor = System.Drawing.Color.Black;
            this.lbl_dica.Location = new System.Drawing.Point(318, 100);
            this.lbl_dica.Name = "lbl_dica";
            this.lbl_dica.Size = new System.Drawing.Size(0, 19);
            this.lbl_dica.TabIndex = 21;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b.ForeColor = System.Drawing.Color.Black;
            this.lbl_b.Location = new System.Drawing.Point(276, 339);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(71, 14);
            this.lbl_b.TabIndex = 22;
            this.lbl_b.Text = "Ja tentou:";
            // 
            // lbl_11
            // 
            this.lbl_11.BackColor = System.Drawing.Color.Transparent;
            this.lbl_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_11.ForeColor = System.Drawing.Color.Black;
            this.lbl_11.Location = new System.Drawing.Point(426, 260);
            this.lbl_11.Name = "lbl_11";
            this.lbl_11.Size = new System.Drawing.Size(25, 25);
            this.lbl_11.TabIndex = 24;
            // 
            // lbl_12
            // 
            this.lbl_12.BackColor = System.Drawing.Color.Transparent;
            this.lbl_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_12.ForeColor = System.Drawing.Color.Black;
            this.lbl_12.Location = new System.Drawing.Point(449, 260);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Size = new System.Drawing.Size(25, 25);
            this.lbl_12.TabIndex = 25;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(584, 366);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 41);
            this.btn_sair.TabIndex = 26;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(170, 305);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(331, 20);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Para começar, clique no botão \"Nova Palavra\"";
            this.Label1.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(280, 220);
            this.PictureBox1.TabIndex = 30;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(280, 220);
            this.PictureBox2.TabIndex = 31;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(280, 220);
            this.PictureBox3.TabIndex = 32;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox4
            // 
            this.PictureBox4.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(280, 220);
            this.PictureBox4.TabIndex = 33;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(280, 220);
            this.PictureBox5.TabIndex = 34;
            this.PictureBox5.TabStop = false;
            // 
            // PictureBox6
            // 
            this.PictureBox6.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(280, 220);
            this.PictureBox6.TabIndex = 35;
            this.PictureBox6.TabStop = false;
            // 
            // PictureBox7
            // 
            this.PictureBox7.BackgroundImage = global::froca7.Properties.Resources.pic1;
            this.PictureBox7.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(280, 220);
            this.PictureBox7.TabIndex = 36;
            this.PictureBox7.TabStop = false;
            // 
            // txt_banco
            // 
            this.txt_banco.Enabled = false;
            this.txt_banco.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_banco.ForeColor = System.Drawing.Color.Red;
            this.txt_banco.Location = new System.Drawing.Point(353, 332);
            this.txt_banco.MaxLength = 7;
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(98, 27);
            this.txt_banco.TabIndex = 37;
            // 
            // frm_forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 419);
            this.Controls.Add(this.txt_banco);
            this.Controls.Add(this.PictureBox7);
            this.Controls.Add(this.PictureBox6);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_12);
            this.Controls.Add(this.lbl_11);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_dica);
            this.Controls.Add(this.lbl_digiteletra);
            this.Controls.Add(this.btn_testa);
            this.Controls.Add(this.txt_letra);
            this.Controls.Add(this.lbl_10);
            this.Controls.Add(this.lbl_9);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_novapal);
            this.MaximizeBox = false;
            this.Name = "frm_forca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca Versão Beta";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    internal System.Windows.Forms.Button btn_novapal;
    internal System.Windows.Forms.Label lbl_1;
    internal System.Windows.Forms.Label lbl_2;
    internal System.Windows.Forms.Label lbl_3;
    internal System.Windows.Forms.Label lbl_4;
    internal System.Windows.Forms.Label lbl_5;
    internal System.Windows.Forms.Label lbl_6;
    internal System.Windows.Forms.Label lbl_7;
    internal System.Windows.Forms.Label lbl_8;
    internal System.Windows.Forms.Label lbl_9;
    internal System.Windows.Forms.Label lbl_10;
    internal System.Windows.Forms.TextBox txt_letra;
    internal System.Windows.Forms.Button btn_testa;
    internal System.Windows.Forms.Label lbl_digiteletra;
    internal System.Windows.Forms.Label lbl_dica;
    internal System.Windows.Forms.Label lbl_b;
    internal System.Windows.Forms.Label lbl_11;
    internal System.Windows.Forms.Label lbl_12;
    internal System.Windows.Forms.Button btn_sair;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.PictureBox PictureBox1;
    internal System.Windows.Forms.PictureBox PictureBox2;
    internal System.Windows.Forms.PictureBox PictureBox3;
    internal System.Windows.Forms.PictureBox PictureBox4;
    internal System.Windows.Forms.PictureBox PictureBox5;
    internal System.Windows.Forms.PictureBox PictureBox6;
    internal System.Windows.Forms.PictureBox PictureBox7;

    internal System.Windows.Forms.TextBox txt_banco;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
