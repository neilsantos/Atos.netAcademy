namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClearList.Enabled = false;
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome))
            {
                MessageBox.Show("Os Campos Nome e Sobrenome precisam estar preenchidos");
                textBoxNome.Text = string.Empty;
                textBoxSobrenome.Text = string.Empty;
                return;
            }

            var verificarNome = nome.Split();
            var verificarSobrenome = sobrenome.Split();

            if (verificarNome.Length != 1 || verificarSobrenome.Length != 1)
            {
                MessageBox.Show("Apenas um nome ou sobrenome");
                textBoxNome.Text = string.Empty;
                textBoxSobrenome.Text = string.Empty;
                return;
            }

            string email = nome.ToLower() + sobrenome.ToLower() + "@gmail.com.br";
            labelResult.Text = "Ultimo Gerado: " + email;
            textBoxListaEmails.AppendText(email + Environment.NewLine);
            buttonClearList.Enabled = true;

            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;

        }
        private void buttonClearList_Click(object sender, EventArgs e)
        {
            textBoxListaEmails.Text = string.Empty;
            buttonClearList.Enabled = false;
        }
    }
}