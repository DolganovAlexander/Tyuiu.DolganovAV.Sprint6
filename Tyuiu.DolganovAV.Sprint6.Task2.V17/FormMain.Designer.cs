namespace Tyuiu.DolganovAV.Sprint6.Task2.V17
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
            groupBoxCond_DAV = new GroupBox();
            labelCond = new Label();
            groupBoxInput_DAV = new GroupBox();
            buttonHelp_DAV = new Button();
            buttonDone_DAV = new Button();
            textBoxEnd_DAV = new TextBox();
            textBoxStart_DAV = new TextBox();
            labelInputE = new Label();
            labelInputS = new Label();
            groupBoxOutput_DAV = new GroupBox();
            dataGridViewRes_DAV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelRes = new Label();
            groupBoxCond_DAV.SuspendLayout();
            groupBoxInput_DAV.SuspendLayout();
            groupBoxOutput_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_DAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCond_DAV
            // 
            groupBoxCond_DAV.Controls.Add(labelCond);
            groupBoxCond_DAV.Location = new Point(12, 12);
            groupBoxCond_DAV.Name = "groupBoxCond_DAV";
            groupBoxCond_DAV.Size = new Size(619, 245);
            groupBoxCond_DAV.TabIndex = 0;
            groupBoxCond_DAV.TabStop = false;
            groupBoxCond_DAV.Text = "Условие:";
            // 
            // labelCond
            // 
            labelCond.AutoSize = true;
            labelCond.Location = new Point(6, 23);
            labelCond.Name = "labelCond";
            labelCond.Size = new Size(453, 40);
            labelCond.TabIndex = 0;
            labelCond.Text = "Протабулиовать функцию на заданном диапазоне. \r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_DAV
            // 
            groupBoxInput_DAV.Controls.Add(buttonHelp_DAV);
            groupBoxInput_DAV.Controls.Add(buttonDone_DAV);
            groupBoxInput_DAV.Controls.Add(textBoxEnd_DAV);
            groupBoxInput_DAV.Controls.Add(textBoxStart_DAV);
            groupBoxInput_DAV.Controls.Add(labelInputE);
            groupBoxInput_DAV.Controls.Add(labelInputS);
            groupBoxInput_DAV.Location = new Point(12, 263);
            groupBoxInput_DAV.Name = "groupBoxInput_DAV";
            groupBoxInput_DAV.Size = new Size(619, 175);
            groupBoxInput_DAV.TabIndex = 1;
            groupBoxInput_DAV.TabStop = false;
            groupBoxInput_DAV.Text = "Ввод данных:";
            // 
            // buttonHelp_DAV
            // 
            buttonHelp_DAV.Location = new Point(344, 53);
            buttonHelp_DAV.Name = "buttonHelp_DAV";
            buttonHelp_DAV.Size = new Size(107, 86);
            buttonHelp_DAV.TabIndex = 5;
            buttonHelp_DAV.Text = "Справка";
            buttonHelp_DAV.UseVisualStyleBackColor = true;
            buttonHelp_DAV.Click += buttonHelp_Click;
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_DAV.Location = new Point(457, 53);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(143, 86);
            buttonDone_DAV.TabIndex = 4;
            buttonDone_DAV.Text = "Выполнить";
            buttonDone_DAV.UseVisualStyleBackColor = false;
            buttonDone_DAV.Click += buttonDone_Click;
            // 
            // textBoxEnd_DAV
            // 
            textBoxEnd_DAV.Location = new Point(149, 83);
            textBoxEnd_DAV.Name = "textBoxEnd_DAV";
            textBoxEnd_DAV.Size = new Size(125, 27);
            textBoxEnd_DAV.TabIndex = 3;
            // 
            // textBoxStart_DAV
            // 
            textBoxStart_DAV.Location = new Point(6, 83);
            textBoxStart_DAV.Name = "textBoxStart_DAV";
            textBoxStart_DAV.Size = new Size(125, 27);
            textBoxStart_DAV.TabIndex = 2;
            // 
            // labelInputE
            // 
            labelInputE.AutoSize = true;
            labelInputE.Location = new Point(149, 60);
            labelInputE.Name = "labelInputE";
            labelInputE.Size = new Size(94, 20);
            labelInputE.TabIndex = 1;
            labelInputE.Text = "Конец шага:";
            // 
            // labelInputS
            // 
            labelInputS.AutoSize = true;
            labelInputS.Location = new Point(6, 60);
            labelInputS.Name = "labelInputS";
            labelInputS.Size = new Size(88, 20);
            labelInputS.TabIndex = 0;
            labelInputS.Text = "Старт шага:";
            // 
            // groupBoxOutput_DAV
            // 
            groupBoxOutput_DAV.Controls.Add(dataGridViewRes_DAV);
            groupBoxOutput_DAV.Controls.Add(labelRes);
            groupBoxOutput_DAV.Location = new Point(637, 12);
            groupBoxOutput_DAV.Name = "groupBoxOutput_DAV";
            groupBoxOutput_DAV.Size = new Size(551, 426);
            groupBoxOutput_DAV.TabIndex = 2;
            groupBoxOutput_DAV.TabStop = false;
            groupBoxOutput_DAV.Text = "Вывод данных:";
            // 
            // dataGridViewRes_DAV
            // 
            dataGridViewRes_DAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_DAV.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewRes_DAV.Location = new Point(6, 46);
            dataGridViewRes_DAV.Name = "dataGridViewRes_DAV";
            dataGridViewRes_DAV.ReadOnly = true;
            dataGridViewRes_DAV.RowHeadersVisible = false;
            dataGridViewRes_DAV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewRes_DAV.Size = new Size(147, 380);
            dataGridViewRes_DAV.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 65;
            // 
            // Y
            // 
            Y.HeaderText = "F(x)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 65;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(6, 23);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(78, 20);
            labelRes.TabIndex = 0;
            labelRes.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 450);
            Controls.Add(groupBoxOutput_DAV);
            Controls.Add(groupBoxInput_DAV);
            Controls.Add(groupBoxCond_DAV);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Долганов А.В.";
            groupBoxCond_DAV.ResumeLayout(false);
            groupBoxCond_DAV.PerformLayout();
            groupBoxInput_DAV.ResumeLayout(false);
            groupBoxInput_DAV.PerformLayout();
            groupBoxOutput_DAV.ResumeLayout(false);
            groupBoxOutput_DAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_DAV;
        private Label labelCond;
        private GroupBox groupBoxInput_DAV;
        private GroupBox groupBoxOutput_DAV;
        private Label labelInputE;
        private Label labelInputS;
        private Label labelRes;
        private TextBox textBoxStart_DAV;
        private TextBox textBoxEnd_DAV;
        private DataGridView dataGridViewRes_DAV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private Button buttonHelp_DAV;
        private Button buttonDone_DAV;
    }
}
