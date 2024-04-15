namespace ex_003_vagas_emprego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void botaoOk_Click(object sender, EventArgs e)
        {
            if (int.Parse(idade.Text) >= 20 && ensinoTecnico.Checked && solteiro.Checked)
            {
                MessageBox.Show($"Parabéns {nome.Text}! Você está contratado.", "Contratado");
            }
            else
            {
                MessageBox.Show($"Muito obrigado, {nome.Text}.");
            }
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}