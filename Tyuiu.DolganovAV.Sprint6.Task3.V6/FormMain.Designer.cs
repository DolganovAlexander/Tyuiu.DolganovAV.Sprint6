namespace Tyuiu.DolganovAV.Sprint6.Task3.V6
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
            groupBoxCondition_DAV = new GroupBox();
            labelCondition_DAV = new Label();
            groupBoxRes_DAV = new GroupBox();
            buttonHelp = new Button();
            buttonDone_DAV = new Button();
            dataGridViewRes_DAV = new DataGridView();
            groupBoxCondition_DAV.SuspendLayout();
            groupBoxRes_DAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_DAV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DAV
            // 
            groupBoxCondition_DAV.Controls.Add(labelCondition_DAV);
            groupBoxCondition_DAV.Location = new Point(12, 12);
            groupBoxCondition_DAV.Name = "groupBoxCondition_DAV";
            groupBoxCondition_DAV.Size = new Size(363, 426);
            groupBoxCondition_DAV.TabIndex = 0;
            groupBoxCondition_DAV.TabStop = false;
            groupBoxCondition_DAV.Text = "Условие";
            // 
            // labelCondition_DAV
            // 
            labelCondition_DAV.AutoSize = true;
            labelCondition_DAV.Location = new Point(6, 23);
            labelCondition_DAV.Name = "labelCondition_DAV";
            labelCondition_DAV.Size = new Size(307, 260);
            labelCondition_DAV.TabIndex = 0;
            labelCondition_DAV.Text = "Дана матрица 5 на 5\r\n\r\n  -2 -10  -8  11   1\r\n\r\n -15  -9  -4 -15  18\r\n\r\n -15  12   7   6   9\r\n\r\n -14 -10  10  18  -5\r\n\r\n  -1   7 -19 -19  -4\r\n\r\nзаменить в 3 строке все четные числа на 0";
            // 
            // groupBoxRes_DAV
            // 
            groupBoxRes_DAV.Controls.Add(buttonHelp);
            groupBoxRes_DAV.Controls.Add(buttonDone_DAV);
            groupBoxRes_DAV.Controls.Add(dataGridViewRes_DAV);
            groupBoxRes_DAV.Location = new Point(381, 12);
            groupBoxRes_DAV.Name = "groupBoxRes_DAV";
            groupBoxRes_DAV.Size = new Size(469, 426);
            groupBoxRes_DAV.TabIndex = 1;
            groupBoxRes_DAV.TabStop = false;
            groupBoxRes_DAV.Text = "Вывод данных:";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(324, 391);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(28, 29);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Location = new Point(358, 391);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(105, 29);
            buttonDone_DAV.TabIndex = 1;
            buttonDone_DAV.Text = "Выполнить";
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // dataGridViewRes_DAV
            // 
            dataGridViewRes_DAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_DAV.ColumnHeadersVisible = false;
            dataGridViewRes_DAV.Location = new Point(6, 26);
            dataGridViewRes_DAV.Name = "dataGridViewRes_DAV";
            dataGridViewRes_DAV.RowHeadersVisible = false;
            dataGridViewRes_DAV.RowHeadersWidth = 51;
            dataGridViewRes_DAV.Size = new Size(334, 304);
            dataGridViewRes_DAV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(groupBoxRes_DAV);
            Controls.Add(groupBoxCondition_DAV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 6 | Долганов А. В.";
            Load += FormMain_Load;
            groupBoxCondition_DAV.ResumeLayout(false);
            groupBoxCondition_DAV.PerformLayout();
            groupBoxRes_DAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_DAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAV;
        private GroupBox groupBoxRes_DAV;
        private Label labelCondition_DAV;
        private DataGridView dataGridViewRes_DAV;
        private Button buttonHelp;
        private Button buttonDone_DAV;
    }
}
