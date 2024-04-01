namespace tarefa_3_urna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total, brancos, nulos, validos;

            brancos = int.Parse(votos_brancos.Text);
            nulos = int.Parse(votos_nulos.Text);
            validos = int.Parse(votos_validos.Text);

            total = brancos + nulos + validos;

            int porcentagem_brancos, porcentagem_nulos, porcentagem_validos;

            porcentagem_brancos = brancos * 100 / total;
            porcentagem_nulos = nulos * 100 / total;
            porcentagem_validos = validos * 100 / total;

            resultado_total.Text = total.ToString();
            resultado_votos_brancos.Text = porcentagem_brancos + "%";
            resultado_votos_nulos.Text = porcentagem_nulos + "%";
            resultado_votos_validos.Text = porcentagem_validos + "%";
        }
    }
}