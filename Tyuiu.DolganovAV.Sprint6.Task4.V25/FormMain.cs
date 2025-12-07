using Tyuiu.DolganovAV.Sprint6.Task4.V25.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_DAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 4 выполнил студент группы ПИНб-25-1 Долганов Александр Витальевич", "Сообщение");
        }

        private void buttonDone_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_DAV.Text);
                int end = Convert.ToInt32(textBoxEnd_DAV.Text);
                double[] value = ds.GetMassFunction(start, end);

                this.chartRes_DAV.ChartAreas[0].AxisX.Title = "X";
                this.chartRes_DAV.ChartAreas[0].AxisY.Title = "Y";
                textBoxRes_DAV.Text = "";
                chartRes_DAV.Series[0].Points.Clear();

                for (int i = 0; i < value.Length; i++)
                {
                    this.chartRes_DAV.Series[0].Points.AddXY(start, value[i]);
                    textBoxRes_DAV.AppendText(value[i] + Environment.NewLine);
                    start++;
                }
            }
            catch { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonSave_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"C:\DataSprint6\OutPutFile4V25.txt";
                File.WriteAllText(path, textBoxRes_DAV.Text);
                DialogResult dialogResult = MessageBox.Show(@$"Файл {path} сохранен успешно! Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
