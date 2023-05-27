using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Arquivos_WF_Estacionamento.Model;
using Arquivos_WF_Estacionamento.Repository;

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
            var show = new ListViewInfo();
            var file = new FileManager();
            bool isOK = file.ReadFromFile(out string[]? result);

            if(!isOK)
            {
                MessageBox.Show("Arquivo N�o encontrado, verifique o caminho da base de dados!");
                this.Close();
            }
            
            bool isValid;
            if (result == null)
                return;
            else
            {
                isValid = file.VerifyDataBaseIntegrity(result);
            }

            if (!isValid)
            {
                MessageBox.Show("Arquivo Invalido!");
                return;
            }
            FileManager fileManager = new FileManager();
            fileManager.ReadFromFile(out var _data);

            RepositoryVeiculo repositorioVeiculo = new RepositoryVeiculo();
            var veiculos = repositorioVeiculo.ToObject(_data);

            show.populateListView(veiculos, listViewInfo);
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {

            var m = new RegisterForm();
            m.Show();

        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            string? item;
            try
            {
                item = listViewInfo.SelectedItems[0].Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Precisa selecionar um item da lista primeiro!");
                return;
            }
            //Incluir ConfirmationBOX
          
            MessageBox.Show(item) ;

            
        }
    }
}

//string datetime = "26/02/2023 16:16:13";
//var date = DateTime.Parse(datetime);
//string time = "01:00:00";
//TimeSpan timeSpan = TimeSpan.Parse(time);

