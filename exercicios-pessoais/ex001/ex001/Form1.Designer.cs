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
            botaoDinheiro = new Button();
            text = new Label();
            label1 = new Label();
            saldo = new Label();
            fechar = new Button();
            SuspendLayout();
            // 
            // botaoDinheiro
            // 
            botaoDinheiro.BackColor = Color.Green;
            botaoDinheiro.BackgroundImageLayout = ImageLayout.Center;
            botaoDinheiro.FlatStyle = FlatStyle.Flat;
            botaoDinheiro.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            botaoDinheiro.ForeColor = Color.Lime;
            botaoDinheiro.Location = new Point(411, 343);
            botaoDinheiro.Name = "botaoDinheiro";
            botaoDinheiro.Size = new Size(249, 57);
            botaoDinheiro.TabIndex = 0;
            botaoDinheiro.Text = "💵 DINHEIRO";
            botaoDinheiro.UseVisualStyleBackColor = false;
            botaoDinheiro.Click += botaoDinheiro_Click;
            // 
            // text
            // 
            text.AutoSize = true;
            text.BackColor = SystemColors.ButtonHighlight;
            text.Cursor = Cursors.IBeam;
            text.Font = new Font("Arial", 50F, FontStyle.Regular, GraphicsUnit.Point);
            text.Location = new Point(285, 28);
            text.Name = "text";
            text.Size = new Size(526, 94);
            text.TabIndex = 1;
            text.Text = "Hello, World!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 146);
            label1.Name = "label1";
            label1.Size = new Size(440, 23);
            label1.TabIndex = 2;
            label1.Text = "Clique no botão abaixo para aumentar seu saldo!";
            // 
            // saldo
            // 
            saldo.AutoSize = true;
            saldo.BackColor = SystemColors.MenuHighlight;
            saldo.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            saldo.ForeColor = Color.FromArgb(192, 255, 192);
            saldo.Location = new Point(331, 260);
            saldo.Name = "saldo";
            saldo.Size = new Size(421, 70);
            saldo.TabIndex = 3;
            saldo.Text = "Saldo: R$ 0,00";
            saldo.Click += saldo_Click;
            // 
            // fechar
            // 
            fechar.BackColor = Color.Red;
            fechar.ForeColor = Color.Snow;
            fechar.Location = new Point(978, 559);
            fechar.Name = "fechar";
            fechar.Size = new Size(127, 29);
            fechar.TabIndex = 4;
            fechar.Text = "PERDER TUDO";
            fechar.UseVisualStyleBackColor = false;
            fechar.Click += fechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1117, 600);
            Controls.Add(fechar);
            Controls.Add(saldo);
            Controls.Add(label1);
            Controls.Add(text);
            Controls.Add(botaoDinheiro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoDinheiro;
        private Label text;
        private Label label1;
        private Label saldo;
        private Button fechar;
    }
}