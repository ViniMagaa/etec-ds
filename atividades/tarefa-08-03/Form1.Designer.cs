namespace tarefa_08_03
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
            sumButton = new Button();
            n2 = new TextBox();
            n1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira dois números para obter a soma!";
            // 
            // sumButton
            // 
            sumButton.Location = new Point(12, 153);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(94, 29);
            sumButton.TabIndex = 1;
            sumButton.Text = "Somar";
            sumButton.UseVisualStyleBackColor = true;
            sumButton.Click += sumButton_Click;
            // 
            // n2
            // 
            n2.Location = new Point(13, 120);
            n2.Name = "n2";
            n2.Size = new Size(125, 27);
            n2.TabIndex = 2;
            // 
            // n1
            // 
            n1.Location = new Point(13, 62);
            n1.Name = "n1";
            n1.Size = new Size(125, 27);
            n1.TabIndex = 3;
            n1.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Nº 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "Nº 2";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(210, 186);
            result.Name = "result";
            result.Size = new Size(380, 54);
            result.TabIndex = 6;
            result.Text = "Resultado da soma";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(n1);
            Controls.Add(n2);
            Controls.Add(sumButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button sumButton;
        private TextBox n2;
        private TextBox n1;
        private Label label2;
        private Label label3;
        private Label result;
    }
}
