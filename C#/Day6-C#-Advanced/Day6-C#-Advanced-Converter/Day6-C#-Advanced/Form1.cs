namespace Day6_C__Advanced
{
    public partial class Converter : Form
    {
        private object result;

        public Converter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = double.Parse(inputValue.Text);
            double result = 0;

            if (meToKm.Checked)
            {
                result = input / 1000;
            }
            else if (meToMi.Checked)
            {
                result = input / 1609.344;
            }
            else if (miToMe.Checked)
            {
                result = input * 1609.344;
            }

            outputValue.Text = result.ToString();
        }
    }
}