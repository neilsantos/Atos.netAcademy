using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Arquivos_WF_Estacionamento.Model;
using System.Globalization;
using Arquivos_WF_Estacionamento.Infraestrutura.database.Repository;

namespace Arquivos_WF_Estacionamento
{
    public partial class ParkForm : Form
    {
        RepositoryParkingLot _parkingLot;
        ListViewInfo _listviewinfo;
        public ParkForm()
        {
            InitializeComponent();
            Data();
            _parkingLot = new RepositoryParkingLot();
            _listviewinfo = new ListViewInfo();
        }
        private void ParkForm_Load(object sender, EventArgs e)
        {


            var registros = _parkingLot.Load();
            _listviewinfo.populateListView(registros, listViewInfo);
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
        private void TimerHora_Tick(object sender, EventArgs e)
        {
            LabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            // Verificar se os dados estão corretos e não vazios
            var placa = LablePlaca.Text.ToUpper();
            var modelo = LableModelo.Text.ToUpper();
            var entrada = DateTime.Now;
            TimeSpan permanencia = new TimeSpan(1, 0, 0);
            var saida = DateTime.Now.Add(permanencia);

            Veiculo veiculo = new Veiculo(placa, modelo);
            ParkingLot parkSlot = new ParkingLot(veiculo, entrada, saida, permanencia, 0, "Entrada");

            // Verificar se o veiculo não está armazenado
            bool alreadyExist = _parkingLot.IsThisAlreadyParked(veiculo);
            if (alreadyExist)
            {
                MessageBox.Show("VEICULO JÁ CADASTRADO");
                return;
            }

            // Verificar se o estacionamento não está lotado.
            if (!_parkingLot.ThereIsSpace())
            {
                MessageBox.Show("Não Há Espaço no Estacionamento");
                return;
            }

            // Registrar veiculo
            var vagas = _parkingLot.RegisterVehicle(parkSlot);

            var show = new ListViewInfo();
            show.populateListView(vagas, listViewInfo);

        }

        private void Data()
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

    }
}



