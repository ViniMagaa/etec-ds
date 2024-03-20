using System.Security.Permissions;

namespace ex002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float media = float.Parse(textBox1.Text);

            if (media > 10 || media < 0)
            {
                MessageBox.Show("A média está incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (media >= 7) 
            {
                MessageBox.Show("Aprovado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reprovado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}