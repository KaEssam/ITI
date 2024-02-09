namespace Day7_C__Advanced_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                submitMsg.Text = "Registration successful!";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            txtpass.Text = "";
            txtCpass.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            txtMob.Text = "";
            txtAddress.Text = "";
        }

        private bool ValidateForm()

        {

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ErrorEmail.Text = "Please enter Email.";
                return false;
            }

            if (txtpass.Text != txtCpass.Text)
            {
                ErrorPass.Text = "Passwords do not match.";
                return false;
            }

            if (string.IsNullOrEmpty(txtMob.Text))
            {
                ErrorMob.Text = "Please enter Mobile Number.";
                return false;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                ErorrAddress.Text = "Please enter Address.";
                return false;
            }

            return true;
        }
    }
}