﻿namespace Prototype_UI
{
    partial class Form4
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
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27F);
            label1.Location = new Point(620, 49);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 96);
            label1.TabIndex = 0;
            label1.Text = "Help";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(67, 213);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 65);
            label2.TabIndex = 1;
            label2.Text = "Instructions:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 326);
            label3.Name = "label3";
            label3.Size = new Size(927, 32);
            label3.TabIndex = 2;
            label3.Text = "Enter the main values specified and click run and there should be a torque/rpm curve";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 392);
            label4.Name = "label4";
            label4.Size = new Size(1649, 64);
            label4.TabIndex = 3;
            label4.Text = "The program will only work if bore and stroke are in mm. Additionally, the program will only work if there is a non-zero value for the number of cylinders\r\n\r\n";
            label4.Click += label4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1737, 1019);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form4";
            Text = "Help";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}