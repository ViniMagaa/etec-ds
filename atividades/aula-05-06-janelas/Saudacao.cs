using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_05_06_janelas
{
    public partial class Saudacao : Form
    {
        string pNome;
        string Sobrenome;
        int Idade;
        public Saudacao(string n, string s, int i)
        {
            pNome = n;
            Sobrenome = s;
            Idade = i;
            InitializeComponent();
        }

        private void Saudacao_Load(object sender, EventArgs e)
        {
            lblNome.Text = pNome;
            lblSobrenome.Text = Sobrenome;
            lblIdade.Text = Idade.ToString();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Form1();
            formulario1.Show();
            this.Hide();
        }
    }
}
