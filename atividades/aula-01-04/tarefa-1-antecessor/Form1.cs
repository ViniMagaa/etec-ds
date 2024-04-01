namespace tarefa_1_antecessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Antecessor = int.Parse(numero.Text)-1;
            MessageBox.Show($"O antecessor do número digitado é {Antecessor}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}