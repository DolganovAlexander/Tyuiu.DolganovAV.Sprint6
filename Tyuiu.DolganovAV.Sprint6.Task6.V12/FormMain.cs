using Tyuiu.DolganovAV.Sprint6.Task6.V12.Lib;
namespace Tyuiu.DolganovAV.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonSelectFile_DAV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DAV.ShowDialog();
            openFilePath = openFileDialogTask_DAV.FileName;
            textBoxInput_DAV.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_DAV.Text = groupBoxOutput_DAV.Text + " " + openFileDialogTask_DAV.FileName;
            buttonDone_DAV.Enabled = true;
        }

        private void buttonDone_DAV_Click(object sender, EventArgs e)
        {
            if (textBoxOutput_DAV.Text != null)
            {
                textBoxOutput_DAV.Clear();
            }
            textBoxOutput_DAV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_DAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
