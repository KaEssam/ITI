namespace Day7_C__Advanced_Calculator
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
            textBox1 = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            n0 = new Button();
            addBtn = new Button();
            subBtn = new Button();
            multiBtn = new Button();
            clrBtn = new Button();
            divBtn = new Button();
            dotBtn = new Button();
            equalBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(243, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n1.Location = new Point(12, 58);
            n1.Name = "n1";
            n1.Size = new Size(50, 50);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n2.Location = new Point(68, 58);
            n2.Name = "n2";
            n2.Size = new Size(50, 50);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n3.Location = new Point(124, 58);
            n3.Name = "n3";
            n3.Size = new Size(50, 50);
            n3.TabIndex = 3;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            // 
            // n4
            // 
            n4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n4.Location = new Point(12, 114);
            n4.Name = "n4";
            n4.Size = new Size(50, 50);
            n4.TabIndex = 4;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n5.Location = new Point(68, 114);
            n5.Name = "n5";
            n5.Size = new Size(50, 50);
            n5.TabIndex = 5;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n6.Location = new Point(124, 114);
            n6.Name = "n6";
            n6.Size = new Size(50, 50);
            n6.TabIndex = 6;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n6_Click;
            // 
            // n7
            // 
            n7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n7.Location = new Point(12, 170);
            n7.Name = "n7";
            n7.Size = new Size(50, 50);
            n7.TabIndex = 7;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n8.Location = new Point(68, 170);
            n8.Name = "n8";
            n8.Size = new Size(50, 50);
            n8.TabIndex = 8;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n9.Location = new Point(124, 170);
            n9.Name = "n9";
            n9.Size = new Size(50, 50);
            n9.TabIndex = 9;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n9_Click;
            // 
            // n0
            // 
            n0.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            n0.Location = new Point(68, 226);
            n0.Name = "n0";
            n0.Size = new Size(50, 50);
            n0.TabIndex = 10;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n0_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(180, 58);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(50, 50);
            addBtn.TabIndex = 11;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // subBtn
            // 
            subBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            subBtn.Location = new Point(180, 114);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(50, 50);
            subBtn.TabIndex = 12;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += subBtn_Click;
            // 
            // multiBtn
            // 
            multiBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiBtn.Location = new Point(180, 170);
            multiBtn.Name = "multiBtn";
            multiBtn.Size = new Size(50, 50);
            multiBtn.TabIndex = 13;
            multiBtn.Text = "*";
            multiBtn.UseVisualStyleBackColor = true;
            multiBtn.Click += multiBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clrBtn.Location = new Point(124, 226);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(50, 50);
            clrBtn.TabIndex = 14;
            clrBtn.Text = "C";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // divBtn
            // 
            divBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            divBtn.Location = new Point(180, 226);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(50, 50);
            divBtn.TabIndex = 15;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += divBtn_Click;
            // 
            // dotBtn
            // 
            dotBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dotBtn.Location = new Point(12, 226);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(50, 50);
            dotBtn.TabIndex = 16;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = true;
            dotBtn.Click += dotBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            equalBtn.Location = new Point(96, 282);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(50, 50);
            equalBtn.TabIndex = 17;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = true;
            equalBtn.Click += equalBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(242, 342);
            Controls.Add(equalBtn);
            Controls.Add(dotBtn);
            Controls.Add(divBtn);
            Controls.Add(clrBtn);
            Controls.Add(multiBtn);
            Controls.Add(subBtn);
            Controls.Add(addBtn);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button addBtn;
        private Button subBtn;
        private Button multiBtn;
        private Button clrBtn;
        private Button divBtn;
        private Button dotBtn;
        private Button equalBtn;
    }
}
