using CriptografiaSimetricaAndAssimetrica;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        private readonly Simetrica criptografiaSimetrica;
        private readonly Assimetrica criptografiaAssimetrica;

        public Form1()
        {
            InitializeComponent();
            criptografiaSimetrica = new Simetrica();
            criptografiaAssimetrica = new Assimetrica();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCriptografar_Click(object sender, EventArgs e)
        {

            string msg = TextBoxMessage.Text;
            string msgCripto = criptografiaSimetrica.EncryptData(msg, "atos");

            TextBoxMessage.Text = string.Empty;
            TextBoxMessage.Text = msgCripto;

        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string msg = TextBoxMessage.Text;
            TextBoxMessage.Text = string.Empty;

            string msgCripto = criptografiaSimetrica.DecryptData(msg, "atos");
            TextBoxMessage.Text = msgCripto;
        }

        private void BtnDecryptFile_Click(object sender, EventArgs e)
        {
            var data = File.ReadAllText("C:\\Users\\neila\\source\\Atos.netAcademy\\Atos.netAcademy-classes\\Aula3005\\Criptografia\\dadoscripto");
            TextBoxFileOutput.Text = criptografiaSimetrica.DecryptData(data, "atos20232");
        }

        private void BtnAssimetrico_Click(object sender, EventArgs e)
        {
            string mensagem = textBoxAssimetricoOutput.Text;
            textBoxAssimetricoOutput.Text = string.Empty;
            textBoxAssimetricoOutput.Text = criptografiaAssimetrica.encrypt(mensagem); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = textBoxAssimetricoOutput.Text;
            textBoxAssimetricoOutput.Text = string.Empty;
            textBoxAssimetricoOutput.Text = criptografiaAssimetrica.decrypt(mensagem);

        }
    }
}