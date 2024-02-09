using System.Windows.Forms;

namespace Day7_C__Advanced_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Colors = new List<string>();
            Colors.Add("");
            Colors.Add("Black");
            Colors.Add("White");
            Colors.Add("Red");
            Colors.Add("Green");
            Colors.Add("yellow");
            Colors.Add("Blue");
            Colors.Add("Gray");
            Colors.Add("Orange");
            Colors.Add("");

            domainUpDown1.Items.AddRange(Colors);
            domainUpDown1.SelectedIndex = 1;

            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (int)numericUpDown1.Value);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string newColor = domainUpDown1.Text;
            label3.ForeColor = Color.FromName(newColor);
            if (domainUpDown1.SelectedIndex == domainUpDown1.Items.Count - 1)
            {
                domainUpDown1.SelectedIndex = 1;
            }
            else if (domainUpDown1.SelectedIndex == 0)
            {
                domainUpDown1.SelectedIndex = domainUpDown1.Items.Count - 2;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (int)numericUpDown1.Value);
        }
    }
}