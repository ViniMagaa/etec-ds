﻿namespace ex003
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lado1 = new TextBox();
            lado2 = new TextBox();
            lado3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 88);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 136);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Lado 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 191);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Lado 3";
            // 
            // lado1
            // 
            lado1.Location = new Point(72, 106);
            lado1.Name = "lado1";
            lado1.Size = new Size(141, 23);
            lado1.TabIndex = 3;
            // 
            // lado2
            // 
            lado2.Location = new Point(72, 154);
            lado2.Name = "lado2";
            lado2.Size = new Size(141, 23);
            lado2.TabIndex = 4;
            // 
            // lado3
            // 
            lado3.Location = new Point(72, 209);
            lado3.Name = "lado3";
            lado3.Size = new Size(141, 23);
            lado3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 27);
            label4.Name = "label4";
            label4.Size = new Size(295, 32);
            label4.TabIndex = 6;
            label4.Text = "Dando a luz à triângulos";
            // 
            // button1
            // 
            button1.Location = new Point(72, 249);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 7;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(lado3);
            Controls.Add(lado2);
            Controls.Add(lado1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lado1;
        private TextBox lado2;
        private TextBox lado3;
        private Label label4;
        private Button button1;
    }
}