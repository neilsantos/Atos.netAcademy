namespace Arquivos_WF_Estacionamento
{
    partial class ParkForm
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
            components = new System.ComponentModel.Container();
            BtnOut = new Button();
            listViewInfo = new ListView();
            Placa = new ColumnHeader();
            Modelo = new ColumnHeader();
            DataEntrada = new ColumnHeader();
            DataSaida = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            LabelData = new Label();
            TimerHora = new System.Windows.Forms.Timer(components);
            LabelHora = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnOut
            // 
            BtnOut.Location = new Point(964, 263);
            BtnOut.Name = "BtnOut";
            BtnOut.Size = new Size(92, 23);
            BtnOut.TabIndex = 1;
            BtnOut.Text = "Dar Saída";
            BtnOut.UseVisualStyleBackColor = true;
            BtnOut.Click += BtnOut_Click;
            // 
            // listViewInfo
            // 
            listViewInfo.Columns.AddRange(new ColumnHeader[] { Placa, Modelo, DataEntrada, DataSaida });
            listViewInfo.Location = new Point(416, 28);
            listViewInfo.Name = "listViewInfo";
            listViewInfo.Size = new Size(640, 229);
            listViewInfo.TabIndex = 2;
            listViewInfo.UseCompatibleStateImageBehavior = false;
            listViewInfo.View = View.Details;
            // 
            // Placa
            // 
            Placa.Text = "Placa";
            Placa.Width = 100;
            // 
            // Modelo
            // 
            Modelo.Text = "Modelo";
            Modelo.TextAlign = HorizontalAlignment.Center;
            Modelo.Width = 100;
            // 
            // DataEntrada
            // 
            DataEntrada.Text = "DataEntrada";
            DataEntrada.TextAlign = HorizontalAlignment.Center;
            DataEntrada.Width = 150;
            // 
            // DataSaida
            // 
            DataSaida.Text = "Expira Em";
            DataSaida.TextAlign = HorizontalAlignment.Center;
            DataSaida.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(833, 263);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 3;
            button1.Text = "Mais Informações";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 84);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 116);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 6;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 144);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Tempo";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(123, 142);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(305, 119);
            button2.Name = "button2";
            button2.Size = new Size(40, 38);
            button2.TabIndex = 11;
            button2.Text = "->";
            button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1080, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { valoresToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.Size = new Size(111, 22);
            valoresToolStripMenuItem.Text = "Valores";
            // 
            // LabelData
            // 
            LabelData.AutoSize = true;
            LabelData.Location = new Point(848, 548);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(153, 15);
            LabelData.TabIndex = 13;
            LabelData.Text = "Sábado, 27 de Maio de 2023";
            // 
            // TimerHora
            // 
            TimerHora.Enabled = true;
            TimerHora.Tick += TimerHora_Tick;
            // 
            // LabelHora
            // 
            LabelHora.AutoSize = true;
            LabelHora.Location = new Point(1007, 548);
            LabelHora.Name = "LabelHora";
            LabelHora.Size = new Size(49, 15);
            LabelHora.TabIndex = 14;
            LabelHora.Text = "13:26:25";
            // 
            // ParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 572);
            Controls.Add(LabelHora);
            Controls.Add(LabelData);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listViewInfo);
            Controls.Add(BtnOut);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ParkForm";
            Text = "Form1";
            Load += ParkForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIn;
        private Button BtnOut;
        private ListView listViewInfo;
        private ColumnHeader Placa;
        private ColumnHeader DataEntrada;
        private ColumnHeader DataSaida;
        private ColumnHeader Modelo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private Label LabelData;
        private System.Windows.Forms.Timer TimerHora;
        private Label LabelHora;
    }
}