namespace ex_003_vagas_emprego
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
            ensinoFundamental = new RadioButton();
            ensinoMedio = new RadioButton();
            ensinoTecnico = new RadioButton();
            ensinoSuperior = new RadioButton();
            solteiro = new RadioButton();
            casado = new RadioButton();
            divorciado = new RadioButton();
            viuvo = new RadioButton();
            groupBox1 = new GroupBox();
            botaoOk = new Button();
            botaoSair = new Button();
            idade = new TextBox();
            nome = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ensinoFundamental
            // 
            ensinoFundamental.AutoSize = true;
            ensinoFundamental.Location = new Point(17, 32);
            ensinoFundamental.Name = "ensinoFundamental";
            ensinoFundamental.Size = new Size(133, 19);
            ensinoFundamental.TabIndex = 0;
            ensinoFundamental.Text = "Ensino Fundamental";
            ensinoFundamental.UseVisualStyleBackColor = true;
            // 
            // ensinoMedio
            // 
            ensinoMedio.AutoSize = true;
            ensinoMedio.Location = new Point(17, 57);
            ensinoMedio.Name = "ensinoMedio";
            ensinoMedio.Size = new Size(97, 19);
            ensinoMedio.TabIndex = 1;
            ensinoMedio.Text = "Ensino Médio";
            ensinoMedio.UseVisualStyleBackColor = true;
            // 
            // ensinoTecnico
            // 
            ensinoTecnico.AutoSize = true;
            ensinoTecnico.Location = new Point(17, 82);
            ensinoTecnico.Name = "ensinoTecnico";
            ensinoTecnico.Size = new Size(103, 19);
            ensinoTecnico.TabIndex = 2;
            ensinoTecnico.Text = "Ensino Técnico";
            ensinoTecnico.UseVisualStyleBackColor = true;
            // 
            // ensinoSuperior
            // 
            ensinoSuperior.AutoSize = true;
            ensinoSuperior.Location = new Point(17, 107);
            ensinoSuperior.Name = "ensinoSuperior";
            ensinoSuperior.Size = new Size(107, 19);
            ensinoSuperior.TabIndex = 3;
            ensinoSuperior.Text = "Ensino Superior";
            ensinoSuperior.UseVisualStyleBackColor = true;
            // 
            // solteiro
            // 
            solteiro.AutoSize = true;
            solteiro.Location = new Point(13, 32);
            solteiro.Name = "solteiro";
            solteiro.Size = new Size(65, 19);
            solteiro.TabIndex = 4;
            solteiro.TabStop = true;
            solteiro.Text = "Solteiro";
            solteiro.UseVisualStyleBackColor = true;
            // 
            // casado
            // 
            casado.AutoSize = true;
            casado.Location = new Point(14, 57);
            casado.Name = "casado";
            casado.Size = new Size(64, 19);
            casado.TabIndex = 5;
            casado.TabStop = true;
            casado.Text = "Casado";
            casado.UseVisualStyleBackColor = true;
            // 
            // divorciado
            // 
            divorciado.AutoSize = true;
            divorciado.Location = new Point(13, 82);
            divorciado.Name = "divorciado";
            divorciado.Size = new Size(82, 19);
            divorciado.TabIndex = 6;
            divorciado.TabStop = true;
            divorciado.Text = "Divorciado";
            divorciado.UseVisualStyleBackColor = true;
            // 
            // viuvo
            // 
            viuvo.AutoSize = true;
            viuvo.Location = new Point(13, 107);
            viuvo.Name = "viuvo";
            viuvo.Size = new Size(55, 19);
            viuvo.TabIndex = 7;
            viuvo.TabStop = true;
            viuvo.Text = "Viúvo";
            viuvo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(botaoOk);
            groupBox1.Controls.Add(botaoSair);
            groupBox1.Controls.Add(idade);
            groupBox1.Controls.Add(nome);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 305);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe seus dados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // botaoOk
            // 
            botaoOk.Location = new Point(32, 248);
            botaoOk.Name = "botaoOk";
            botaoOk.Size = new Size(176, 23);
            botaoOk.TabIndex = 11;
            botaoOk.Text = "Ok";
            botaoOk.UseVisualStyleBackColor = true;
            botaoOk.Click += botaoOk_Click;
            // 
            // botaoSair
            // 
            botaoSair.Location = new Point(224, 248);
            botaoSair.Name = "botaoSair";
            botaoSair.Size = new Size(164, 23);
            botaoSair.TabIndex = 12;
            botaoSair.Text = "Sair";
            botaoSair.UseVisualStyleBackColor = true;
            botaoSair.Click += botaoSair_Click;
            // 
            // idade
            // 
            idade.Location = new Point(332, 34);
            idade.Name = "idade";
            idade.Size = new Size(56, 23);
            idade.TabIndex = 3;
            // 
            // nome
            // 
            nome.Location = new Point(78, 32);
            nome.Name = "nome";
            nome.Size = new Size(190, 23);
            nome.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(viuvo);
            groupBox3.Controls.Add(solteiro);
            groupBox3.Controls.Add(divorciado);
            groupBox3.Controls.Add(casado);
            groupBox3.Location = new Point(224, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(164, 141);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selecione seu Estado Civil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 37);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Idade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ensinoFundamental);
            groupBox2.Controls.Add(ensinoMedio);
            groupBox2.Controls.Add(ensinoTecnico);
            groupBox2.Controls.Add(ensinoSuperior);
            groupBox2.Location = new Point(32, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 141);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selecione sua Escolaridade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 335);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton ensinoFundamental;
        private RadioButton ensinoMedio;
        private RadioButton ensinoTecnico;
        private RadioButton ensinoSuperior;
        private RadioButton solteiro;
        private RadioButton casado;
        private RadioButton divorciado;
        private RadioButton viuvo;
        private GroupBox groupBox1;
        private Button botaoOk;
        private Button botaoSair;
        private TextBox idade;
        private TextBox nome;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}