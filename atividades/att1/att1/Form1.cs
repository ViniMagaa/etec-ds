namespace att1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mensagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) => Application.Exit();

        private void button2_Click(object sender, EventArgs e)
        {
            mensagem.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mensagem.Text = " Meu primeiro programa";
        }
    }
}