namespace serialization
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
            TextBoxInput = new TextBox();
            BtnSerialization = new Button();
            TextBoxOutput = new TextBox();
            BtnDSerialization = new Button();
            TextBoxNome = new TextBox();
            TextBoxIdade = new TextBox();
            TextBoxSalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TextBoxInput
            // 
            TextBoxInput.Location = new Point(69, 46);
            TextBoxInput.Multiline = true;
            TextBoxInput.Name = "TextBoxInput";
            TextBoxInput.Size = new Size(318, 127);
            TextBoxInput.TabIndex = 0;
            // 
            // BtnSerialization
            // 
            BtnSerialization.Location = new Point(393, 45);
            BtnSerialization.Name = "BtnSerialization";
            BtnSerialization.Size = new Size(75, 128);
            BtnSerialization.TabIndex = 1;
            BtnSerialization.Text = "Serializar";
            BtnSerialization.UseVisualStyleBackColor = true;
            BtnSerialization.Click += BtnSerialization_Click;
            // 
            // TextBoxOutput
            // 
            TextBoxOutput.Location = new Point(151, 192);
            TextBoxOutput.Multiline = true;
            TextBoxOutput.Name = "TextBoxOutput";
            TextBoxOutput.Size = new Size(317, 128);
            TextBoxOutput.TabIndex = 2;
            // 
            // BtnDSerialization
            // 
            BtnDSerialization.Location = new Point(69, 192);
            BtnDSerialization.Name = "BtnDSerialization";
            BtnDSerialization.Size = new Size(75, 128);
            BtnDSerialization.TabIndex = 3;
            BtnDSerialization.Text = "Deserializar";
            BtnDSerialization.UseVisualStyleBackColor = true;
            BtnDSerialization.Click += BtnDSerialization_Click;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(683, 65);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(100, 23);
            TextBoxNome.TabIndex = 4;
            // 
            // TextBoxIdade
            // 
            TextBoxIdade.Location = new Point(683, 99);
            TextBoxIdade.Name = "TextBoxIdade";
            TextBoxIdade.Size = new Size(100, 23);
            TextBoxIdade.TabIndex = 5;
            // 
            // TextBoxSalario
            // 
            TextBoxSalario.Location = new Point(683, 134);
            TextBoxSalario.Name = "TextBoxSalario";
            TextBoxSalario.Size = new Size(100, 23);
            TextBoxSalario.TabIndex = 6;
            TextBoxSalario.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(637, 105);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 139);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Salario";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(639, 173);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxSalario);
            Controls.Add(TextBoxIdade);
            Controls.Add(TextBoxNome);
            Controls.Add(BtnDSerialization);
            Controls.Add(TextBoxOutput);
            Controls.Add(BtnSerialization);
            Controls.Add(TextBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxInput;
        private Button BtnSerialization;
        private TextBox TextBoxOutput;
        private Button BtnDSerialization;
        private TextBox TextBoxNome;
        private TextBox TextBoxIdade;
        private TextBox TextBoxSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}