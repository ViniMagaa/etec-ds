namespace tarefa_15_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            error_name.Text = name.Text == "" ? "Campo obrigatório" : "";
        }

        private void card_number_TextChanged(object sender, EventArgs e)
        {
            error_card_number.Text = card_number.Text == "" ? "Digita seu cartão caramba!" : "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
