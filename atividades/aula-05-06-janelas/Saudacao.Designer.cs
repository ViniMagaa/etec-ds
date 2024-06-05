namespace aula_05_06_janelas
{
    partial class Saudacao
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
            btnVoltar = new Button();
            lblNome = new Label();
            lblSobrenome = new Label();
            lblIdade = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(325, 320);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 67);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(353, 137);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(90, 37);
            lblNome.TabIndex = 1;
            lblNome.Text = "label1";
            lblNome.Click += lblNome_Click;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSobrenome.Location = new Point(353, 192);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(90, 37);
            lblSobrenome.TabIndex = 2;
            lblSobrenome.Text = "label1";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdade.Location = new Point(353, 249);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(90, 37);
            lblIdade.TabIndex = 3;
            lblIdade.Text = "label1";
            // 
            // Saudacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lblIdade);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Controls.Add(btnVoltar);
            Name = "Saudacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saudacao";
            Load += Saudacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label lblNome;
        private Label lblSobrenome;
        private Label lblIdade;
    }
}