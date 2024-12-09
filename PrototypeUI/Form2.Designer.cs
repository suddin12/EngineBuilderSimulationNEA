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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 42F);
            label1.Location = new Point(398, 61);
            label1.Name = "label1";
            label1.Size = new Size(830, 112);
            label1.TabIndex = 0;
            label1.Text = "Engine Configuration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(46, 255);
            label2.Name = "label2";
            label2.Size = new Size(405, 46);
            label2.TabIndex = 1;
            label2.Text = "Input number of cylinders";
            // 
            // NoOfCylinders
            // 
            NoOfCylinders.Location = new Point(490, 269);
            NoOfCylinders.Name = "NoOfCylinders";
            NoOfCylinders.Size = new Size(150, 31);
            NoOfCylinders.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(190, 338);
            label3.Name = "label3";
            label3.Size = new Size(105, 46);
            label3.TabIndex = 3;
            label3.Text = "Bore: ";
            // 
            // BoreSize
            // 
            BoreSize.Location = new Point(490, 353);
            BoreSize.Name = "BoreSize";
            BoreSize.Size = new Size(150, 31);
            BoreSize.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F);
            label4.Location = new Point(172, 429);
            label4.Name = "label4";
            label4.Size = new Size(123, 46);
            label4.TabIndex = 5;
            label4.Text = "Stroke:";
            // 
            // StrokeSize
            // 
            StrokeSize.Location = new Point(490, 443);
            StrokeSize.Name = "StrokeSize";
            StrokeSize.Size = new Size(150, 31);
            StrokeSize.TabIndex = 6;
            // 
            // RunButton
            // 
            RunButton.Font = new Font("Segoe UI", 32F);
            RunButton.Location = new Point(1362, 727);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(228, 106);
            RunButton.TabIndex = 7;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F);
            label5.Location = new Point(56, 528);
            label5.Name = "label5";
            label5.Size = new Size(334, 46);
            label5.TabIndex = 8;
            label5.Text = "Input maximum RPM";
            // 
            // MaxRPM
            // 
            MaxRPM.Location = new Point(490, 543);
            MaxRPM.Name = "MaxRPM";
            MaxRPM.Size = new Size(150, 31);
            MaxRPM.TabIndex = 9;
            // 
            // FuelType
            // 
            FuelType.FormattingEnabled = true;
            FuelType.Items.AddRange(new object[] { "Petrol", "Diesel" });
            FuelType.Location = new Point(490, 639);
            FuelType.Name = "FuelType";
            FuelType.Size = new Size(150, 33);
            FuelType.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F);
            label6.Location = new Point(134, 625);
            label6.Name = "label6";
            label6.Size = new Size(161, 46);
            label6.TabIndex = 11;
            label6.Text = "Fuel Type";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 982);
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
            Name = "Form2";
            Text = "Form2";
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
    }
}