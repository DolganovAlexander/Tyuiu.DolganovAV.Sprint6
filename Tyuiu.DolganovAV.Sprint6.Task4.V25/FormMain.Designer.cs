namespace Tyuiu.DolganovAV.Sprint6.Task4.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCond_DAV = new GroupBox();
            groupBoxInput_DAV = new GroupBox();
            groupBoxRes_DAV = new GroupBox();
            textBoxRes_DAV = new TextBox();
            labelCondition_DAV = new Label();
            textBoxStart_DAV = new TextBox();
            textBoxEnd_DAV = new TextBox();
            labelStart_DAV = new Label();
            labelEnd_DAV = new Label();
            buttonHelp_DAV = new Button();
            buttonDone_DAV = new Button();
            buttonSave_DAV = new Button();
            chartRes_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCond_DAV.SuspendLayout();
            groupBoxInput_DAV.SuspendLayout();
            groupBoxRes_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_DAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCond_DAV
            // 
            groupBoxCond_DAV.Controls.Add(labelCondition_DAV);
            groupBoxCond_DAV.Location = new Point(12, 12);
            groupBoxCond_DAV.Name = "groupBoxCond_DAV";
            groupBoxCond_DAV.Size = new Size(544, 107);
            groupBoxCond_DAV.TabIndex = 0;
            groupBoxCond_DAV.TabStop = false;
            groupBoxCond_DAV.Text = "Условие:";
            // 
            // groupBoxInput_DAV
            // 
            groupBoxInput_DAV.Controls.Add(buttonSave_DAV);
            groupBoxInput_DAV.Controls.Add(buttonDone_DAV);
            groupBoxInput_DAV.Controls.Add(buttonHelp_DAV);
            groupBoxInput_DAV.Controls.Add(labelEnd_DAV);
            groupBoxInput_DAV.Controls.Add(labelStart_DAV);
            groupBoxInput_DAV.Controls.Add(textBoxEnd_DAV);
            groupBoxInput_DAV.Controls.Add(textBoxStart_DAV);
            groupBoxInput_DAV.Location = new Point(562, 12);
            groupBoxInput_DAV.Name = "groupBoxInput_DAV";
            groupBoxInput_DAV.Size = new Size(593, 107);
            groupBoxInput_DAV.TabIndex = 1;
            groupBoxInput_DAV.TabStop = false;
            groupBoxInput_DAV.Text = "Ввод данных:";
            // 
            // groupBoxRes_DAV
            // 
            groupBoxRes_DAV.Controls.Add(chartRes_DAV);
            groupBoxRes_DAV.Controls.Add(textBoxRes_DAV);
            groupBoxRes_DAV.Location = new Point(12, 125);
            groupBoxRes_DAV.Name = "groupBoxRes_DAV";
            groupBoxRes_DAV.Size = new Size(1143, 424);
            groupBoxRes_DAV.TabIndex = 2;
            groupBoxRes_DAV.TabStop = false;
            groupBoxRes_DAV.Text = "Вывод данных:";
            // 
            // textBoxRes_DAV
            // 
            textBoxRes_DAV.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_DAV.Location = new Point(6, 26);
            textBoxRes_DAV.Multiline = true;
            textBoxRes_DAV.Name = "textBoxRes_DAV";
            textBoxRes_DAV.ReadOnly = true;
            textBoxRes_DAV.ScrollBars = ScrollBars.Vertical;
            textBoxRes_DAV.Size = new Size(251, 392);
            textBoxRes_DAV.TabIndex = 0;
            // 
            // labelCondition_DAV
            // 
            labelCondition_DAV.AutoSize = true;
            labelCondition_DAV.Location = new Point(6, 23);
            labelCondition_DAV.Name = "labelCondition_DAV";
            labelCondition_DAV.Size = new Size(538, 60);
            labelCondition_DAV.TabIndex = 0;
            labelCondition_DAV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textbox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по нажатию кнопки";
            // 
            // textBoxStart_DAV
            // 
            textBoxStart_DAV.Location = new Point(18, 47);
            textBoxStart_DAV.Name = "textBoxStart_DAV";
            textBoxStart_DAV.Size = new Size(125, 27);
            textBoxStart_DAV.TabIndex = 0;
            // 
            // textBoxEnd_DAV
            // 
            textBoxEnd_DAV.Location = new Point(154, 47);
            textBoxEnd_DAV.Name = "textBoxEnd_DAV";
            textBoxEnd_DAV.Size = new Size(125, 27);
            textBoxEnd_DAV.TabIndex = 1;
            // 
            // labelStart_DAV
            // 
            labelStart_DAV.AutoSize = true;
            labelStart_DAV.Location = new Point(18, 23);
            labelStart_DAV.Name = "labelStart_DAV";
            labelStart_DAV.Size = new Size(88, 20);
            labelStart_DAV.TabIndex = 2;
            labelStart_DAV.Text = "Старт шага:";
            // 
            // labelEnd_DAV
            // 
            labelEnd_DAV.AutoSize = true;
            labelEnd_DAV.Location = new Point(154, 23);
            labelEnd_DAV.Name = "labelEnd_DAV";
            labelEnd_DAV.Size = new Size(94, 20);
            labelEnd_DAV.TabIndex = 3;
            labelEnd_DAV.Text = "Конец шага:";
            // 
            // buttonHelp_DAV
            // 
            buttonHelp_DAV.Location = new Point(540, 45);
            buttonHelp_DAV.Name = "buttonHelp_DAV";
            buttonHelp_DAV.Size = new Size(32, 29);
            buttonHelp_DAV.TabIndex = 1;
            buttonHelp_DAV.Text = "?";
            buttonHelp_DAV.UseVisualStyleBackColor = true;
            buttonHelp_DAV.Click += buttonHelp_DAV_Click;
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Location = new Point(432, 45);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(102, 29);
            buttonDone_DAV.TabIndex = 4;
            buttonDone_DAV.Text = "Выполнить";
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // buttonSave_DAV
            // 
            buttonSave_DAV.Location = new Point(332, 45);
            buttonSave_DAV.Name = "buttonSave_DAV";
            buttonSave_DAV.Size = new Size(94, 29);
            buttonSave_DAV.TabIndex = 5;
            buttonSave_DAV.Text = "Сохранить";
            buttonSave_DAV.UseVisualStyleBackColor = true;
            buttonSave_DAV.Click += buttonSave_DAV_Click;
            // 
            // chartRes_DAV
            // 
            chartArea4.Name = "ChartArea1";
            chartRes_DAV.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            chartRes_DAV.Legends.Add(legend4);
            chartRes_DAV.Location = new Point(281, 26);
            chartRes_DAV.Name = "chartRes_DAV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartRes_DAV.Series.Add(series4);
            chartRes_DAV.Size = new Size(841, 380);
            chartRes_DAV.TabIndex = 1;
            chartRes_DAV.Text = "chart1";
            title4.Name = "NameFormula";
            title4.Text = "График функции cos(x) + 4x/2 - sin(x) * 3x";
            chartRes_DAV.Titles.Add(title4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 561);
            Controls.Add(groupBoxRes_DAV);
            Controls.Add(groupBoxInput_DAV);
            Controls.Add(groupBoxCond_DAV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 25 | Долганов А.В.";
            groupBoxCond_DAV.ResumeLayout(false);
            groupBoxCond_DAV.PerformLayout();
            groupBoxInput_DAV.ResumeLayout(false);
            groupBoxInput_DAV.PerformLayout();
            groupBoxRes_DAV.ResumeLayout(false);
            groupBoxRes_DAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_DAV;
        private GroupBox groupBoxInput_DAV;
        private GroupBox groupBoxRes_DAV;
        private TextBox textBoxRes_DAV;
        private Label labelCondition_DAV;
        private Label labelEnd_DAV;
        private Label labelStart_DAV;
        private TextBox textBoxEnd_DAV;
        private TextBox textBoxStart_DAV;
        private Button buttonSave_DAV;
        private Button buttonDone_DAV;
        private Button buttonHelp_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_DAV;
    }
}
