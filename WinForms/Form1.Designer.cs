namespace WinForms
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
            buttonGerarEmail = new Button();
            labelNomeDoJogador = new Label();
            textBoxNome = new TextBox();
            labelSobrenome = new Label();
            textBoxSobrenome = new TextBox();
            labelResult = new Label();
            textBoxListaEmails = new TextBox();
            buttonClearList = new Button();
            SuspendLayout();
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.Location = new Point(173, 149);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(90, 27);
            buttonGerarEmail.TabIndex = 0;
            buttonGerarEmail.Text = "Gerar Email";
            buttonGerarEmail.UseVisualStyleBackColor = true;
            buttonGerarEmail.Click += button1_Click;
            // 
            // labelNomeDoJogador
            // 
            labelNomeDoJogador.AutoSize = true;
            labelNomeDoJogador.Location = new Point(22, 46);
            labelNomeDoJogador.Name = "labelNomeDoJogador";
            labelNomeDoJogador.Size = new Size(40, 15);
            labelNomeDoJogador.TabIndex = 1;
            labelNomeDoJogador.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(22, 64);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(241, 23);
            textBoxNome.TabIndex = 2;
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(22, 102);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 3;
            labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(22, 120);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(241, 23);
            textBoxSobrenome.TabIndex = 4;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(70, 210);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(148, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "Clique no botão para gerar";
            // 
            // textBoxListaEmails
            // 
            textBoxListaEmails.Location = new Point(340, 36);
            textBoxListaEmails.Multiline = true;
            textBoxListaEmails.Name = "textBoxListaEmails";
            textBoxListaEmails.ReadOnly = true;
            textBoxListaEmails.ScrollBars = ScrollBars.Vertical;
            textBoxListaEmails.Size = new Size(267, 189);
            textBoxListaEmails.TabIndex = 6;
            // 
            // buttonClearList
            // 
            buttonClearList.Location = new Point(532, 231);
            buttonClearList.Name = "buttonClearList";
            buttonClearList.Size = new Size(75, 23);
            buttonClearList.TabIndex = 7;
            buttonClearList.Text = "Limpar";
            buttonClearList.UseVisualStyleBackColor = true;
            buttonClearList.Click += buttonClearList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 290);
            Controls.Add(buttonClearList);
            Controls.Add(textBoxListaEmails);
            Controls.Add(labelResult);
            Controls.Add(textBoxSobrenome);
            Controls.Add(labelSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(labelNomeDoJogador);
            Controls.Add(buttonGerarEmail);
            Name = "Form1";
            Text = "Exemplo de WinForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGerarEmail;
        private Label labelNomeDoJogador;
        private TextBox textBoxNome;
        private Label labelSobrenome;
        private TextBox textBoxSobrenome;
        private Label labelResult;
        private TextBox textBoxListaEmails;
        private Button buttonClearList;
    }
}