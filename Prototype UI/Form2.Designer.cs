namespace Prototype_UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            NoOfCylinders = new TextBox();
            label3 = new Label();
            BoreSize = new TextBox();
            label4 = new Label();
            StrokeSize = new TextBox();
            RunButton = new Button();
            label5 = new Label();
            MaxRPM = new TextBox();
            FuelType = new ComboBox();
            label6 = new Label();
            HelpButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F);
            label1.Location = new Point(279, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(557, 74);
            label1.TabIndex = 0;
            label1.Text = "Engine Configuration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(32, 153);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(277, 31);
            label2.TabIndex = 1;
            label2.Text = "Input number of cylinders";
            // 
            // NoOfCylinders
            // 
            NoOfCylinders.Location = new Point(343, 161);
            NoOfCylinders.Margin = new Padding(2, 2, 2, 2);
            NoOfCylinders.Name = "NoOfCylinders";
            NoOfCylinders.Size = new Size(106, 23);
            NoOfCylinders.TabIndex = 2;
            NoOfCylinders.TextChanged += NoOfCylinders_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(133, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 31);
            label3.TabIndex = 3;
            label3.Text = "Bore: ";
            // 
            // BoreSize
            // 
            BoreSize.Location = new Point(343, 212);
            BoreSize.Margin = new Padding(2, 2, 2, 2);
            BoreSize.Name = "BoreSize";
            BoreSize.Size = new Size(106, 23);
            BoreSize.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F);
            label4.Location = new Point(120, 257);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 31);
            label4.TabIndex = 5;
            label4.Text = "Stroke:";
            // 
            // StrokeSize
            // 
            StrokeSize.Location = new Point(343, 266);
            StrokeSize.Margin = new Padding(2, 2, 2, 2);
            StrokeSize.Name = "StrokeSize";
            StrokeSize.Size = new Size(106, 23);
            StrokeSize.TabIndex = 6;
            // 
            // RunButton
            // 
            RunButton.Font = new Font("Segoe UI", 32F);
            RunButton.Location = new Point(953, 436);
            RunButton.Margin = new Padding(2, 2, 2, 2);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(160, 64);
            RunButton.TabIndex = 7;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F);
            label5.Location = new Point(39, 317);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(230, 31);
            label5.TabIndex = 8;
            label5.Text = "Input maximum RPM";
            // 
            // MaxRPM
            // 
            MaxRPM.Location = new Point(343, 326);
            MaxRPM.Margin = new Padding(2, 2, 2, 2);
            MaxRPM.Name = "MaxRPM";
            MaxRPM.Size = new Size(106, 23);
            MaxRPM.TabIndex = 9;
            // 
            // FuelType
            // 
            FuelType.FormattingEnabled = true;
            FuelType.Items.AddRange(new object[] { "Petrol", "Diesel" });
            FuelType.Location = new Point(343, 383);
            FuelType.Margin = new Padding(2, 2, 2, 2);
            FuelType.Name = "FuelType";
            FuelType.Size = new Size(106, 23);
            FuelType.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F);
            label6.Location = new Point(94, 375);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 11;
            label6.Text = "Fuel Type";
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(94, 469);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(107, 45);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 588);
            Controls.Add(HelpButton);
            Controls.Add(label6);
            Controls.Add(FuelType);
            Controls.Add(MaxRPM);
            Controls.Add(label5);
            Controls.Add(RunButton);
            Controls.Add(StrokeSize);
            Controls.Add(label4);
            Controls.Add(BoreSize);
            Controls.Add(label3);
            Controls.Add(NoOfCylinders);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NoOfCylinders;
        private Label label3;
        private TextBox BoreSize;
        private Label label4;
        private TextBox StrokeSize;
        private Button RunButton;
        private Label label5;
        private TextBox MaxRPM;
        private ComboBox FuelType;
        private Label label6;
        private Button HelpButton;
    }
}