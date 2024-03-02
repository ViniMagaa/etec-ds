namespace ex001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int saldoUsuario = 0;

        private void saldo_Click(object sender, EventArgs e)
        {

        }

        private void botaoDinheiro_Click(object sender, EventArgs e)
        {
            saldoUsuario += new Random().Next(1, 100);
            saldo.Text = "Saldo: " + saldoUsuario + ",00";
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}