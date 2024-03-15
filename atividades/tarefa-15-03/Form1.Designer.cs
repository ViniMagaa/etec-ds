namespace tarefa_15_03
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
            error_name = new Label();
            name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            card_number = new TextBox();
            error_card_number = new Label();
            SuspendLayout();
            // 
            // error_name
            // 
            error_name.AutoSize = true;
            error_name.ForeColor = Color.Red;
            error_name.Location = new Point(24, 142);
            error_name.Name = "error_name";
            error_name.Size = new Size(137, 20);
            error_name.TabIndex = 0;
            error_name.Text = "Campo obrigatório";
            // 
            // name
            // 
            name.Location = new Point(27, 112);
            name.Name = "name";
            name.Size = new Size(261, 27);
            name.TabIndex = 1;
            name.TextChanged += name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 2;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 177);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 6;
            label3.Text = "Nº do Cartão";
            label3.Click += this.label3_Click;
            // 
            // card_number
            // 
            card_number.Location = new Point(27, 200);
            card_number.Name = "card_number";
            card_number.Size = new Size(261, 27);
            card_number.TabIndex = 5;
            card_number.TextChanged += this.card_number_TextChanged;
            // 
            // error_card_number
            // 
            error_card_number.AutoSize = true;
            error_card_number.ForeColor = Color.Red;
            error_card_number.Location = new Point(24, 230);
            error_card_number.Name = "error_card_number";
            error_card_number.Size = new Size(137, 20);
            error_card_number.TabIndex = 4;
            error_card_number.Text = "Campo obrigatório";
            error_card_number.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(card_number);
            Controls.Add(error_card_number);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(error_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label error_name;
        private TextBox name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox card_number;
        private Label error_card_number;
    }
}
