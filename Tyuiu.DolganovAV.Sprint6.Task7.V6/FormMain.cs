using Tyuiu.DolganovAV.Sprint6.Task7.V6.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_DAV.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_DAV.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_DAV_Click(object sender, EventArgs e)
        {
            openFileDialog_DAV.ShowDialog();
            openFilePath = openFileDialog_DAV.FileName;

            // Сначала загружаем данные из файла - это установит rows и cols
            int[,] loadedArray = LoadFromFileData(openFilePath);

            // Только теперь rows и cols имеют правильные значения
            dataGridViewInput_DAV.ColumnCount = cols;
            dataGridViewOutput_DAV.ColumnCount = cols;
            dataGridViewOutput_DAV.RowCount = rows;
            dataGridViewInput_DAV.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewInput_DAV.Columns[i].Width = 35;
                dataGridViewOutput_DAV.Columns[i].Width = 35;
            }

            // Заполняем input DataGridView
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)  // исправлено: c++ вместо r++
                {
                    dataGridViewInput_DAV.Rows[r].Cells[c].Value = loadedArray[r, c];
                }
            }

            buttonDone_DAV.Enabled = true;
        }

        private void buttonDone_DAV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOutput_DAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_DAV.Enabled = true;
        }

        private void buttonSave_DAV_Click(object sender, EventArgs e)
        {
            saveFileDialog_DAV.FileName = "OutPutFileTask7.csv";
            saveFileDialog_DAV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_DAV.ShowDialog();
            string path = saveFileDialog_DAV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) File.Delete(path);

            int rows = dataGridViewOutput_DAV.RowCount;
            int cols = dataGridViewOutput_DAV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOutput_DAV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_DAV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAbout_DAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
