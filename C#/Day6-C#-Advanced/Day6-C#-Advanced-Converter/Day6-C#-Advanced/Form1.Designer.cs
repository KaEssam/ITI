namespace Day6_C__Advanced
{
    partial class Converter
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
            label1 = new Label();
            label2 = new Label();
            meToKm = new RadioButton();
            meToMi = new RadioButton();
            miToMe = new RadioButton();
            button1 = new Button();
            inputValue = new TextBox();
            outputValue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Reuslt:";
            label2.Click += label2_Click;
            // 
            // meToKm
            // 
            meToKm.AutoSize = true;
            meToKm.Location = new Point(231, 44);
            meToKm.Name = "meToKm";
            meToKm.Size = new Size(92, 19);
            meToKm.TabIndex = 2;
            meToKm.TabStop = true;
            meToKm.Text = "Meter To Km";
            meToKm.UseVisualStyleBackColor = true;
            // 
            // meToMi
            // 
            meToMi.AutoSize = true;
            meToMi.Location = new Point(231, 88);
            meToMi.Name = "meToMi";
            meToMi.Size = new Size(97, 19);
            meToMi.TabIndex = 3;
            meToMi.TabStop = true;
            meToMi.Text = "Meter To Mile";
            meToMi.UseVisualStyleBackColor = true;
            // 
            // miToMe
            // 
            miToMe.AutoSize = true;
            miToMe.Location = new Point(231, 129);
            miToMe.Name = "miToMe";
            miToMe.Size = new Size(100, 19);
            miToMe.TabIndex = 4;
            miToMe.TabStop = true;
            miToMe.Text = " Mile To Meter";
            miToMe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(85, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputValue
            // 
            inputValue.Location = new Point(75, 44);
            inputValue.Name = "inputValue";
            inputValue.Size = new Size(100, 23);
            inputValue.TabIndex = 6;
            // 
            // outputValue
            // 
            outputValue.Location = new Point(75, 97);
            outputValue.Name = "outputValue";
            outputValue.Size = new Size(100, 23);
            outputValue.TabIndex = 7;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 208);
            Controls.Add(outputValue);
            Controls.Add(inputValue);
            Controls.Add(button1);
            Controls.Add(miToMe);
            Controls.Add(meToMi);
            Controls.Add(meToKm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Converter";
            Text = "Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton meToKm;
        private RadioButton meToMi;
        private RadioButton miToMe;
        private Button button1;
        private TextBox inputValue;
        private TextBox outputValue;
    }
}
