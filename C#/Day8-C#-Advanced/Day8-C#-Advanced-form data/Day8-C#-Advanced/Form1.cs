using System.Data;

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
    }
}