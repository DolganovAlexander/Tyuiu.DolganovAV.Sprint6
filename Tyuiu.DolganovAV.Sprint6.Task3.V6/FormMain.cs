using Tyuiu.DolganovAV.Sprint6.Task3.V6.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[,]     {{ -2, -10, -8, 11, 1 },
                                        { -15, -9, -4, -15, 18 },
                                        { -15, 12, 7, 6, 9 },
                                        { -14, -10, 10, 18, -5 },
                                        { -1, 7, -19, -19, -4 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            dataGridViewRes_DAV.ColumnCount = cols;
            dataGridViewRes_DAV.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewRes_DAV.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewRes_DAV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_DAV_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int cols = res.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewRes_DAV.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 3 выполнил студент группы ПИНб-25-1 Долганов Александр Витальевич", "Сообщение");
        }
    }
}
