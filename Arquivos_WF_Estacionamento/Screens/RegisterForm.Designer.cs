namespace Arquivos_WF_Estacionamento
{
    partial class RegisterForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            BtnSaveRegisterForm = new Button();
            label1 = new Label();
            label2 = new Label();
            Btn_CancelRegisterForm = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 1;
            // 
            // BtnSaveRegisterForm
            // 
            BtnSaveRegisterForm.Location = new Point(233, 132);
            BtnSaveRegisterForm.Name = "BtnSaveRegisterForm";
            BtnSaveRegisterForm.Size = new Size(111, 34);
            BtnSaveRegisterForm.TabIndex = 2;
            BtnSaveRegisterForm.Text = "Salvar";
            BtnSaveRegisterForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 50);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "PLACA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 81);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "MODELO VEÍCULO";
            // 
            // Btn_CancelRegisterForm
            // 
            Btn_CancelRegisterForm.Location = new Point(116, 132);
            Btn_CancelRegisterForm.Name = "Btn_CancelRegisterForm";
            Btn_CancelRegisterForm.Size = new Size(111, 34);
            Btn_CancelRegisterForm.TabIndex = 5;
            Btn_CancelRegisterForm.Text = "Cancelar";
            Btn_CancelRegisterForm.UseVisualStyleBackColor = true;
            Btn_CancelRegisterForm.Click += Btn_CancelRegisterForm_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 181);
            Controls.Add(Btn_CancelRegisterForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSaveRegisterForm);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button Btn_CancelRegisterForm;
        private Button BtnSaveRegisterForm;
    }
}