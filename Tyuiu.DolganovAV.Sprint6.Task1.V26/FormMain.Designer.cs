namespace Tyuiu.DolganovAV.Sprint6.Task1.V26
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
            groupBoxInput_DAV = new GroupBox();
            GetHelp = new Button();
            buttonGetResult = new Button();
            labelEnd_DAV = new Label();
            labelStart_DAV = new Label();
            textBoxEnd_DAV = new TextBox();
            textBoxStart_DAV = new TextBox();
            groupBoxResult_DAV = new GroupBox();
            labelResult_DAV = new Label();
            textBoxResult_DAV = new TextBox();
            groupBoxCondition_DAV.SuspendLayout();
            groupBoxInput_DAV.SuspendLayout();
            groupBoxResult_DAV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DAV
            // 
            groupBoxCondition_DAV.Controls.Add(labelCondition_DAV);
            groupBoxCondition_DAV.Location = new Point(12, 12);
            groupBoxCondition_DAV.Name = "groupBoxCondition_DAV";
            groupBoxCondition_DAV.Size = new Size(494, 292);
            groupBoxCondition_DAV.TabIndex = 0;
            groupBoxCondition_DAV.TabStop = false;
            groupBoxCondition_DAV.Text = "Условие";
            // 
            // labelCondition_DAV
            // 
            labelCondition_DAV.AutoSize = true;
            labelCondition_DAV.Location = new Point(18, 32);
            labelCondition_DAV.Name = "labelCondition_DAV";
            labelCondition_DAV.Size = new Size(433, 40);
            labelCondition_DAV.TabIndex = 0;
            labelCondition_DAV.Text = "Протабулировать данную функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxInput_DAV
            // 
            groupBoxInput_DAV.Controls.Add(GetHelp);
            groupBoxInput_DAV.Controls.Add(buttonGetResult);
            groupBoxInput_DAV.Controls.Add(labelEnd_DAV);
            groupBoxInput_DAV.Controls.Add(labelStart_DAV);
            groupBoxInput_DAV.Controls.Add(textBoxEnd_DAV);
            groupBoxInput_DAV.Controls.Add(textBoxStart_DAV);
            groupBoxInput_DAV.Location = new Point(12, 310);
            groupBoxInput_DAV.Name = "groupBoxInput_DAV";
            groupBoxInput_DAV.Size = new Size(494, 128);
            groupBoxInput_DAV.TabIndex = 1;
            groupBoxInput_DAV.TabStop = false;
            groupBoxInput_DAV.Text = "Ввод данных";
            // 
            // GetHelp
            // 
            GetHelp.Location = new Point(294, 60);
            GetHelp.Name = "GetHelp";
            GetHelp.Size = new Size(94, 29);
            GetHelp.TabIndex = 5;
            GetHelp.Text = "справка";
            GetHelp.UseVisualStyleBackColor = true;
            GetHelp.Click += buttonGetHelp_Click;
            // 
            // buttonGetResult
            // 
            buttonGetResult.BackColor = SystemColors.AppWorkspace;
            buttonGetResult.Location = new Point(394, 49);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(94, 50);
            buttonGetResult.TabIndex = 4;
            buttonGetResult.Text = "выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // labelEnd_DAV
            // 
            labelEnd_DAV.AutoSize = true;
            labelEnd_DAV.Location = new Point(158, 49);
            labelEnd_DAV.Name = "labelEnd_DAV";
            labelEnd_DAV.Size = new Size(94, 20);
            labelEnd_DAV.TabIndex = 3;
            labelEnd_DAV.Text = "Конец шага:";
            // 
            // labelStart_DAV
            // 
            labelStart_DAV.AutoSize = true;
            labelStart_DAV.Location = new Point(18, 49);
            labelStart_DAV.Name = "labelStart_DAV";
            labelStart_DAV.Size = new Size(88, 20);
            labelStart_DAV.TabIndex = 2;
            labelStart_DAV.Text = "Старт шага:";
            // 
            // textBoxEnd_DAV
            // 
            textBoxEnd_DAV.Location = new Point(158, 72);
            textBoxEnd_DAV.Name = "textBoxEnd_DAV";
            textBoxEnd_DAV.Size = new Size(125, 27);
            textBoxEnd_DAV.TabIndex = 1;
            // 
            // textBoxStart_DAV
            // 
            textBoxStart_DAV.Location = new Point(18, 72);
            textBoxStart_DAV.Name = "textBoxStart_DAV";
            textBoxStart_DAV.Size = new Size(125, 27);
            textBoxStart_DAV.TabIndex = 0;
            // 
            // groupBoxResult_DAV
            // 
            groupBoxResult_DAV.Controls.Add(labelResult_DAV);
            groupBoxResult_DAV.Controls.Add(textBoxResult_DAV);
            groupBoxResult_DAV.Location = new Point(512, 12);
            groupBoxResult_DAV.Name = "groupBoxResult_DAV";
            groupBoxResult_DAV.Size = new Size(276, 426);
            groupBoxResult_DAV.TabIndex = 2;
            groupBoxResult_DAV.TabStop = false;
            groupBoxResult_DAV.Text = "Вывод данных";
            // 
            // labelResult_DAV
            // 
            labelResult_DAV.AutoSize = true;
            labelResult_DAV.Location = new Point(6, 23);
            labelResult_DAV.Name = "labelResult_DAV";
            labelResult_DAV.Size = new Size(78, 20);
            labelResult_DAV.TabIndex = 1;
            labelResult_DAV.Text = "Результат:";
            // 
            // textBoxResult_DAV
            // 
            textBoxResult_DAV.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_DAV.Location = new Point(6, 49);
            textBoxResult_DAV.Multiline = true;
            textBoxResult_DAV.Name = "textBoxResult_DAV";
            textBoxResult_DAV.ReadOnly = true;
            textBoxResult_DAV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAV.Size = new Size(264, 371);
            textBoxResult_DAV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_DAV);
            Controls.Add(groupBoxInput_DAV);
            Controls.Add(groupBoxCondition_DAV);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Долганов А. В.";
            groupBoxCondition_DAV.ResumeLayout(false);
            groupBoxCondition_DAV.PerformLayout();
            groupBoxInput_DAV.ResumeLayout(false);
            groupBoxInput_DAV.PerformLayout();
            groupBoxResult_DAV.ResumeLayout(false);
            groupBoxResult_DAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAV;
        private Label labelCondition_DAV;
        private GroupBox groupBoxInput_DAV;
        private GroupBox groupBoxResult_DAV;
        private Label labelEnd_DAV;
        private Label labelStart_DAV;
        private TextBox textBoxEnd_DAV;
        private TextBox textBoxStart_DAV;
        private Label labelResult_DAV;
        private TextBox textBoxResult_DAV;
        private Button buttonGetResult;
        private Button GetHelp;
    }
}
