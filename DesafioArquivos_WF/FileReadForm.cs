using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesafioArquivos_WF
{
    public partial class FileReadForm : Form
    {
        private readonly List<Student> Students;
        string[]? _data;
        private int _studentsQuantity = 0;

        public FileReadForm()
        {
            InitializeComponent();
            Students = new List<Student>();
            _data = new string[0];
        }
        private void FileReadForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                "1. O arquivo está referenciado no código a partir da pasta do projeto, basta clicar em Ler Arquivo." + "\n\n" +
                "2. Se o arquivo for alterado e o cabeçalho não estiver presente ou com letra diferente, o programa vai indicar 'Arquivo Inválido'. "
                + "\n\n" +
                "3. Caso o arquivo não exista na pasta, or programa vai avisar que o arquivo não foi encontrado."

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

                MessageBox.Show("Arquivo Não Encontrado!", "ERRO!");
                _data = null;
                return false;
            }

            if (_data != null)
            {
                string header = _data[0];
                if (header[0] != 'X')
                {
                    MessageBox.Show("Arquivo incompatível, cabeçalho fora dos padrões", "ERRO");
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

                        Student.PersonalInformation.Nome = aluno[1];
                        Student.PersonalInformation.Telefone = aluno[2];
                        Student.PersonalInformation.Cidade = aluno[3];
                        Student.PersonalInformation.RG = aluno[4];
                        Student.PersonalInformation.CPF = aluno[5];

                        Students.Add(Student);
                    }
                    if (line[0] == 'Y')
                    {
                        var ultimoAluno = Students.Last();
                        var dadosAlunoCurso = line.Split("-");
                        ultimoAluno.Matricula = dadosAlunoCurso[1];
                        ultimoAluno.CodigoCurso = int.Parse(dadosAlunoCurso[2]);
                        ultimoAluno.NomeCurso = dadosAlunoCurso[3];
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
            foreach (var student in Students)
            {
                if (student.CodigoCurso == 0)
                {
                    txtbox_output.AppendText("Nome: " + student.PersonalInformation.Nome + Environment.NewLine);
                    txtbox_output.AppendText("Telefone: " + student.PersonalInformation.Telefone + Environment.NewLine);
                    txtbox_output.AppendText("Cidade: " + student.PersonalInformation.Cidade + Environment.NewLine);
                    txtbox_output.AppendText("RG: " + student.PersonalInformation.RG + Environment.NewLine);
                    txtbox_output.AppendText("CPF: " + student.PersonalInformation.CPF + Environment.NewLine);
                    txtbox_output.AppendText(Environment.NewLine);
                    txtbox_output.AppendText("[ SEM DADOS DE ESTUDANTE ]" + Environment.NewLine);
                    txtbox_output.AppendText("---------------------------" + Environment.NewLine);
                }
                else
                {
                    txtbox_output.AppendText("Nome: " + student.PersonalInformation.Nome + Environment.NewLine);
                    txtbox_output.AppendText("Telefone: " + student.PersonalInformation.Telefone + Environment.NewLine);
                    txtbox_output.AppendText("Cidade: " + student.PersonalInformation.Cidade + Environment.NewLine);
                    txtbox_output.AppendText("RG: " + student.PersonalInformation.RG + Environment.NewLine);
                    txtbox_output.AppendText("CPF: " + student.PersonalInformation.CPF + Environment.NewLine);
                    txtbox_output.AppendText("Matricula: " + student.Matricula + Environment.NewLine);
                    txtbox_output.AppendText("Codigo do Curso: " + student.CodigoCurso + Environment.NewLine);
                    txtbox_output.AppendText("Nome do Curso: " + student.NomeCurso + Environment.NewLine);
                    txtbox_output.AppendText("---------------------------" + Environment.NewLine);
                }
            }
            labelPersonCount.Text = (Students.Count() - _studentsQuantity).ToString();
            labelStudentCount.Text = _studentsQuantity.ToString();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelStudentCount.Text = "-";
            labelPersonCount.Text = "-";
            _studentsQuantity = 0;
            Students.Clear();
            txtbox_output.Text = string.Empty;
            BtnReadFile.Enabled = true;
        }


    }
}