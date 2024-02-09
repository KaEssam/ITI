using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Day6_C__Advanced_Registertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValid = true;

        private void register_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length < 5)
            {
                nameError.Text = "Name is required and must be at least 5 characters";
                isValid = false;
            }
            else
            {
                laName.Text = "";
            }

            if (string.IsNullOrEmpty(emailBox.Text) || !emailBox.Text.Contains("@"))
            {
                emailError.Text = "Email is required and must be a valid email address";
                isValid = false;
            }
            else
            {
                laEmail.Text = "";
            }

            if (!cbFootball.Checked && !cbTennis.Checked && !cbSwimming.Checked)
            {
                hoppiesError.Text = "At least one hobby must be selected";
                isValid = false;
            }
            else
            {
                laHoppies.Text = "";
            }

            if (!rdMale.Checked && !rdFemale.Checked)
            {
                genderError.Text = "Gender must be selected";
                isValid = false;
            }
            else
            {
                laGender.Text = "";
            }

            if (isValid)
            {
                registerDone.Text = "Registration successful";
            }
        }
    }
}