using System.Runtime.Serialization.Formatters.Binary;
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
            FileStream fs = new FileStream(@"C:\Teste\InputText.data", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            string mensagem = TextBoxInput.Text;
            bf.Serialize(fs, mensagem);
            fs.Close();

        }

        private void BtnDSerialization_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Teste\InputText.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            string msgDesserializada = (string)bf.Deserialize(fs);
            TextBoxOutput.Text = msgDesserializada;
        }

        private void BtnSerializationPerson_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = TextBoxNome.Text;
            p.idade = int.Parse(TextBoxIdade.Text);
            p.salario = double.Parse(TextBoxIdade.Text);

            FileStream fs = new FileStream(@"C:\Teste\pessoal.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

            xml.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("Serializado em XML");
        }

        private void BtnDesserialization2_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            StreamReader reader = new StreamReader(@"C:\Teste\pessoal.xml");
            Pessoa p;
            p = (Pessoa)xml.Deserialize(reader);
            TextBoxDesserializationPerson.AppendText(p.nome.ToString());
            TextBoxDesserializationPerson.AppendText(p.idade.ToString());
            TextBoxDesserializationPerson.AppendText(p.salario.ToString());

        }
    }
}