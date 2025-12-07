using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.DolganovAV.Sprint6.Task2.V17.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_DAV.Text);
                int end = Convert.ToInt32(textBoxEnd_DAV.Text);
                this.
                double[] value = ds.GetMassFunction(start, end);
                for (int i = 0; i < value.Length; i++)
                {
                    this.dataGridViewRes_DAV.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                    start++;
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 2 выполнил студент группы ПИНб-25-1 Долганов Александр Витальевич", "Сообщение");
        }
    }
}
