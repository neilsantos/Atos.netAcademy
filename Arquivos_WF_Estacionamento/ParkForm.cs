using System.Reflection.Metadata;

namespace Arquivos_WF_Estacionamento
{
    public partial class ParkForm : Form
    {
        public ParkForm()
        {
            InitializeComponent();
        }

        private void ParkForm_Load(object sender, EventArgs e)
        {   
            List<ListViewInfo> infos = new List<ListViewInfo>();
            string[] item = new string[4];
            for (int i = 0; i < 10; i++)
            {
                infos.Add(new ListViewInfo("ENTRADA","PLACA","ENTRADA","SAIDA"));
            }
            foreach (ListViewInfo info in infos)
            {
                item[0] = info.Modo.ToString();
                item[1] = info.Placa.ToString();
                item[2] = info.Entrada.ToString();
                item[3] = info.Saida.ToString();
                listViewInfo.Items.Add(new ListViewItem(item));
            }
        }
    }
}



