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
            BtnIn = new Button();
            BtnOut = new Button();
            listViewInfo = new ListView();
            modo = new ColumnHeader();
            placa = new ColumnHeader();
            dateIn = new ColumnHeader();
            dateOut = new ColumnHeader();
            SuspendLayout();
            // 
            // BtnIn
            // 
            BtnIn.Location = new Point(22, 28);
            BtnIn.Name = "BtnIn";
            BtnIn.Size = new Size(92, 36);
            BtnIn.TabIndex = 0;
            BtnIn.Text = "Dar Entrada";
            BtnIn.UseVisualStyleBackColor = true;
            BtnIn.Click += BtnIn_Click;
            // 
            // BtnOut
            // 
            BtnOut.Location = new Point(964, 496);
            BtnOut.Name = "BtnOut";
            BtnOut.Size = new Size(92, 36);
            BtnOut.TabIndex = 1;
            BtnOut.Text = "Dar Saída";
            BtnOut.UseVisualStyleBackColor = true;
            BtnOut.Click += BtnOut_Click;
            // 
            // listViewInfo
            // 
            listViewInfo.Columns.AddRange(new ColumnHeader[] { placa, modo, dateIn, dateOut });
            listViewInfo.Location = new Point(521, 28);
            listViewInfo.Name = "listViewInfo";
            listViewInfo.Size = new Size(535, 229);
            listViewInfo.TabIndex = 2;
            listViewInfo.UseCompatibleStateImageBehavior = false;
            listViewInfo.View = View.Details;
            // 
            // modo
            // 
            modo.Text = "Modo";
            modo.Width = 100;
            // 
            // placa
            // 
            placa.Text = "Placa";
            placa.TextAlign = HorizontalAlignment.Center;
            placa.Width = 100;
            // 
            // dateIn
            // 
            dateIn.Text = "DataEntrada";
            dateIn.TextAlign = HorizontalAlignment.Center;
            dateIn.Width = 100;
            // 
            // dateOut
            // 
            dateOut.Text = "DataSaida";
            dateOut.TextAlign = HorizontalAlignment.Center;
            dateOut.Width = 100;
            // 
            // ParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 572);
            Controls.Add(listViewInfo);
            Controls.Add(BtnOut);
            Controls.Add(BtnIn);
            Name = "ParkForm";
            Text = "Form1";
            Load += ParkForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIn;
        private Button BtnOut;
        private ListView listViewInfo;
        private ColumnHeader modo;
        private ColumnHeader placa;
        private ColumnHeader dateIn;
        private ColumnHeader dateOut;
    }
}