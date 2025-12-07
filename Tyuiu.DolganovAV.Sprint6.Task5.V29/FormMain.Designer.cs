namespace Tyuiu.DolganovAV.Sprint6.Task5.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCond_DAV = new GroupBox();
            buttonHelp_DAV = new Button();
            buttonOpenFile_DAV = new Button();
            buttonDone_DAV = new Button();
            labelCond_DAV = new Label();
            groupBoxRes_DAV = new GroupBox();
            chartRes_DAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewRes_DAV = new DataGridView();
            groupBoxCond_DAV.SuspendLayout();
            groupBoxRes_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_DAV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_DAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCond_DAV
            // 
            groupBoxCond_DAV.Controls.Add(buttonHelp_DAV);
            groupBoxCond_DAV.Controls.Add(buttonOpenFile_DAV);
            groupBoxCond_DAV.Controls.Add(buttonDone_DAV);
            groupBoxCond_DAV.Controls.Add(labelCond_DAV);
            groupBoxCond_DAV.Location = new Point(12, 12);
            groupBoxCond_DAV.Name = "groupBoxCond_DAV";
            groupBoxCond_DAV.Size = new Size(1065, 124);
            groupBoxCond_DAV.TabIndex = 0;
            groupBoxCond_DAV.TabStop = false;
            groupBoxCond_DAV.Text = "Условие";
            // 
            // buttonHelp_DAV
            // 
            buttonHelp_DAV.Location = new Point(792, 40);
            buttonHelp_DAV.Name = "buttonHelp_DAV";
            buttonHelp_DAV.Size = new Size(46, 49);
            buttonHelp_DAV.TabIndex = 3;
            buttonHelp_DAV.Text = "?";
            buttonHelp_DAV.UseVisualStyleBackColor = true;
            buttonHelp_DAV.Click += buttonHelp_DAV_Click;
            // 
            // buttonOpenFile_DAV
            // 
            buttonOpenFile_DAV.Location = new Point(844, 40);
            buttonOpenFile_DAV.Name = "buttonOpenFile_DAV";
            buttonOpenFile_DAV.Size = new Size(94, 49);
            buttonOpenFile_DAV.TabIndex = 2;
            buttonOpenFile_DAV.Text = "Открыть файл";
            buttonOpenFile_DAV.UseVisualStyleBackColor = true;
            buttonOpenFile_DAV.Click += buttonOpenFile_DAV_Click;
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Location = new Point(944, 40);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(102, 49);
            buttonDone_DAV.TabIndex = 1;
            buttonDone_DAV.Text = "Выполнить";
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // labelCond_DAV
            // 
            labelCond_DAV.AutoSize = true;
            labelCond_DAV.Location = new Point(6, 23);
            labelCond_DAV.Name = "labelCond_DAV";
            labelCond_DAV.Size = new Size(379, 60);
            labelCond_DAV.TabIndex = 0;
            labelCond_DAV.Text = "Прочитать данные из файла InPutDataFileTask5V29.txt\r\nВывести в dataGridView положительные значения \r\nи построить диаграмму по этим значениям.\r\n";
            // 
            // groupBoxRes_DAV
            // 
            groupBoxRes_DAV.Controls.Add(chartRes_DAV);
            groupBoxRes_DAV.Controls.Add(dataGridViewRes_DAV);
            groupBoxRes_DAV.Location = new Point(12, 142);
            groupBoxRes_DAV.Name = "groupBoxRes_DAV";
            groupBoxRes_DAV.Size = new Size(1065, 448);
            groupBoxRes_DAV.TabIndex = 1;
            groupBoxRes_DAV.TabStop = false;
            groupBoxRes_DAV.Text = "Вывод данных:";
            // 
            // chartRes_DAV
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_DAV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartRes_DAV.Legends.Add(legend1);
            chartRes_DAV.Location = new Point(231, 26);
            chartRes_DAV.Name = "chartRes_DAV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_DAV.Series.Add(series1);
            chartRes_DAV.Size = new Size(828, 416);
            chartRes_DAV.TabIndex = 1;
            chartRes_DAV.Text = "chart1";
            // 
            // dataGridViewRes_DAV
            // 
            dataGridViewRes_DAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_DAV.ColumnHeadersVisible = false;
            dataGridViewRes_DAV.Location = new Point(6, 26);
            dataGridViewRes_DAV.Name = "dataGridViewRes_DAV";
            dataGridViewRes_DAV.RowHeadersVisible = false;
            dataGridViewRes_DAV.RowHeadersWidth = 51;
            dataGridViewRes_DAV.Size = new Size(219, 416);
            dataGridViewRes_DAV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 602);
            Controls.Add(groupBoxRes_DAV);
            Controls.Add(groupBoxCond_DAV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 29 | Долгаанов А.В";
            groupBoxCond_DAV.ResumeLayout(false);
            groupBoxCond_DAV.PerformLayout();
            groupBoxRes_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRes_DAV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_DAV;
        private GroupBox groupBoxRes_DAV;
        private Label labelCond_DAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_DAV;
        private DataGridView dataGridViewRes_DAV;
        private Button buttonHelp_DAV;
        private Button buttonOpenFile_DAV;
        private Button buttonDone_DAV;
    }
}
