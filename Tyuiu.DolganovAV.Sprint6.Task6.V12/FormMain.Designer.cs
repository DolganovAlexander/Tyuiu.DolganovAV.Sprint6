namespace Tyuiu.DolganovAV.Sprint6.Task6.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCond_DAV = new GroupBox();
            labelCond_DAV = new Label();
            groupBoxInput_DAV = new GroupBox();
            textBoxInput_DAV = new TextBox();
            groupBoxOutput_DAV = new GroupBox();
            textBoxOutput_DAV = new TextBox();
            buttonSelectFile_DAV = new Button();
            buttonDone_DAV = new Button();
            buttonAbout_DAV = new Button();
            openFileDialogTask_DAV = new OpenFileDialog();
            toolTipHelp_DAV = new ToolTip(components);
            labelCondition_DAV = new Label();
            groupBoxCond_DAV.SuspendLayout();
            groupBoxInput_DAV.SuspendLayout();
            groupBoxOutput_DAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCond_DAV
            // 
            groupBoxCond_DAV.Controls.Add(labelCondition_DAV);
            groupBoxCond_DAV.Controls.Add(labelCond_DAV);
            groupBoxCond_DAV.Location = new Point(12, 91);
            groupBoxCond_DAV.Name = "groupBoxCond_DAV";
            groupBoxCond_DAV.Size = new Size(1014, 105);
            groupBoxCond_DAV.TabIndex = 0;
            groupBoxCond_DAV.TabStop = false;
            groupBoxCond_DAV.Text = "Условие";
            // 
            // labelCond_DAV
            // 
            labelCond_DAV.AutoEllipsis = true;
            labelCond_DAV.AutoSize = true;
            labelCond_DAV.Location = new Point(6, 23);
            labelCond_DAV.Name = "labelCond_DAV";
            labelCond_DAV.Size = new Size(0, 20);
            labelCond_DAV.TabIndex = 0;
            // 
            // groupBoxInput_DAV
            // 
            groupBoxInput_DAV.Controls.Add(textBoxInput_DAV);
            groupBoxInput_DAV.Location = new Point(12, 202);
            groupBoxInput_DAV.Name = "groupBoxInput_DAV";
            groupBoxInput_DAV.Size = new Size(519, 368);
            groupBoxInput_DAV.TabIndex = 1;
            groupBoxInput_DAV.TabStop = false;
            groupBoxInput_DAV.Text = "Ввод";
            // 
            // textBoxInput_DAV
            // 
            textBoxInput_DAV.Location = new Point(6, 26);
            textBoxInput_DAV.Multiline = true;
            textBoxInput_DAV.Name = "textBoxInput_DAV";
            textBoxInput_DAV.ReadOnly = true;
            textBoxInput_DAV.ScrollBars = ScrollBars.Vertical;
            textBoxInput_DAV.Size = new Size(507, 336);
            textBoxInput_DAV.TabIndex = 0;
            // 
            // groupBoxOutput_DAV
            // 
            groupBoxOutput_DAV.Controls.Add(textBoxOutput_DAV);
            groupBoxOutput_DAV.Location = new Point(537, 202);
            groupBoxOutput_DAV.Name = "groupBoxOutput_DAV";
            groupBoxOutput_DAV.Size = new Size(489, 368);
            groupBoxOutput_DAV.TabIndex = 2;
            groupBoxOutput_DAV.TabStop = false;
            groupBoxOutput_DAV.Text = "Вывод";
            // 
            // textBoxOutput_DAV
            // 
            textBoxOutput_DAV.Location = new Point(6, 26);
            textBoxOutput_DAV.Multiline = true;
            textBoxOutput_DAV.Name = "textBoxOutput_DAV";
            textBoxOutput_DAV.ReadOnly = true;
            textBoxOutput_DAV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_DAV.Size = new Size(477, 336);
            textBoxOutput_DAV.TabIndex = 0;
            // 
            // buttonSelectFile_DAV
            // 
            buttonSelectFile_DAV.Location = new Point(18, 13);
            buttonSelectFile_DAV.Name = "buttonSelectFile_DAV";
            buttonSelectFile_DAV.Size = new Size(84, 72);
            buttonSelectFile_DAV.TabIndex = 3;
            buttonSelectFile_DAV.Text = "Выбрать файл";
            toolTipHelp_DAV.SetToolTip(buttonSelectFile_DAV, "Открыть файл\r\nВыберите нужный файл\r\n");
            buttonSelectFile_DAV.UseVisualStyleBackColor = true;
            buttonSelectFile_DAV.Click += buttonSelectFile_DAV_Click;
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Location = new Point(108, 13);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(101, 72);
            buttonDone_DAV.TabIndex = 4;
            buttonDone_DAV.Text = "Выполнить";
            toolTipHelp_DAV.SetToolTip(buttonDone_DAV, "Производит выполнение программы");
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // buttonAbout_DAV
            // 
            buttonAbout_DAV.Location = new Point(932, 13);
            buttonAbout_DAV.Name = "buttonAbout_DAV";
            buttonAbout_DAV.Size = new Size(88, 72);
            buttonAbout_DAV.TabIndex = 5;
            buttonAbout_DAV.Text = "?";
            toolTipHelp_DAV.SetToolTip(buttonAbout_DAV, "Сведения о программе");
            buttonAbout_DAV.UseVisualStyleBackColor = true;
            buttonAbout_DAV.Click += buttonAbout_DAV_Click;
            // 
            // openFileDialogTask_DAV
            // 
            openFileDialogTask_DAV.FileName = "openFileDialog1";
            // 
            // toolTipHelp_DAV
            // 
            toolTipHelp_DAV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // labelCondition_DAV
            // 
            labelCondition_DAV.AutoSize = true;
            labelCondition_DAV.Location = new Point(12, 23);
            labelCondition_DAV.Name = "labelCondition_DAV";
            labelCondition_DAV.Size = new Size(925, 40);
            labelCondition_DAV.TabIndex = 1;
            labelCondition_DAV.Text = resources.GetString("labelCondition_DAV.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 582);
            Controls.Add(buttonAbout_DAV);
            Controls.Add(buttonDone_DAV);
            Controls.Add(buttonSelectFile_DAV);
            Controls.Add(groupBoxOutput_DAV);
            Controls.Add(groupBoxInput_DAV);
            Controls.Add(groupBoxCond_DAV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 12 | Долганов А.В.";
            groupBoxCond_DAV.ResumeLayout(false);
            groupBoxCond_DAV.PerformLayout();
            groupBoxInput_DAV.ResumeLayout(false);
            groupBoxInput_DAV.PerformLayout();
            groupBoxOutput_DAV.ResumeLayout(false);
            groupBoxOutput_DAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_DAV;
        private Label labelCond_DAV;
        private GroupBox groupBoxInput_DAV;
        private GroupBox groupBoxOutput_DAV;
        private TextBox textBoxInput_DAV;
        private TextBox textBoxOutput_DAV;
        private Button buttonSelectFile_DAV;
        private Button buttonDone_DAV;
        private Button buttonAbout_DAV;
        private OpenFileDialog openFileDialogTask_DAV;
        private ToolTip toolTipHelp_DAV;
        private Label labelCondition_DAV;
    }
}
