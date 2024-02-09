using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6_C__Advanced
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(label1.Text) || label1.Text.Length < 5)
            {
                MessageBox.Show("Name is required and must be at least 5 characters");
                isValid = false;
            }

            if (string.IsNullOrEmpty(label2.Text) || !label2.Text.Contains("@"))
            {
                MessageBox.Show("Email is required and must be a valid email address");
                isValid = false;
            }
        }
    }
}