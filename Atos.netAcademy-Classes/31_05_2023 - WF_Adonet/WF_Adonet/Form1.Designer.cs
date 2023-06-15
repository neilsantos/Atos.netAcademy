namespace WF_Adonet
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
            BtnFiltrar = new Button();
            TxbNome = new TextBox();
            dataGridView1 = new DataGridView();
            BtnTodos = new Button();
            BtnCadastrar = new Button();
            textBoxProfissao = new TextBox();
            textBoxNome = new TextBox();
            LabelNome = new Label();
            label2 = new Label();
            BtnRemover = new Button();
            BtnDRFiltro = new Button();
            TexBoxDR = new TextBox();
            LblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Location = new Point(574, 37);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(75, 23);
            BtnFiltrar.TabIndex = 0;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // TxbNome
            // 
            TxbNome.Location = new Point(413, 37);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(155, 23);
            TxbNome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(122, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(527, 150);
            dataGridView1.TabIndex = 2;
            // 
            // BtnTodos
            // 
            BtnTodos.Location = new Point(122, 36);
            BtnTodos.Name = "BtnTodos";
            BtnTodos.Size = new Size(75, 23);
            BtnTodos.TabIndex = 3;
            BtnTodos.Text = "Consultar";
            BtnTodos.UseVisualStyleBackColor = true;
            BtnTodos.Click += BtnTodos_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(68, 385);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 4;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // textBoxProfissao
            // 
            textBoxProfissao.Location = new Point(68, 356);
            textBoxProfissao.Name = "textBoxProfissao";
            textBoxProfissao.Size = new Size(100, 23);
            textBoxProfissao.TabIndex = 5;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(68, 327);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 6;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(24, 330);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(40, 15);
            LabelNome.TabIndex = 7;
            LabelNome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 359);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Profissão";
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(574, 217);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(75, 23);
            BtnRemover.TabIndex = 9;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            BtnRemover.Click += BtnRemover_Click;
            // 
            // BtnDRFiltro
            // 
            BtnDRFiltro.Location = new Point(733, 138);
            BtnDRFiltro.Name = "BtnDRFiltro";
            BtnDRFiltro.Size = new Size(75, 23);
            BtnDRFiltro.TabIndex = 10;
            BtnDRFiltro.Text = "DR Filtro";
            BtnDRFiltro.UseVisualStyleBackColor = true;
            BtnDRFiltro.Click += BtnDRFiltro_Click;
            // 
            // TexBoxDR
            // 
            TexBoxDR.Location = new Point(708, 111);
            TexBoxDR.Name = "TexBoxDR";
            TexBoxDR.Size = new Size(100, 23);
            TexBoxDR.TabIndex = 11;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(710, 86);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(12, 15);
            LblNome.TabIndex = 12;
            LblNome.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 606);
            Controls.Add(LblNome);
            Controls.Add(TexBoxDR);
            Controls.Add(BtnDRFiltro);
            Controls.Add(BtnRemover);
            Controls.Add(label2);
            Controls.Add(LabelNome);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxProfissao);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnTodos);
            Controls.Add(dataGridView1);
            Controls.Add(TxbNome);
            Controls.Add(BtnFiltrar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFiltrar;
        private TextBox TxbNome;
        private DataGridView dataGridView1;
        private Button BtnTodos;
        private Button BtnCadastrar;
        private TextBox textBoxProfissao;
        private TextBox textBoxNome;
        private Label LabelNome;
        private Label label2;
        private Button BtnRemover;
        private Button BtnDRFiltro;
        private TextBox TexBoxDR;
        private Label LblNome;
    }
}