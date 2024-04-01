namespace ex003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ehTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 + lado2 < lado3) return false;
            if (lado2 + lado3 < lado1) return false;
            if (lado3 + lado1 < lado2) return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l1, l2, l3;
            l1 = double.Parse(lado1.Text);
            l2 = double.Parse(lado2.Text);
            l3 = double.Parse(lado3.Text);

            if (ehTriangulo(l1, l2, l3))
            {
                MessageBox.Show("Parabéns! Você fez um triângulo.");
            }
            else
            {
                MessageBox.Show("Essa não! O triângulo não foi criado.");
            }
        }
    }
}