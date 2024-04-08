namespace ex_001_desconto
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
            value = new TextBox();
            fivePercent = new RadioButton();
            tenPercent = new RadioButton();
            noDiscount = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(423, 45);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Descontos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 90);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 1;
            label2.Text = "Insira o valor:";
            // 
            // value
            // 
            value.Location = new Point(27, 114);
            value.Name = "value";
            value.Size = new Size(141, 23);
            value.TabIndex = 2;
            // 
            // fivePercent
            // 
            fivePercent.AutoSize = true;
            fivePercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fivePercent.Location = new Point(221, 145);
            fivePercent.Name = "fivePercent";
            fivePercent.Size = new Size(50, 25);
            fivePercent.TabIndex = 3;
            fivePercent.TabStop = true;
            fivePercent.Text = "5%";
            fivePercent.UseVisualStyleBackColor = true;
            // 
            // tenPercent
            // 
            tenPercent.AutoSize = true;
            tenPercent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tenPercent.Location = new Point(379, 145);
            tenPercent.Name = "tenPercent";
            tenPercent.Size = new Size(59, 25);
            tenPercent.TabIndex = 4;
            tenPercent.TabStop = true;
            tenPercent.Text = "10%";
            tenPercent.UseVisualStyleBackColor = true;
            // 
            // noDiscount
            // 
            noDiscount.AutoSize = true;
            noDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            noDiscount.Location = new Point(26, 145);
            noDiscount.Name = "noDiscount";
            noDiscount.Size = new Size(126, 25);
            noDiscount.TabIndex = 5;
            noDiscount.TabStop = true;
            noDiscount.Text = "Sem desconto";
            noDiscount.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(24, 207);
            button1.Name = "button1";
            button1.Size = new Size(199, 42);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(251, 207);
            button2.Name = "button2";
            button2.Size = new Size(196, 42);
            button2.TabIndex = 7;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 283);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(noDiscount);
            Controls.Add(tenPercent);
            Controls.Add(fivePercent);
            Controls.Add(value);
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
        private TextBox value;
        private RadioButton fivePercent;
        private RadioButton tenPercent;
        private RadioButton noDiscount;
        private Button button1;
        private Button button2;
    }
}