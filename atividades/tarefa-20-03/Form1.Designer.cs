namespace tarefa_20_03
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
            exemplo1 = new Button();
            exemplo2 = new Button();
            exemplo3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // exemplo1
            // 
            exemplo1.BackColor = Color.DeepSkyBlue;
            exemplo1.ForeColor = Color.White;
            exemplo1.Location = new Point(216, 175);
            exemplo1.Name = "exemplo1";
            exemplo1.RightToLeft = RightToLeft.No;
            exemplo1.Size = new Size(96, 35);
            exemplo1.TabIndex = 0;
            exemplo1.Text = "Exemplo 1";
            exemplo1.UseVisualStyleBackColor = false;
            exemplo1.Click += button1_Click;
            // 
            // exemplo2
            // 
            exemplo2.BackColor = Color.MediumSlateBlue;
            exemplo2.ForeColor = Color.White;
            exemplo2.Location = new Point(336, 175);
            exemplo2.Name = "exemplo2";
            exemplo2.Size = new Size(96, 35);
            exemplo2.TabIndex = 1;
            exemplo2.Text = "Exemplo 2";
            exemplo2.UseVisualStyleBackColor = false;
            exemplo2.Click += exemplo2_Click;
            // 
            // exemplo3
            // 
            exemplo3.BackColor = Color.Firebrick;
            exemplo3.ForeColor = Color.White;
            exemplo3.Location = new Point(459, 175);
            exemplo3.Name = "exemplo3";
            exemplo3.Size = new Size(96, 35);
            exemplo3.TabIndex = 2;
            exemplo3.Text = "Exemplo 3";
            exemplo3.UseVisualStyleBackColor = false;
            exemplo3.Click += exemplo3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(184, 105);
            label1.Name = "label1";
            label1.Size = new Size(429, 45);
            label1.TabIndex = 3;
            label1.Text = "Exemplos de MessageBox";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(exemplo3);
            Controls.Add(exemplo2);
            Controls.Add(exemplo1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exemplo1;
        private Button exemplo2;
        private Button exemplo3;
        private Label label1;
    }
}