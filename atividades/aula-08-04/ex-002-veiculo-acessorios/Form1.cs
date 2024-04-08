namespace ex_002_veiculo_acessorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double finalValue = 0;

        public string updateFinalValue(bool condition, double number)
        {
            double newFinalValue = condition ? finalValue + number : finalValue - number;

            return $"R$ {newFinalValue:F2}";
        }

        private void whiteColor_CheckedChanged(object sender, EventArgs e)
        {
            total.Text = updateFinalValue(whiteColor.Checked, 300);
        }
    }
}