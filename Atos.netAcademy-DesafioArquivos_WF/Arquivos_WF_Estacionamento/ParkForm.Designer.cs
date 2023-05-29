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
            LabelTempo = new Label();
            numericUpDown1 = new NumericUpDown();
            LableModelo = new TextBox();
            LablePlaca = new TextBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            LabelData = new Label();
            TimerHora = new System.Windows.Forms.Timer(components);
            LabelHora = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnOut
            // 
            BtnOut.Location = new Point(971, 446);
            BtnOut.Name = "BtnOut";
            BtnOut.Size = new Size(92, 25);
            BtnOut.TabIndex = 1;
            BtnOut.Text = "Dar Saída";
            BtnOut.UseVisualStyleBackColor = true;
            BtnOut.Click += BtnOut_Click;
            // 
            // listViewInfo
            // 
            listViewInfo.Columns.AddRange(new ColumnHeader[] { Placa, Modelo, DataEntrada, DataSaida });
            listViewInfo.Location = new Point(423, 139);
            listViewInfo.Name = "listViewInfo";
            listViewInfo.Size = new Size(640, 259);
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
            button1.Location = new Point(840, 446);
            button1.Name = "button1";
            button1.Size = new Size(125, 25);
            button1.TabIndex = 3;
            button1.Text = "Mais Informações";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 202);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 5;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 238);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 6;
            label2.Text = "Modelo";
            // 
            // LabelTempo
            // 
            LabelTempo.AutoSize = true;
            LabelTempo.Location = new Point(57, 270);
            LabelTempo.Name = "LabelTempo";
            LabelTempo.Size = new Size(48, 17);
            LabelTempo.TabIndex = 7;
            LabelTempo.Text = "Tempo";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(133, 267);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 12;
            // 
            // LableModelo
            // 
            LableModelo.Location = new Point(133, 230);
            LableModelo.Name = "LableModelo";
            LableModelo.Size = new Size(120, 25);
            LableModelo.TabIndex = 11;
            // 
            // LablePlaca
            // 
            LablePlaca.Location = new Point(133, 199);
            LablePlaca.Name = "LablePlaca";
            LablePlaca.Size = new Size(120, 25);
            LablePlaca.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(316, 230);
            button2.Name = "button2";
            button2.Size = new Size(40, 43);
            button2.TabIndex = 13;
            button2.Text = "->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            LabelData.Location = new Point(848, 528);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(178, 17);
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
            LabelHora.Location = new Point(1007, 528);
            LabelHora.Name = "LabelHora";
            LabelHora.Size = new Size(56, 17);
            LabelHora.TabIndex = 14;
            LabelHora.Text = "13:26:25";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(950, 43);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 15;
            label3.Text = "Vagas Disponiveis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(821, 43);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 16;
            label4.Text = "Vagas Ocupadas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(870, 68);
            label5.Name = "label5";
            label5.Size = new Size(13, 17);
            label5.TabIndex = 17;
            label5.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1007, 68);
            label6.Name = "label6";
            label6.Size = new Size(13, 17);
            label6.TabIndex = 18;
            label6.Text = "-";
            // 
            // ParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 559);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LabelHora);
            Controls.Add(LabelData);
            Controls.Add(button2);
            Controls.Add(LablePlaca);
            Controls.Add(LableModelo);
            Controls.Add(numericUpDown1);
            Controls.Add(LabelTempo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listViewInfo);
            Controls.Add(BtnOut);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "ParkForm";
            ShowIcon = false;
            Text = "Estacionamento";
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
        private Label LabelTempo;
        private NumericUpDown numericUpDown1;
        private TextBox LableModelo;
        private TextBox LablePlaca;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private Label LabelData;
        private System.Windows.Forms.Timer TimerHora;
        private Label LabelHora;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}