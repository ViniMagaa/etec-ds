using Microsoft.VisualBasic;

namespace tarefa_2_area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double largura, altura, area;
            largura = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);
            area = largura * altura;
            MessageBox.Show("A área é: " + area);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}