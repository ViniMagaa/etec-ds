namespace ex001
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
            result = new Label();
            button1 = new Button();
            n1 = new TextBox();
            n2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(318, 124);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Nº 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(318, 159);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Nº 2";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            result.ForeColor = SystemColors.ControlLightLight;
            result.Location = new Point(314, 259);
            result.Name = "result";
            result.Size = new Size(148, 32);
            result.TabIndex = 2;
            result.Text = "Resultado...";
            // 
            // button1
            // 
            button1.Location = new Point(318, 194);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // n1
            // 
            n1.Location = new Point(362, 121);
            n1.Name = "n1";
            n1.Size = new Size(100, 23);
            n1.TabIndex = 4;
            n1.TextChanged += n1_TextChanged;
            // 
            // n2
            // 
            n2.Location = new Point(362, 155);
            n2.Name = "n2";
            n2.Size = new Size(100, 23);
            n2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(80, 9);
            label3.Name = "label3";
            label3.Size = new Size(641, 86);
            label3.TabIndex = 6;
            label3.Text = "Calculadora Simples";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(button1);
            Controls.Add(result);
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
        private Label result;
        private Button button1;
        private TextBox n1;
        private TextBox n2;
        private Label label3;
    }
}