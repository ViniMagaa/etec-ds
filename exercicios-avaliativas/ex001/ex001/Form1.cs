namespace ex001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, soma, subtracao, multiplicacao, divisao;

            numero1 = double.Parse(n1.Text);
            numero2 = double.Parse(n2.Text);

            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            divisao = numero1 / numero2;

            result.Text = $"A soma é {soma}\n" +
                $"A subtração é {subtracao} \n" +
                $"A multiplicação é {multiplicacao} \n" +
                $"A divisão é {divisao}";
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}