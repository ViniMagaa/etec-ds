namespace aula_05_06_janelas
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
            btnEntrar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            lblSobrenome = new Label();
            txtSobrenome = new TextBox();
            label2 = new Label();
            txtIdade = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(358, 376);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(142, 62);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(206, 102);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(444, 43);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(205, 58);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSobrenome.Location = new Point(205, 166);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(154, 37);
            lblSobrenome.TabIndex = 4;
            lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSobrenome.Location = new Point(206, 210);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(444, 43);
            txtSobrenome.TabIndex = 3;
            txtSobrenome.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 283);
            label2.Name = "label2";
            label2.Size = new Size(84, 37);
            label2.TabIndex = 6;
            label2.Text = "Idade";
            label2.Click += label2_Click;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(205, 327);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(444, 43);
            txtIdade.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtIdade);
            Controls.Add(lblSobrenome);
            Controls.Add(txtSobrenome);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnEntrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtNome;
        private Label label1;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private Label label2;
        private TextBox txtIdade;
    }
}