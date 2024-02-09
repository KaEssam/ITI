using System.Data;
using System.IO;

namespace Day8_C__Advanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtName.Text, txtPhone.Text, dateTimePicker.Text);

            txtName.Text = "";
            txtPhone.Text = "";
            dateTimePicker.Text = "";

            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog d1 = new OpenFileDialog();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (d1.ShowDialog() == DialogResult.OK)
            {
                if ((st = d1.OpenFile()) != null)
                {
                    string file = d1.FileName;
                    string str = File.ReadAllText(file);
                    textBox1.Text = str;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\User\\Desktop\\data.txt");
            sw.Write(textBox1.Text);
            label1.Text = "Data Saved";
            Random r = new Random();
            label1.ForeColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            sw.Close();
        }
    }
}