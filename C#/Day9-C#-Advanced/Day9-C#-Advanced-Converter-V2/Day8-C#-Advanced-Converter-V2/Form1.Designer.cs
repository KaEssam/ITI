namespace Day8_C__Advanced_Converter_V2
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
            laMeterToFeet = new Label();
            laGramToPound = new Label();
            laFahrenheitToCelsius = new Label();
            txtMeterToFeet = new TextBox();
            txtFToC = new TextBox();
            txtFahrenheitToCelsius = new TextBox();
            txtFahrenheitToCelsiusValue = new TextBox();
            txtFToCValue = new TextBox();
            txtMeterToFeetValue = new TextBox();
            btnConvert = new Button();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // laMeterToFeet
            // 
            laMeterToFeet.AutoSize = true;
            laMeterToFeet.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            laMeterToFeet.Location = new Point(12, 66);
            laMeterToFeet.Name = "laMeterToFeet";
            laMeterToFeet.Size = new Size(91, 17);
            laMeterToFeet.TabIndex = 0;
            laMeterToFeet.Text = "Meter to feet:";
            // 
            // laGramToPound
            // 
            laGramToPound.AutoSize = true;
            laGramToPound.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            laGramToPound.Location = new Point(12, 127);
            laGramToPound.Name = "laGramToPound";
            laGramToPound.Size = new Size(104, 17);
            laGramToPound.TabIndex = 1;
            laGramToPound.Text = "gram to pound:";
            // 
            // laFahrenheitToCelsius
            // 
            laFahrenheitToCelsius.AutoSize = true;
            laFahrenheitToCelsius.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            laFahrenheitToCelsius.Location = new Point(12, 191);
            laFahrenheitToCelsius.Name = "laFahrenheitToCelsius";
            laFahrenheitToCelsius.Size = new Size(138, 17);
            laFahrenheitToCelsius.TabIndex = 2;
            laFahrenheitToCelsius.Text = "Fahrenheit to Celsius:";
            laFahrenheitToCelsius.Click += label3_Click;
            // 
            // txtMeterToFeet
            // 
            txtMeterToFeet.Location = new Point(170, 63);
            txtMeterToFeet.Name = "txtMeterToFeet";
            txtMeterToFeet.Size = new Size(100, 23);
            txtMeterToFeet.TabIndex = 3;
            // 
            // txtFToC
            // 
            txtFToC.Location = new Point(170, 124);
            txtFToC.Name = "txtFToC";
            txtFToC.Size = new Size(100, 23);
            txtFToC.TabIndex = 4;
            // 
            // txtFahrenheitToCelsius
            // 
            txtFahrenheitToCelsius.Location = new Point(170, 188);
            txtFahrenheitToCelsius.Name = "txtFahrenheitToCelsius";
            txtFahrenheitToCelsius.Size = new Size(100, 23);
            txtFahrenheitToCelsius.TabIndex = 5;
            // 
            // txtFahrenheitToCelsiusValue
            // 
            txtFahrenheitToCelsiusValue.Location = new Point(320, 188);
            txtFahrenheitToCelsiusValue.Name = "txtFahrenheitToCelsiusValue";
            txtFahrenheitToCelsiusValue.Size = new Size(100, 23);
            txtFahrenheitToCelsiusValue.TabIndex = 8;
            // 
            // txtFToCValue
            // 
            txtFToCValue.Location = new Point(320, 127);
            txtFToCValue.Name = "txtFToCValue";
            txtFToCValue.Size = new Size(100, 23);
            txtFToCValue.TabIndex = 7;
            // 
            // txtMeterToFeetValue
            // 
            txtMeterToFeetValue.Location = new Point(320, 66);
            txtMeterToFeetValue.Name = "txtMeterToFeetValue";
            txtMeterToFeetValue.Size = new Size(100, 23);
            txtMeterToFeetValue.TabIndex = 6;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(260, 251);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 9;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(188, 28);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 10;
            label4.Text = "units";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(343, 28);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 11;
            label5.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(41, 251);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 296);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnConvert);
            Controls.Add(txtFahrenheitToCelsiusValue);
            Controls.Add(txtFToCValue);
            Controls.Add(txtMeterToFeetValue);
            Controls.Add(txtFahrenheitToCelsius);
            Controls.Add(txtFToC);
            Controls.Add(txtMeterToFeet);
            Controls.Add(laFahrenheitToCelsius);
            Controls.Add(laGramToPound);
            Controls.Add(laMeterToFeet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label laMeterToFeet;
        private Label laGramToPound;
        private Label laFahrenheitToCelsius;
        private TextBox txtMeterToFeet;
        private TextBox txtFToC;
        private TextBox txtFahrenheitToCelsius;
        private TextBox txtFahrenheitToCelsiusValue;
        private TextBox txtFToCValue;
        private TextBox txtMeterToFeetValue;
        private Button btnConvert;
        private Label label4;
        private Label label5;
        private Label label1;
    }
}
