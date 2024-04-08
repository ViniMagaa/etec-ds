namespace ex_001_desconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (value.Text.Length == 0) return;

            double number = double.Parse(value.Text);
            double percentage = 0;

            if (fivePercent.Checked)
            {
                percentage = 5;
            }
            else if (tenPercent.Checked)
            {
                percentage = 10;
            }

            double discountedValue = number - (number * percentage / 100);

            MessageBox.Show(
                percentage == 0
                    ? $"O valor sem desconto é R$ {discountedValue:F2}"
                    : $"O valor com {percentage}% de desconto é R$ {discountedValue:F2}"
                , "Valor com desconto"
            );
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}