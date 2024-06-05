namespace aula_05_06_janelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            int idade = int.Parse(txtIdade.Text);

            //Abrir a janela Saudacao
            Form janela2 = new Saudacao(nome, sobrenome, idade);    
            janela2.Show();
            this.Hide();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}