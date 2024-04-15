namespace ex_002_veiculo_acessorios
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
            groupBox1 = new GroupBox();
            redColor = new RadioButton();
            silverColor = new RadioButton();
            blackColor = new RadioButton();
            whiteColor = new RadioButton();
            groupBox2 = new GroupBox();
            alarmGadget = new CheckBox();
            soundGadget = new CheckBox();
            wheelsGadget = new CheckBox();
            insufilmGadget = new CheckBox();
            label1 = new Label();
            total = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(redColor);
            groupBox1.Controls.Add(silverColor);
            groupBox1.Controls.Add(blackColor);
            groupBox1.Controls.Add(whiteColor);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cor do carro";
            // 
            // redColor
            // 
            redColor.AutoSize = true;
            redColor.Location = new Point(281, 82);
            redColor.Name = "redColor";
            redColor.Size = new Size(147, 19);
            redColor.TabIndex = 3;
            redColor.Text = "Vermelho + R$ 2.000,00";
            redColor.UseVisualStyleBackColor = true;
            redColor.CheckedChanged += redColor_CheckedChanged;
            // 
            // silverColor
            // 
            silverColor.AutoSize = true;
            silverColor.Location = new Point(281, 44);
            silverColor.Name = "silverColor";
            silverColor.Size = new Size(124, 19);
            silverColor.TabIndex = 2;
            silverColor.Text = "Prata + R$ 1.000,00";
            silverColor.UseVisualStyleBackColor = true;
            silverColor.CheckedChanged += silverColor_CheckedChanged;
            // 
            // blackColor
            // 
            blackColor.AutoSize = true;
            blackColor.Location = new Point(52, 82);
            blackColor.Name = "blackColor";
            blackColor.Size = new Size(116, 19);
            blackColor.TabIndex = 1;
            blackColor.Text = "Preto + R$ 500,00";
            blackColor.UseVisualStyleBackColor = true;
            blackColor.CheckedChanged += blackColor_CheckedChanged;
            // 
            // whiteColor
            // 
            whiteColor.AutoSize = true;
            whiteColor.Location = new Point(52, 44);
            whiteColor.Name = "whiteColor";
            whiteColor.Size = new Size(125, 19);
            whiteColor.TabIndex = 0;
            whiteColor.Text = "Branco + R$ 300,00";
            whiteColor.UseVisualStyleBackColor = true;
            whiteColor.CheckedChanged += whiteColor_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(alarmGadget);
            groupBox2.Controls.Add(soundGadget);
            groupBox2.Controls.Add(wheelsGadget);
            groupBox2.Controls.Add(insufilmGadget);
            groupBox2.Location = new Point(12, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 134);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acessórios do carro";
            // 
            // alarmGadget
            // 
            alarmGadget.AutoSize = true;
            alarmGadget.Location = new Point(281, 87);
            alarmGadget.Name = "alarmGadget";
            alarmGadget.Size = new Size(127, 19);
            alarmGadget.TabIndex = 3;
            alarmGadget.Text = "Alarme + R$ 700,00";
            alarmGadget.UseVisualStyleBackColor = true;
            alarmGadget.CheckedChanged += alarmGadget_CheckedChanged;
            // 
            // soundGadget
            // 
            soundGadget.AutoSize = true;
            soundGadget.Location = new Point(281, 44);
            soundGadget.Name = "soundGadget";
            soundGadget.Size = new Size(122, 19);
            soundGadget.TabIndex = 2;
            soundGadget.Text = "Som + R$ 2.500,00";
            soundGadget.UseVisualStyleBackColor = true;
            soundGadget.CheckedChanged += soundGadget_CheckedChanged;
            // 
            // wheelsGadget
            // 
            wheelsGadget.AutoSize = true;
            wheelsGadget.Location = new Point(52, 87);
            wheelsGadget.Name = "wheelsGadget";
            wheelsGadget.Size = new Size(198, 19);
            wheelsGadget.TabIndex = 1;
            wheelsGadget.Text = "Rodas de Liga Leve + R$ 2.000,00";
            wheelsGadget.UseVisualStyleBackColor = true;
            wheelsGadget.CheckedChanged += wheelsGadget_CheckedChanged;
            // 
            // insufilmGadget
            // 
            insufilmGadget.AutoSize = true;
            insufilmGadget.Location = new Point(52, 44);
            insufilmGadget.Name = "insufilmGadget";
            insufilmGadget.Size = new Size(132, 19);
            insufilmGadget.TabIndex = 0;
            insufilmGadget.Text = "Insufilm + R$ 350,00";
            insufilmGadget.UseVisualStyleBackColor = true;
            insufilmGadget.CheckedChanged += insufilmGadget_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 428);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor total:";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            total.ForeColor = Color.DodgerBlue;
            total.Location = new Point(64, 404);
            total.Name = "total";
            total.Size = new Size(137, 45);
            total.TabIndex = 3;
            total.Text = "R$ 0,00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 22);
            label3.Name = "label3";
            label3.Size = new Size(383, 40);
            label3.TabIndex = 4;
            label3.Text = "Escolha cores e acessórios";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 458);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(total);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton redColor;
        private RadioButton silverColor;
        private RadioButton blackColor;
        private RadioButton whiteColor;
        private CheckBox alarmGadget;
        private CheckBox soundGadget;
        private CheckBox wheelsGadget;
        private CheckBox insufilmGadget;
        private Label label1;
        private Label total;
        private Label label3;
    }
}