using Tyuiu.DolganovAV.Sprint6.Task1.V26.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_DAV.Text);
                int end = Convert.ToInt32(textBoxEnd_DAV.Text);
                double[] value = ds.GetMassFunction(start, end);
                textBoxResult_DAV.Text = "";
                textBoxResult_DAV.AppendText("+-------+--------+" + Environment.NewLine);
                textBoxResult_DAV.AppendText("|   F   |   x    |" + Environment.NewLine);
                textBoxResult_DAV.AppendText("+-------+--------+" + Environment.NewLine);
                for (int i = 0; i <= value.Length; i++)
                {
                    textBoxResult_DAV.AppendText(string.Format("|{0,4:d}   | {1,6:f2} |", i+start, value[i]));
                    textBoxResult_DAV.AppendText(Environment.NewLine);
                }
                textBoxResult_DAV.AppendText("+-------+-------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonGetHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 1 выполнил студент группы ПИНб-25-1 Долганов Александр Витальевич", "Сообщение");
        }
    }
}
