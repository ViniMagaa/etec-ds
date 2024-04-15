using ex_004_picture_box.Properties;
using Microsoft.VisualBasic.ApplicationServices;

namespace ex_004_picture_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void notebook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.notebook;
        }

        private void desktop_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.desktop;
        }

        private void semImagem_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void semBorda_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void fixaSimples_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void tresD_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void exibirImagem_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = exibirImagem.Checked;
        }
    }
}