using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDiaAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //pibRodrigoFaro.Image = Image.FromFile(@"C:\Users\vinicius.cbcerqueira\Pictures\rodrigofaro1.jpg");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            int idade = Convert.ToInt32(nudAno.Value);
            if (nudAno.Value.ToString().Length == 0)
            {
                btnLimpar.PerformClick();
            }
             if (idade >= 18)
            {
                txtVerificacao.Text = "seja bem vindo ao furduncio!";
                txtVerificacao.ForeColor = Color.Green;
                 pictureBox1.Image = Properties.Resources.rodrigofaro1;
            }
            else if (idade <=18)
            {
                txtVerificacao.Text = "hoje nao!";
                txtVerificacao.ForeColor = Color.Red;
               pictureBox1.Image = Properties.Resources.rodrigofaro0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            

            txtVerificacao.Text = "será que você pode entrar otario?";
            txtVerificacao.ForeColor = Color.Black;

            pictureBox1.Image = Properties.Resources.rodrigofaro2;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja sair da aplicação?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();

        }
    }
}
