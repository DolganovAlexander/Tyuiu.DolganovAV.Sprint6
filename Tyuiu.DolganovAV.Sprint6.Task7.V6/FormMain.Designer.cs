namespace Tyuiu.DolganovAV.Sprint6.Task7.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_DAV = new Panel();
            buttonAbout_DAV = new Button();
            buttonSave_DAV = new Button();
            buttonDone_DAV = new Button();
            buttonOpenFile_DAV = new Button();
            panelCond_DAV = new Panel();
            groupBoxCond_DAV = new GroupBox();
            label1 = new Label();
            panel4 = new Panel();
            panelInput_DAV = new Panel();
            groupBoxInput_DAV = new GroupBox();
            dataGridViewInput_DAV = new DataGridView();
            panelOutput_DAV = new Panel();
            groupBoxOutput_DAV = new GroupBox();
            dataGridViewOutput_DAV = new DataGridView();
            openFileDialog_DAV = new OpenFileDialog();
            saveFileDialog_DAV = new SaveFileDialog();
            panelButtons_DAV.SuspendLayout();
            panelCond_DAV.SuspendLayout();
            groupBoxCond_DAV.SuspendLayout();
            panelInput_DAV.SuspendLayout();
            groupBoxInput_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_DAV).BeginInit();
            panelOutput_DAV.SuspendLayout();
            groupBoxOutput_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_DAV).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_DAV
            // 
            panelButtons_DAV.Controls.Add(buttonAbout_DAV);
            panelButtons_DAV.Controls.Add(buttonSave_DAV);
            panelButtons_DAV.Controls.Add(buttonDone_DAV);
            panelButtons_DAV.Controls.Add(buttonOpenFile_DAV);
            panelButtons_DAV.Location = new Point(12, 12);
            panelButtons_DAV.Name = "panelButtons_DAV";
            panelButtons_DAV.Size = new Size(1069, 97);
            panelButtons_DAV.TabIndex = 0;
            // 
            // buttonAbout_DAV
            // 
            buttonAbout_DAV.Image = (Image)resources.GetObject("buttonAbout_DAV.Image");
            buttonAbout_DAV.Location = new Point(966, 8);
            buttonAbout_DAV.Name = "buttonAbout_DAV";
            buttonAbout_DAV.Size = new Size(94, 81);
            buttonAbout_DAV.TabIndex = 4;
            buttonAbout_DAV.UseVisualStyleBackColor = true;
            buttonAbout_DAV.Click += buttonAbout_DAV_Click;
            // 
            // buttonSave_DAV
            // 
            buttonSave_DAV.Enabled = false;
            buttonSave_DAV.Image = (Image)resources.GetObject("buttonSave_DAV.Image");
            buttonSave_DAV.Location = new Point(211, 8);
            buttonSave_DAV.Name = "buttonSave_DAV";
            buttonSave_DAV.Size = new Size(94, 81);
            buttonSave_DAV.TabIndex = 3;
            buttonSave_DAV.UseVisualStyleBackColor = true;
            buttonSave_DAV.Click += buttonSave_DAV_Click;
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Enabled = false;
            buttonDone_DAV.Image = (Image)resources.GetObject("buttonDone_DAV.Image");
            buttonDone_DAV.Location = new Point(111, 8);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(94, 81);
            buttonDone_DAV.TabIndex = 2;
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // buttonOpenFile_DAV
            // 
            buttonOpenFile_DAV.Image = (Image)resources.GetObject("buttonOpenFile_DAV.Image");
            buttonOpenFile_DAV.Location = new Point(15, 8);
            buttonOpenFile_DAV.Name = "buttonOpenFile_DAV";
            buttonOpenFile_DAV.Size = new Size(90, 81);
            buttonOpenFile_DAV.TabIndex = 1;
            buttonOpenFile_DAV.UseVisualStyleBackColor = true;
            buttonOpenFile_DAV.Click += buttonOpenFile_DAV_Click;
            // 
            // panelCond_DAV
            // 
            panelCond_DAV.Controls.Add(groupBoxCond_DAV);
            panelCond_DAV.Controls.Add(panel4);
            panelCond_DAV.Location = new Point(12, 115);
            panelCond_DAV.Name = "panelCond_DAV";
            panelCond_DAV.Size = new Size(1069, 85);
            panelCond_DAV.TabIndex = 1;
            // 
            // groupBoxCond_DAV
            // 
            groupBoxCond_DAV.Controls.Add(label1);
            groupBoxCond_DAV.Location = new Point(3, 3);
            groupBoxCond_DAV.Name = "groupBoxCond_DAV";
            groupBoxCond_DAV.Size = new Size(1063, 79);
            groupBoxCond_DAV.TabIndex = 4;
            groupBoxCond_DAV.TabStop = false;
            groupBoxCond_DAV.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(1039, 60);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // panel4
            // 
            panel4.Location = new Point(546, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 263);
            panel4.TabIndex = 3;
            // 
            // panelInput_DAV
            // 
            panelInput_DAV.Anchor = AnchorStyles.Left;
            panelInput_DAV.Controls.Add(groupBoxInput_DAV);
            panelInput_DAV.Location = new Point(12, 206);
            panelInput_DAV.Name = "panelInput_DAV";
            panelInput_DAV.Size = new Size(540, 263);
            panelInput_DAV.TabIndex = 2;
            // 
            // groupBoxInput_DAV
            // 
            groupBoxInput_DAV.Controls.Add(dataGridViewInput_DAV);
            groupBoxInput_DAV.Location = new Point(9, 3);
            groupBoxInput_DAV.Name = "groupBoxInput_DAV";
            groupBoxInput_DAV.Size = new Size(515, 257);
            groupBoxInput_DAV.TabIndex = 0;
            groupBoxInput_DAV.TabStop = false;
            groupBoxInput_DAV.Text = "Ввод";
            // 
            // dataGridViewInput_DAV
            // 
            dataGridViewInput_DAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_DAV.ColumnHeadersVisible = false;
            dataGridViewInput_DAV.Location = new Point(6, 26);
            dataGridViewInput_DAV.Name = "dataGridViewInput_DAV";
            dataGridViewInput_DAV.RowHeadersVisible = false;
            dataGridViewInput_DAV.RowHeadersWidth = 51;
            dataGridViewInput_DAV.Size = new Size(503, 225);
            dataGridViewInput_DAV.TabIndex = 4;
            // 
            // panelOutput_DAV
            // 
            panelOutput_DAV.Anchor = AnchorStyles.Right;
            panelOutput_DAV.Controls.Add(groupBoxOutput_DAV);
            panelOutput_DAV.Location = new Point(542, 206);
            panelOutput_DAV.Name = "panelOutput_DAV";
            panelOutput_DAV.Size = new Size(539, 260);
            panelOutput_DAV.TabIndex = 3;
            // 
            // groupBoxOutput_DAV
            // 
            groupBoxOutput_DAV.Controls.Add(dataGridViewOutput_DAV);
            groupBoxOutput_DAV.Location = new Point(3, 3);
            groupBoxOutput_DAV.Name = "groupBoxOutput_DAV";
            groupBoxOutput_DAV.Size = new Size(533, 254);
            groupBoxOutput_DAV.TabIndex = 0;
            groupBoxOutput_DAV.TabStop = false;
            groupBoxOutput_DAV.Text = "Вывод";
            // 
            // dataGridViewOutput_DAV
            // 
            dataGridViewOutput_DAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_DAV.ColumnHeadersVisible = false;
            dataGridViewOutput_DAV.Location = new Point(13, 26);
            dataGridViewOutput_DAV.Name = "dataGridViewOutput_DAV";
            dataGridViewOutput_DAV.RowHeadersVisible = false;
            dataGridViewOutput_DAV.RowHeadersWidth = 51;
            dataGridViewOutput_DAV.Size = new Size(514, 231);
            dataGridViewOutput_DAV.TabIndex = 0;
            // 
            // openFileDialog_DAV
            // 
            openFileDialog_DAV.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 481);
            Controls.Add(panelOutput_DAV);
            Controls.Add(panelInput_DAV);
            Controls.Add(panelCond_DAV);
            Controls.Add(panelButtons_DAV);
            Name = "FormMain";
            Text = "Form1";
            panelButtons_DAV.ResumeLayout(false);
            panelCond_DAV.ResumeLayout(false);
            groupBoxCond_DAV.ResumeLayout(false);
            groupBoxCond_DAV.PerformLayout();
            panelInput_DAV.ResumeLayout(false);
            groupBoxInput_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_DAV).EndInit();
            panelOutput_DAV.ResumeLayout(false);
            groupBoxOutput_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_DAV;
        private Panel panelCond_DAV;
        private Panel panel4;
        private Panel panelInput_DAV;
        private Panel panelOutput_DAV;
        private GroupBox groupBoxCond_DAV;
        private Label label1;
        private GroupBox groupBoxInput_DAV;
        private GroupBox groupBoxOutput_DAV;
        private DataGridView dataGridViewInput_DAV;
        private DataGridView dataGridViewOutput_DAV;
        private Button buttonDone_DAV;
        private Button buttonOpenFile_DAV;
        private Button buttonAbout_DAV;
        private Button buttonSave_DAV;
        private OpenFileDialog openFileDialog_DAV;
        private SaveFileDialog saveFileDialog_DAV;
    }
}
