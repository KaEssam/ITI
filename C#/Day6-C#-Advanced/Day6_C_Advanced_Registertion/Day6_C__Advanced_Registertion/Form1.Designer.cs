namespace Day6_C__Advanced_Registertion
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
            laName = new Label();
            laEmail = new Label();
            laGender = new Label();
            laHoppies = new Label();
            nameBox = new TextBox();
            emailBox = new TextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            cbFootball = new CheckBox();
            cbTennis = new CheckBox();
            cbSwimming = new CheckBox();
            register = new Button();
            nameError = new Label();
            emailError = new Label();
            genderError = new Label();
            hoppiesError = new Label();
            registerDone = new Label();
            SuspendLayout();
            // 
            // laName
            // 
            laName.AutoSize = true;
            laName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            laName.Location = new Point(12, 31);
            laName.Margin = new Padding(3, 0, 5, 0);
            laName.Name = "laName";
            laName.Size = new Size(55, 20);
            laName.TabIndex = 0;
            laName.Text = "Name:";
            laName.TextAlign = ContentAlignment.TopRight;
            // 
            // laEmail
            // 
            laEmail.AutoSize = true;
            laEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            laEmail.Location = new Point(12, 87);
            laEmail.Name = "laEmail";
            laEmail.Size = new Size(51, 20);
            laEmail.TabIndex = 1;
            laEmail.Text = "Email:";
            laEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // laGender
            // 
            laGender.AutoSize = true;
            laGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            laGender.Location = new Point(12, 138);
            laGender.Name = "laGender";
            laGender.Size = new Size(65, 20);
            laGender.TabIndex = 2;
            laGender.Text = "Gender:";
            laGender.TextAlign = ContentAlignment.TopRight;
            // 
            // laHoppies
            // 
            laHoppies.AutoSize = true;
            laHoppies.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            laHoppies.Location = new Point(12, 197);
            laHoppies.Name = "laHoppies";
            laHoppies.Size = new Size(70, 20);
            laHoppies.TabIndex = 3;
            laHoppies.Text = "Hoppies:";
            laHoppies.TextAlign = ContentAlignment.TopRight;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(95, 32);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(145, 23);
            nameBox.TabIndex = 4;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(95, 83);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(145, 23);
            emailBox.TabIndex = 5;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(101, 138);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(51, 19);
            rdMale.TabIndex = 6;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(227, 138);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(63, 19);
            rdFemale.TabIndex = 7;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // cbFootball
            // 
            cbFootball.AutoSize = true;
            cbFootball.Location = new Point(105, 197);
            cbFootball.Name = "cbFootball";
            cbFootball.Size = new Size(69, 19);
            cbFootball.TabIndex = 8;
            cbFootball.Text = "Football";
            cbFootball.UseVisualStyleBackColor = true;
            // 
            // cbTennis
            // 
            cbTennis.AutoSize = true;
            cbTennis.Location = new Point(187, 197);
            cbTennis.Name = "cbTennis";
            cbTennis.Size = new Size(59, 19);
            cbTennis.TabIndex = 9;
            cbTennis.Text = "Tennis";
            cbTennis.UseVisualStyleBackColor = true;
            // 
            // cbSwimming
            // 
            cbSwimming.AutoSize = true;
            cbSwimming.Location = new Point(267, 197);
            cbSwimming.Name = "cbSwimming";
            cbSwimming.Size = new Size(83, 19);
            cbSwimming.TabIndex = 10;
            cbSwimming.Text = "Swimming";
            cbSwimming.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            register.Location = new Point(105, 257);
            register.Name = "register";
            register.Size = new Size(135, 23);
            register.TabIndex = 11;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // nameError
            // 
            nameError.AutoSize = true;
            nameError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameError.ForeColor = Color.Red;
            nameError.Location = new Point(267, 38);
            nameError.Name = "nameError";
            nameError.Size = new Size(0, 17);
            nameError.TabIndex = 12;
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailError.ForeColor = Color.Red;
            emailError.Location = new Point(252, 91);
            emailError.Name = "emailError";
            emailError.Size = new Size(0, 17);
            emailError.TabIndex = 13;
            // 
            // genderError
            // 
            genderError.AutoSize = true;
            genderError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            genderError.ForeColor = Color.Red;
            genderError.Location = new Point(315, 140);
            genderError.Name = "genderError";
            genderError.Size = new Size(0, 17);
            genderError.TabIndex = 14;
            // 
            // hoppiesError
            // 
            hoppiesError.AutoSize = true;
            hoppiesError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            hoppiesError.ForeColor = Color.Red;
            hoppiesError.Location = new Point(356, 198);
            hoppiesError.Name = "hoppiesError";
            hoppiesError.Size = new Size(0, 17);
            hoppiesError.TabIndex = 15;
            // 
            // registerDone
            // 
            registerDone.AutoSize = true;
            registerDone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerDone.ForeColor = Color.Green;
            registerDone.Location = new Point(123, 305);
            registerDone.Name = "registerDone";
            registerDone.Size = new Size(0, 21);
            registerDone.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 372);
            Controls.Add(registerDone);
            Controls.Add(hoppiesError);
            Controls.Add(genderError);
            Controls.Add(emailError);
            Controls.Add(nameError);
            Controls.Add(register);
            Controls.Add(cbSwimming);
            Controls.Add(cbTennis);
            Controls.Add(cbFootball);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(emailBox);
            Controls.Add(nameBox);
            Controls.Add(laHoppies);
            Controls.Add(laGender);
            Controls.Add(laEmail);
            Controls.Add(laName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label laName;
        private Label laEmail;
        private Label laGender;
        private Label laHoppies;
        private TextBox nameBox;
        private TextBox emailBox;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private CheckBox cbFootball;
        private CheckBox cbTennis;
        private CheckBox cbSwimming;
        private Button register;
        private Label nameError;
        private Label emailError;
        private Label genderError;
        private Label hoppiesError;
        private Label registerDone;
    }
}
