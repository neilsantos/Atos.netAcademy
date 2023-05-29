using System.Xml.Serialization;

namespace serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSerialization_Click(object sender, EventArgs e)
        {

        }

        private void BtnDSerialization_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = TextBoxNome.Text;
            p.idade = int.Parse(TextBoxIdade.Text);
            p.salario = double.Parse(TextBoxIdade.Text);

            FileStream fs = new FileStream(@"C:\Teste\pessoal.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

            xml.Serialize(fs, p);

            MessageBox.Show("Serializado em XML");
        }
    }
}