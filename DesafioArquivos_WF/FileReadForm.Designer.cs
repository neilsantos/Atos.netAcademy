namespace DesafioArquivos_WF
{
    partial class FileReadForm
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
            BtnReadFile = new Button();
            txtbox_output = new TextBox();
            labelStudentCountTitle = new Label();
            labelPersonCountTitle = new Label();
            labelStudentCount = new Label();
            labelPersonCount = new Label();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // BtnReadFile
            // 
            BtnReadFile.Location = new Point(135, 170);
            BtnReadFile.Name = "BtnReadFile";
            BtnReadFile.Size = new Size(111, 23);
            BtnReadFile.TabIndex = 0;
            BtnReadFile.Text = "Ler Arquivo";
            BtnReadFile.UseVisualStyleBackColor = true;
            BtnReadFile.Click += BtnReadFile_Click;
            // 
            // txtbox_output
            // 
            txtbox_output.Location = new Point(423, 12);
            txtbox_output.Multiline = true;
            txtbox_output.Name = "txtbox_output";
            txtbox_output.ReadOnly = true;
            txtbox_output.ScrollBars = ScrollBars.Vertical;
            txtbox_output.Size = new Size(467, 476);
            txtbox_output.TabIndex = 1;
            // 
            // labelStudentCountTitle
            // 
            labelStudentCountTitle.AutoSize = true;
            labelStudentCountTitle.Location = new Point(41, 376);
            labelStudentCountTitle.Name = "labelStudentCountTitle";
            labelStudentCountTitle.Size = new Size(125, 15);
            labelStudentCountTitle.TabIndex = 2;
            labelStudentCountTitle.Text = "Quantidade de Alunos";
            // 
            // labelPersonCountTitle
            // 
            labelPersonCountTitle.AutoSize = true;
            labelPersonCountTitle.Location = new Point(206, 376);
            labelPersonCountTitle.Name = "labelPersonCountTitle";
            labelPersonCountTitle.Size = new Size(129, 15);
            labelPersonCountTitle.TabIndex = 3;
            labelPersonCountTitle.Text = "Quantidade de Pessoas";
            // 
            // labelStudentCount
            // 
            labelStudentCount.AutoSize = true;
            labelStudentCount.Location = new Point(100, 401);
            labelStudentCount.Name = "labelStudentCount";
            labelStudentCount.Size = new Size(12, 15);
            labelStudentCount.TabIndex = 4;
            labelStudentCount.Text = "-";
            // 
            // labelPersonCount
            // 
            labelPersonCount.AutoSize = true;
            labelPersonCount.Location = new Point(262, 401);
            labelPersonCount.Name = "labelPersonCount";
            labelPersonCount.Size = new Size(12, 15);
            labelPersonCount.TabIndex = 5;
            labelPersonCount.Text = "-";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(815, 506);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // FileReadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(917, 541);
            Controls.Add(buttonReset);
            Controls.Add(labelPersonCount);
            Controls.Add(labelStudentCount);
            Controls.Add(labelPersonCountTitle);
            Controls.Add(labelStudentCountTitle);
            Controls.Add(txtbox_output);
            Controls.Add(BtnReadFile);
            Name = "FileReadForm";
            Text = "FileRead";
            Load += FileReadForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_output;
        private Label labelStudentCountTitle;
        private Label labelPersonCountTitle;
        private Label labelStudentCount;
        private Label labelPersonCount;
        private Button buttonReset;
        private Button BtnReadFile;
    }
}