namespace ex_002_veiculo_acessorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double finalValue = 0;

        public void updateFinalValue(bool condition, double number)
        {

            if (condition)
            {
                finalValue += number;
            } 
            else
            {
                finalValue -= number;
            }

            total.Text = $"R$ {finalValue:F2}";
        }

        private void whiteColor_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(whiteColor.Checked, 300);
        }

        private void blackColor_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(blackColor.Checked, 500);
        }

        private void silverColor_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(silverColor.Checked, 1000);
        }

        private void redColor_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(redColor.Checked, 2000);
        }

        private void insufilmGadget_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(insufilmGadget.Checked, 350);
        }

        private void wheelsGadget_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(wheelsGadget.Checked, 2000);
        }

        private void soundGadget_CheckedChanged(object sender, EventArgs e)
        {
           updateFinalValue(soundGadget.Checked, 2500);
        }

        private void alarmGadget_CheckedChanged(object sender, EventArgs e)
        {
            updateFinalValue(alarmGadget.Checked, 700);
        }
    }
}