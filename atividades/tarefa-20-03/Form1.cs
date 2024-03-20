namespace tarefa_20_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa é uma mensagem de alerta.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void exemplo2_Click(object sender, EventArgs e)
        {
            string message = "Poderia informar seus dados para futuro contato?";
            string caption = "Pergunta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("OK Obrigado! Em breve entrarei em contato!", "Resposta SIM", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("OK Sem problemas!", "Resposta NÃO", MessageBoxButtons.OK);
            }
        }

        private void exemplo3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "É isso mesmo que você pensou?",
                "Pergunta",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );
        }
    }
}