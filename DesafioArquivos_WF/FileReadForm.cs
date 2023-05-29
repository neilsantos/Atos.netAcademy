using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesafioArquivos_WF
{
    public partial class FileReadForm : Form
    {
        private readonly List<Student> People;
        string[]? _data;
        private int _studentsQuantity = 0;

        public FileReadForm()
        {
            InitializeComponent();
            People = new List<Student>();
            _data = new string[0];
        }
        private void FileReadForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                "1. O arquivo est� referenciado no c�digo a partir da pasta do projeto, basta clicar em Ler Arquivo." + "\n\n" +
                "2. Se o arquivo for alterado e o cabe�alho n�o estiver presente ou com letra diferente, o programa vai indicar 'Arquivo Inv�lido'. "
                + "\n\n" +
                "3. Caso o arquivo n�o exista na pasta, or programa vai avisar que o arquivo n�o foi encontrado."

                , "AVISO!");
        }
        private bool LoadFile()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\database.txt");
            string filePath = Path.GetFullPath(sFile);

            try
            {
                _data = File.ReadAllLines(filePath);
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Arquivo N�o Encontrado!", "ERRO!");
                _data = null;
                return false;
            }

            if (_data != null)
            {
                string header = _data[0];
                if (header[0] != 'X')
                {
                    MessageBox.Show("Arquivo incompat�vel, cabe�alho fora dos padr�es", "ERRO");
                    return false;
                }
            }
            return true;
        }
        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            bool _isSafeToProceed = LoadFile();

            if (!_isSafeToProceed)
                return;

            ReadFile();
            ShowData();
            BtnReadFile.Enabled = false;
        }
        private void ReadFile()
        {
            if (_data != null)
            {
                foreach (var line in _data)
                {
                    if (line[0] == 'Z')
                    {
                        var aluno = line.Split("-");
                        Student Student = new Student();

                        Student.Nome = aluno[1];
                        Student.Telefone = aluno[2];
                        Student.Cidade = aluno[3];
                        Student.RG = aluno[4];
                        Student.CPF = aluno[5];

                        People.Add(Student);
                    }
                    if (line[0] == 'Y')
                    {
                        var lastStudent = People.Last();
                        var studentData = line.Split("-");
                        lastStudent.Matricula = studentData[1];
                        lastStudent.CodigoCurso = int.Parse(studentData[2]);
                        lastStudent.NomeCurso = studentData[3];
                        _studentsQuantity++;
                    }

                }
                _data = null;
            }
            else
                return;
        }
        private void ShowData()
        {
            foreach (var person in People)
            {
                if (person.CodigoCurso == 0)
                {
                    txtbox_output.AppendText("Nome: " + person.Nome + Environment.NewLine);
                    txtbox_output.AppendText("Telefone: " + person.Telefone + Environment.NewLine);
                    txtbox_output.AppendText("Cidade: " + person.Cidade + Environment.NewLine);
                    txtbox_output.AppendText("RG: " + person.RG + Environment.NewLine);
                    txtbox_output.AppendText("CPF: " + person.CPF + Environment.NewLine);
                    txtbox_output.AppendText(Environment.NewLine);
                    txtbox_output.AppendText("[ SEM DADOS DE ESTUDANTE ]" + Environment.NewLine);
                    txtbox_output.AppendText("---------------------------" + Environment.NewLine);
                }
                else
                {
                    txtbox_output.AppendText("Nome: " + person.Nome + Environment.NewLine);
                    txtbox_output.AppendText("Telefone: " + person.Telefone + Environment.NewLine);
                    txtbox_output.AppendText("Cidade: " + person.Cidade + Environment.NewLine);
                    txtbox_output.AppendText("RG: " + person.RG + Environment.NewLine);
                    txtbox_output.AppendText("CPF: " + person.CPF + Environment.NewLine);
                    txtbox_output.AppendText("Matricula: " + person.Matricula + Environment.NewLine);
                    txtbox_output.AppendText("Codigo do Curso: " + person.CodigoCurso + Environment.NewLine);
                    txtbox_output.AppendText("Nome do Curso: " + person.NomeCurso + Environment.NewLine);
                    txtbox_output.AppendText("---------------------------" + Environment.NewLine);
                }
            }
            labelPersonCount.Text = (People.Count() - _studentsQuantity).ToString();
            labelStudentCount.Text = _studentsQuantity.ToString();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelStudentCount.Text = "-";
            labelPersonCount.Text = "-";
            _studentsQuantity = 0;
            People.Clear();
            txtbox_output.Text = string.Empty;
            BtnReadFile.Enabled = true;
        }

    }
}