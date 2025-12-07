using Tyuiu.DolganovAV.Sprint6.Task5.V29.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V29.txt";
        private void buttonDone_DAV_Click(object sender, EventArgs e)
        {
            dataGridViewRes_DAV.ColumnCount = 2;
            dataGridViewRes_DAV.Columns[0].Width = 20;
            dataGridViewRes_DAV.Columns[1].Width = 50;

            this.chartRes_DAV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_DAV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_DAV.Series[0].Points.Clear();

            double[] numsArray = new double[ds.len];

            numsArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsArray.Length; i++)
            {
                dataGridViewRes_DAV.Rows.Add(Convert.ToString(i), Convert.ToString(numsArray[i]));
                chartRes_DAV.Series[0].Points.AddXY(i, numsArray[i]);
            }
        }

        private void buttonOpenFile_DAV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_DAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 5 выполнил студент группы ПИНб-25-1 Долганов Александр Витальевич", "Сообщение");
        }
    }
}
