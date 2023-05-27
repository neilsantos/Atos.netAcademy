using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Arquivos_WF_Estacionamento.Model;
using Arquivos_WF_Estacionamento.Repository;
using System.Globalization;

namespace Arquivos_WF_Estacionamento
{
    public partial class ParkForm : Form
    {
        Veiculo[] vagas = new Veiculo[50];

        public ParkForm()
        {
            InitializeComponent();
        }

        private void ParkForm_Load(object sender, EventArgs e)
        {
            data();
            var show = new ListViewInfo();
            var file = new FileManager();
            bool isOK = file.ReadFromFile(out string[]? result);

            if (!isOK)
            {
                MessageBox.Show("Arquivo Não encontrado, verifique o caminho da base de dados!");
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

            MessageBox.Show(item);


        }

        private void button1_Click(object sender, EventArgs e)
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

            MessageBox.Show(item);


        }
        public void data()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            string data = diasemana + ", " + dia + " de " + mes + " de " + ano;
            LabelData.Text = data;


        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            LabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

//string datetime = "26/02/2023 16:16:13";
//var date = DateTime.Parse(datetime);
//string time = "01:00:00";
//TimeSpan timeSpan = TimeSpan.Parse(time);

