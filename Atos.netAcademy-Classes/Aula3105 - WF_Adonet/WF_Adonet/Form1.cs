using System.Data;
using System.Windows.Forms;

namespace WF_Adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnRemover.Enabled = false;
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas"; /*where nome = '"+ TxbNome.Text + "'";*/

            DataTable dt = new DataTable();

            dt = bd.ExecutarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;

            BtnRemover.Enabled = true;
        }
        private void Consultar()
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas"; /*where nome = '"+ TxbNome.Text + "'";*/

            DataTable dt = new DataTable();

            dt = bd.ExecutarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;

            BtnRemover.Enabled = true;

        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = textBoxNome.Text;
            p.Profissao = textBoxProfissao.Text;

            if (p.GravarPessoa())
            {
                MessageBox.Show("Cadastrado com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar");
            }
            Consultar();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {

            var selected = dataGridView1.CurrentRow.Cells[0].Value;
            MessageBox.Show(selected.ToString());
        }

        private void BtnDRFiltro_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p = p.ConsultaPessoa(int.Parse(TexBoxDR.Text));

            LblNome.Text = p.Nome;
        }
    }
}