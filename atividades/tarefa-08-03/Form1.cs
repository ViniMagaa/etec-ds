using System.Numerics;

namespace tarefa_08_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int total = int.Parse(n1.Text) + int.Parse(n2.Text);
            result.Text = n1.Text + " + " + n2.Text + " = " +  total.ToString();
        }
    }
}
