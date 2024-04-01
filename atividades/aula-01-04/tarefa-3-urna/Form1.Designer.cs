namespace tarefa_3_urna
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
            label4 = new Label();
            votos_brancos = new TextBox();
            votos_nulos = new TextBox();
            button1 = new Button();
            votos_validos = new TextBox();
            label5 = new Label();
            resultado_votos_brancos = new Label();
            resultado_votos_nulos = new Label();
            resultado_votos_validos = new Label();
            resultado_total = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 22);
            label1.Name = "label1";
            label1.Size = new Size(690, 65);
            label1.TabIndex = 0;
            label1.Text = "Informe os dados da eleição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 1;
            label2.Text = "Total de votos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(238, 125);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 2;
            label3.Text = "Votos em branco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(420, 125);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 3;
            label4.Text = "Votos nulos";
            label4.Click += label4_Click;
            // 
            // votos_brancos
            // 
            votos_brancos.Location = new Point(238, 149);
            votos_brancos.Name = "votos_brancos";
            votos_brancos.Size = new Size(145, 23);
            votos_brancos.TabIndex = 5;
            // 
            // votos_nulos
            // 
            votos_nulos.Location = new Point(420, 149);
            votos_nulos.Name = "votos_nulos";
            votos_nulos.Size = new Size(145, 23);
            votos_nulos.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(313, 238);
            button1.Name = "button1";
            button1.Size = new Size(177, 44);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // votos_validos
            // 
            votos_validos.Location = new Point(595, 149);
            votos_validos.Name = "votos_validos";
            votos_validos.Size = new Size(145, 23);
            votos_validos.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(595, 125);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 8;
            label5.Text = "Votos válidos";
            label5.Click += label5_Click;
            // 
            // resultado_votos_brancos
            // 
            resultado_votos_brancos.AutoSize = true;
            resultado_votos_brancos.Location = new Point(239, 182);
            resultado_votos_brancos.Name = "resultado_votos_brancos";
            resultado_votos_brancos.Size = new Size(17, 15);
            resultado_votos_brancos.TabIndex = 10;
            resultado_votos_brancos.Text = "%";
            // 
            // resultado_votos_nulos
            // 
            resultado_votos_nulos.AutoSize = true;
            resultado_votos_nulos.Location = new Point(420, 182);
            resultado_votos_nulos.Name = "resultado_votos_nulos";
            resultado_votos_nulos.Size = new Size(17, 15);
            resultado_votos_nulos.TabIndex = 11;
            resultado_votos_nulos.Text = "%";
            // 
            // resultado_votos_validos
            // 
            resultado_votos_validos.AutoSize = true;
            resultado_votos_validos.Location = new Point(595, 182);
            resultado_votos_validos.Name = "resultado_votos_validos";
            resultado_votos_validos.Size = new Size(17, 15);
            resultado_votos_validos.TabIndex = 12;
            resultado_votos_validos.Text = "%";
            // 
            // resultado_total
            // 
            resultado_total.AutoSize = true;
            resultado_total.Location = new Point(72, 156);
            resultado_total.Name = "resultado_total";
            resultado_total.Size = new Size(42, 15);
            resultado_total.TabIndex = 13;
            resultado_total.Text = "_______";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado_total);
            Controls.Add(resultado_votos_validos);
            Controls.Add(resultado_votos_nulos);
            Controls.Add(resultado_votos_brancos);
            Controls.Add(votos_validos);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(votos_nulos);
            Controls.Add(votos_brancos);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox votos_brancos;
        private TextBox votos_nulos;
        private Button button1;
        private TextBox votos_validos;
        private Label label5;
        private Label resultado_votos_brancos;
        private Label resultado_votos_nulos;
        private Label resultado_votos_validos;
        private Label resultado_total;
    }
}