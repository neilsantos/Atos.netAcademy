namespace Criptografia
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
            TextBoxMessage = new TextBox();
            BtnCrypt = new Button();
            BtnDecrypt = new Button();
            TextBoxFileOutput = new TextBox();
            BtnDecryptFile = new Button();
            BtnAssimetrico = new Button();
            textBoxAssimetricoOutput = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "SIMETRICO";
            // 
            // TextBoxMessage
            // 
            TextBoxMessage.Location = new Point(42, 59);
            TextBoxMessage.Multiline = true;
            TextBoxMessage.Name = "TextBoxMessage";
            TextBoxMessage.Size = new Size(255, 92);
            TextBoxMessage.TabIndex = 1;
            // 
            // BtnCrypt
            // 
            BtnCrypt.Location = new Point(42, 157);
            BtnCrypt.Name = "BtnCrypt";
            BtnCrypt.Size = new Size(87, 23);
            BtnCrypt.TabIndex = 2;
            BtnCrypt.Text = "Criptografar";
            BtnCrypt.UseVisualStyleBackColor = true;
            BtnCrypt.Click += BtnCriptografar_Click;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(200, 157);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(97, 23);
            BtnDecrypt.TabIndex = 7;
            BtnDecrypt.Text = "Decriptografar";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // TextBoxFileOutput
            // 
            TextBoxFileOutput.Location = new Point(451, 59);
            TextBoxFileOutput.Multiline = true;
            TextBoxFileOutput.Name = "TextBoxFileOutput";
            TextBoxFileOutput.Size = new Size(255, 92);
            TextBoxFileOutput.TabIndex = 8;
            // 
            // BtnDecryptFile
            // 
            BtnDecryptFile.Location = new Point(609, 157);
            BtnDecryptFile.Name = "BtnDecryptFile";
            BtnDecryptFile.Size = new Size(97, 23);
            BtnDecryptFile.TabIndex = 9;
            BtnDecryptFile.Text = "Decriptografar";
            BtnDecryptFile.UseVisualStyleBackColor = true;
            BtnDecryptFile.Click += BtnDecryptFile_Click;
            // 
            // BtnAssimetrico
            // 
            BtnAssimetrico.Location = new Point(42, 451);
            BtnAssimetrico.Name = "BtnAssimetrico";
            BtnAssimetrico.Size = new Size(87, 23);
            BtnAssimetrico.TabIndex = 10;
            BtnAssimetrico.Text = "Criptografar";
            BtnAssimetrico.UseVisualStyleBackColor = true;
            BtnAssimetrico.Click += BtnAssimetrico_Click;
            // 
            // textBoxAssimetricoOutput
            // 
            textBoxAssimetricoOutput.Location = new Point(42, 353);
            textBoxAssimetricoOutput.Multiline = true;
            textBoxAssimetricoOutput.Name = "textBoxAssimetricoOutput";
            textBoxAssimetricoOutput.Size = new Size(255, 92);
            textBoxAssimetricoOutput.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 335);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 12;
            label2.Text = "ASSIMETRICO";
            // 
            // button1
            // 
            button1.Location = new Point(200, 451);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 13;
            button1.Text = "Decriptografar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 669);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxAssimetricoOutput);
            Controls.Add(BtnAssimetrico);
            Controls.Add(BtnDecryptFile);
            Controls.Add(TextBoxFileOutput);
            Controls.Add(BtnDecrypt);
            Controls.Add(BtnCrypt);
            Controls.Add(TextBoxMessage);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxMessage;
        private Button BtnCrypt;
        private Button BtnDecrypt;
        private TextBox TextBoxFileOutput;
        private Button BtnDecryptFile;
        private Button BtnAssimetrico;
        private TextBox textBoxAssimetricoOutput;
        private Label label2;
        private Button button1;
    }
}