namespace Day8_C__Advanced_Converter_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            await Task.WhenAll(
                               ConvertMeterToFeet(),
                                              ConvertGramToPound(),
                                                             ConvertFahrenheitToCelsius()
                                                                        );

            label1.Text = ("All conversions completed.");
        }

        private async Task ConvertMeterToFeet()
        {
            double meter = double.Parse(txtMeterToFeet.Text);
            await Task.Delay(3000);
            double feet = meter * 3.28084;
            txtMeterToFeetValue.Text = feet.ToString("0.##") + " feet";
        }

        private async Task ConvertGramToPound()
        {
            double gram = double.Parse(txtFToC.Text);
            await Task.Delay(3000);
            double pound = gram * 0.00220462;
            txtFToCValue.Text = pound.ToString("0.##") + " pounds";
        }

        private async Task ConvertFahrenheitToCelsius()
        {
            double fahrenheit = double.Parse(txtFahrenheitToCelsius.Text);
            await Task.Delay(3000);
            double celsius = (fahrenheit - 32) * 5 / 9;
            txtFahrenheitToCelsiusValue.Text = celsius.ToString("0.##") + " Celsius";
        }
    }
}