namespace Prototype_UI
{
    partial class Form3
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
            HomeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27F);
            label1.Location = new Point(517, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 48);
            label1.TabIndex = 0;
            label1.Text = "Output";
            // 
            // HomeButton
            // 
            HomeButton.Font = new Font("Segoe UI", 18F);
            HomeButton.Location = new Point(984, 484);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(137, 72);
            HomeButton.TabIndex = 1;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 594);
            Controls.Add(HomeButton);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button HomeButton;
    }
}