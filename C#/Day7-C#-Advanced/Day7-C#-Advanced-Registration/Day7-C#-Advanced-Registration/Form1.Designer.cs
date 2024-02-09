namespace Day7_C__Advanced_Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            laFnam = new Label();
            laLname = new Label();
            laEmail = new Label();
            laPassword = new Label();
            laCpass = new Label();
            laGender = new Label();
            laDOB = new Label();
            laMobile = new Label();
            laAdress = new Label();
            label10 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtEmail = new TextBox();
            txtpass = new TextBox();
            txtCpass = new TextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            txtMob = new TextBox();
            txtAddress = new TextBox();
            this.ErrorEmail = new Label();
            this.ErrorPass = new Label();
            this.ErrorDate = new Label();
            ErorrAddress = new Label();
            ErrorMob = new Label();
            submitMsg = new Label();
            SuspendLayout();
            // 
            // laFnam
            // 
            laFnam.AutoSize = true;
            laFnam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laFnam.Location = new Point(24, 57);
            laFnam.Name = "laFnam";
            laFnam.Size = new Size(92, 21);
            laFnam.TabIndex = 0;
            laFnam.Text = "Frist Name:";
            // 
            // laLname
            // 
            laLname.AutoSize = true;
            laLname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laLname.Location = new Point(24, 105);
            laLname.Name = "laLname";
            laLname.Size = new Size(90, 21);
            laLname.TabIndex = 1;
            laLname.Text = "Last Name:";
            // 
            // laEmail
            // 
            laEmail.AutoSize = true;
            laEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laEmail.Location = new Point(24, 149);
            laEmail.Name = "laEmail";
            laEmail.Size = new Size(59, 21);
            laEmail.TabIndex = 2;
            laEmail.Text = "E-Mail:";
            // 
            // laPassword
            // 
            laPassword.AutoSize = true;
            laPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laPassword.Location = new Point(24, 195);
            laPassword.Name = "laPassword";
            laPassword.Size = new Size(83, 21);
            laPassword.TabIndex = 3;
            laPassword.Text = "Password:";
            // 
            // laCpass
            // 
            laCpass.AutoSize = true;
            laCpass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laCpass.Location = new Point(24, 250);
            laCpass.Name = "laCpass";
            laCpass.Size = new Size(146, 21);
            laCpass.TabIndex = 4;
            laCpass.Text = "Confirm Password:";
            // 
            // laGender
            // 
            laGender.AutoSize = true;
            laGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laGender.Location = new Point(24, 306);
            laGender.Name = "laGender";
            laGender.Size = new Size(69, 21);
            laGender.TabIndex = 5;
            laGender.Text = "Gender:";
            // 
            // laDOB
            // 
            laDOB.AutoSize = true;
            laDOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laDOB.Location = new Point(24, 360);
            laDOB.Name = "laDOB";
            laDOB.Size = new Size(109, 21);
            laDOB.TabIndex = 6;
            laDOB.Text = "Date Of Birth:";
            // 
            // laMobile
            // 
            laMobile.AutoSize = true;
            laMobile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laMobile.Location = new Point(24, 413);
            laMobile.Name = "laMobile";
            laMobile.Size = new Size(66, 21);
            laMobile.TabIndex = 7;
            laMobile.Text = "Mobile:";
            // 
            // laAdress
            // 
            laAdress.AutoSize = true;
            laAdress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            laAdress.Location = new Point(24, 470);
            laAdress.Name = "laAdress";
            laAdress.Size = new Size(74, 21);
            laAdress.TabIndex = 8;
            laAdress.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(249, 9);
            label10.Name = "label10";
            label10.Size = new Size(172, 25);
            label10.TabIndex = 9;
            label10.Text = "Registration Form";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(181, 536);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(274, 536);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(182, 50);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(167, 23);
            txtFname.TabIndex = 12;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(182, 98);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(167, 23);
            txtLname.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(182, 195);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(167, 23);
            txtpass.TabIndex = 15;
            // 
            // txtCpass
            // 
            txtCpass.Location = new Point(182, 247);
            txtCpass.Name = "txtCpass";
            txtCpass.Size = new Size(167, 23);
            txtCpass.TabIndex = 16;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(182, 306);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(51, 19);
            rdMale.TabIndex = 17;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(286, 306);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(63, 19);
            rdFemale.TabIndex = 18;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(181, 354);
            dateTimePicker1.MaxDate = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 23);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.Value = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // txtMob
            // 
            txtMob.Location = new Point(182, 410);
            txtMob.Name = "txtMob";
            txtMob.Size = new Size(167, 23);
            txtMob.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 468);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(167, 23);
            txtAddress.TabIndex = 21;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.AutoSize = true;
            this.ErrorEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            this.ErrorEmail.ForeColor = Color.Coral;
            this.ErrorEmail.Location = new Point(375, 156);
            this.ErrorEmail.Name = "ErrorEmail";
            this.ErrorEmail.Size = new Size(0, 16);
            this.ErrorEmail.TabIndex = 24;
            // 
            // ErrorPass
            // 
            this.ErrorPass.AutoSize = true;
            this.ErrorPass.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            this.ErrorPass.ForeColor = Color.Coral;
            this.ErrorPass.Location = new Point(375, 255);
            this.ErrorPass.Name = "ErrorPass";
            this.ErrorPass.Size = new Size(0, 16);
            this.ErrorPass.TabIndex = 26;

            // 
            // ErrorDate
            // 
            this.ErrorDate.AutoSize = true;
            this.ErrorDate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            this.ErrorDate.ForeColor = Color.Coral;
            this.ErrorDate.Location = new Point(375, 365);
            this.ErrorDate.Name = "ErrorDate";
            this.ErrorDate.Size = new Size(0, 16);
            this.ErrorDate.TabIndex = 27;

            // 
            // ErorrAddress
            // 
            ErorrAddress.AutoSize = true;
            ErorrAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErorrAddress.ForeColor = Color.Red;
            ErorrAddress.Location = new Point(375, 474);
            ErorrAddress.Name = "ErorrAddress";
            ErorrAddress.Size = new Size(0, 17);
            ErorrAddress.TabIndex = 28;
            // 
            // ErrorMob
            // 
            ErrorMob.AutoSize = true;
            ErrorMob.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorMob.ForeColor = Color.Coral;
            ErrorMob.Location = new Point(375, 412);
            ErrorMob.Name = "ErrorMob";
            ErrorMob.Size = new Size(0, 16);
            ErrorMob.TabIndex = 29;
            // 
            // submitMsg
            // 
            submitMsg.AutoSize = true;
            submitMsg.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            submitMsg.ForeColor = Color.Green;
            submitMsg.Location = new Point(375, 539);
            submitMsg.Name = "submitMsg";
            submitMsg.Size = new Size(0, 20);
            submitMsg.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 587);
            Controls.Add(submitMsg);
            Controls.Add(ErrorMob);
            Controls.Add(ErorrAddress);
            Controls.Add(this.ErrorDate);
            Controls.Add(this.ErrorPass);
            Controls.Add(this.ErrorEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtMob);
            Controls.Add(dateTimePicker1);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(txtCpass);
            Controls.Add(txtpass);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(label10);
            Controls.Add(laAdress);
            Controls.Add(laMobile);
            Controls.Add(laDOB);
            Controls.Add(laGender);
            Controls.Add(laCpass);
            Controls.Add(laPassword);
            Controls.Add(laEmail);
            Controls.Add(laLname);
            Controls.Add(laFnam);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label laFnam;
        private Label laLname;
        private Label laEmail;
        private Label laPassword;
        private Label laCpass;
        private Label laGender;
        private Label laDOB;
        private Label laMobile;
        private Label laAdress;
        private Label label10;
        private Button btnSubmit;
        private Button btnClear;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtEmail;
        private TextBox txtpass;
        private TextBox txtCpass;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMob;
        private TextBox txtAddress;
        private Label ErrorEmail;
        private Label ErrorPass;
        private Label ErrorDate;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label ErorrAddress;
        private Label ErrorMob;
        private Label submitMsg;
        private EventHandler label5_Click;
        private EventHandler label1_Click;
        private EventHandler ErorrAddress_Click;
        private EventHandler label4_Click;
        private EventHandler Form1_Load;
    }
}
