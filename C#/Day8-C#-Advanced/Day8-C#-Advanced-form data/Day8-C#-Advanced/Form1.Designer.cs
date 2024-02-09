namespace Day8_C__Advanced
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
            laPhone = new Label();
            laBirthDate = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            dateTimePicker = new DateTimePicker();
            txtName = new TextBox();
            txtPhone = new TextBox();
            dataGridView1 = new DataGridView();
            NameValue = new DataGridViewTextBoxColumn();
            PhoneValue = new DataGridViewTextBoxColumn();
            BirthDateValue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // laName
            // 
            laName.AutoSize = true;
            laName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            laName.Location = new Point(12, 32);
            laName.Name = "laName";
            laName.Size = new Size(57, 21);
            laName.TabIndex = 0;
            laName.Text = "Name:";
            // 
            // laPhone
            // 
            laPhone.AutoSize = true;
            laPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            laPhone.Location = new Point(12, 90);
            laPhone.Name = "laPhone";
            laPhone.Size = new Size(60, 21);
            laPhone.TabIndex = 1;
            laPhone.Text = "Phone:";
            // 
            // laBirthDate
            // 
            laBirthDate.AutoSize = true;
            laBirthDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            laBirthDate.Location = new Point(12, 149);
            laBirthDate.Name = "laBirthDate";
            laBirthDate.Size = new Size(87, 21);
            laBirthDate.TabIndex = 2;
            laBirthDate.Text = "Birth Date:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(208, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(318, 204);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(105, 148);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(105, 92);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameValue, PhoneValue, BirthDateValue });
            dataGridView1.Location = new Point(335, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(286, 150);
            dataGridView1.TabIndex = 8;
            // 
            // NameValue
            // 
            NameValue.HeaderText = "Name";
            NameValue.Name = "NameValue";
            // 
            // PhoneValue
            // 
            PhoneValue.HeaderText = "Phone";
            PhoneValue.Name = "PhoneValue";
            // 
            // BirthDateValue
            // 
            BirthDateValue.HeaderText = "Birth Date";
            BirthDateValue.Name = "BirthDateValue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 249);
            Controls.Add(dataGridView1);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(dateTimePicker);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(laBirthDate);
            Controls.Add(laPhone);
            Controls.Add(laName);
            Name = "Form1";
            Text = "Trinee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label laName;
        private Label laPhone;
        private Label laBirthDate;
        private Button btnAdd;
        private Button btnSave;
        private DateTimePicker dateTimePicker;
        private TextBox txtName;
        private TextBox txtPhone;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameValue;
        private DataGridViewTextBoxColumn PhoneValue;
        private DataGridViewTextBoxColumn BirthDateValue;
    }
}
