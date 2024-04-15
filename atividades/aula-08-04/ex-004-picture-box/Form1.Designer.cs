namespace ex_004_picture_box
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            semImagem = new RadioButton();
            desktop = new RadioButton();
            notebook = new RadioButton();
            groupBox2 = new GroupBox();
            tresD = new RadioButton();
            fixaSimples = new RadioButton();
            semBorda = new RadioButton();
            exibirImagem = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = Properties.Resources.notebook;
            pictureBox1.Location = new Point(32, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(semImagem);
            groupBox1.Controls.Add(desktop);
            groupBox1.Controls.Add(notebook);
            groupBox1.Location = new Point(32, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 117);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de imagem";
            // 
            // semImagem
            // 
            semImagem.AutoSize = true;
            semImagem.Location = new Point(16, 87);
            semImagem.Name = "semImagem";
            semImagem.Size = new Size(95, 19);
            semImagem.TabIndex = 2;
            semImagem.Text = "Sem imagem";
            semImagem.UseVisualStyleBackColor = true;
            semImagem.CheckedChanged += semImagem_CheckedChanged;
            // 
            // desktop
            // 
            desktop.AutoSize = true;
            desktop.Location = new Point(16, 57);
            desktop.Name = "desktop";
            desktop.Size = new Size(68, 19);
            desktop.TabIndex = 1;
            desktop.Text = "Desktop";
            desktop.UseVisualStyleBackColor = true;
            desktop.CheckedChanged += desktop_CheckedChanged;
            // 
            // notebook
            // 
            notebook.AutoSize = true;
            notebook.Location = new Point(16, 29);
            notebook.Name = "notebook";
            notebook.Size = new Size(78, 19);
            notebook.TabIndex = 0;
            notebook.Text = "Notebook";
            notebook.UseVisualStyleBackColor = true;
            notebook.CheckedChanged += notebook_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tresD);
            groupBox2.Controls.Add(fixaSimples);
            groupBox2.Controls.Add(semBorda);
            groupBox2.Location = new Point(226, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(192, 117);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipos de borda";
            // 
            // tresD
            // 
            tresD.AutoSize = true;
            tresD.Location = new Point(19, 82);
            tresD.Name = "tresD";
            tresD.Size = new Size(39, 19);
            tresD.TabIndex = 2;
            tresD.Text = "3D";
            tresD.UseVisualStyleBackColor = true;
            tresD.CheckedChanged += tresD_CheckedChanged;
            // 
            // fixaSimples
            // 
            fixaSimples.AutoSize = true;
            fixaSimples.Location = new Point(19, 54);
            fixaSimples.Name = "fixaSimples";
            fixaSimples.Size = new Size(89, 19);
            fixaSimples.TabIndex = 1;
            fixaSimples.Text = "Fixa simples";
            fixaSimples.UseVisualStyleBackColor = true;
            fixaSimples.CheckedChanged += fixaSimples_CheckedChanged;
            // 
            // semBorda
            // 
            semBorda.AutoSize = true;
            semBorda.Checked = true;
            semBorda.Location = new Point(19, 29);
            semBorda.Name = "semBorda";
            semBorda.Size = new Size(82, 19);
            semBorda.TabIndex = 0;
            semBorda.TabStop = true;
            semBorda.Text = "Sem borda";
            semBorda.UseVisualStyleBackColor = true;
            semBorda.CheckedChanged += semBorda_CheckedChanged;
            // 
            // exibirImagem
            // 
            exibirImagem.AutoSize = true;
            exibirImagem.Checked = true;
            exibirImagem.CheckState = CheckState.Checked;
            exibirImagem.Location = new Point(259, 225);
            exibirImagem.Name = "exibirImagem";
            exibirImagem.Size = new Size(159, 19);
            exibirImagem.TabIndex = 3;
            exibirImagem.Text = "Exibir ou ocultar imagem";
            exibirImagem.UseVisualStyleBackColor = true;
            exibirImagem.CheckedChanged += exibirImagem_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(184, 382);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 424);
            Controls.Add(button1);
            Controls.Add(exibirImagem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton semImagem;
        private RadioButton desktop;
        private RadioButton notebook;
        private RadioButton tresD;
        private RadioButton fixaSimples;
        private RadioButton semBorda;
        private CheckBox exibirImagem;
        private Button button1;
    }
}