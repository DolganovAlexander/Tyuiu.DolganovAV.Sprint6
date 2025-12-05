namespace Tyuiu.DolganovAV.Sprint6.Task0.V7
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
            textBoxResult = new TextBox();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxInput = new GroupBox();
            textBoxVarX = new TextBox();
            labelX = new Label();
            groupBoxOutput = new GroupBox();
            label1 = new Label();
            pictureBoxFormula = new PictureBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxCondition.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 81);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(242, 27);
            textBoxResult.TabIndex = 2;
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(449, 217);
            groupBoxCondition.TabIndex = 3;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            groupBoxCondition.Enter += groupBox1_Enter;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(6, 23);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(257, 20);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Вычислить выражение по формуле";
            labelCondition.Click += labelCondition_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxVarX);
            groupBoxInput.Controls.Add(labelX);
            groupBoxInput.Location = new Point(12, 235);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(449, 148);
            groupBoxInput.TabIndex = 4;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(22, 77);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(125, 27);
            textBoxVarX.TabIndex = 3;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(22, 54);
            labelX.Name = "labelX";
            labelX.Size = new Size(114, 20);
            labelX.TabIndex = 2;
            labelX.Text = "Переменная X:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(label1);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Location = new Point(467, 235);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(254, 148);
            groupBoxOutput.TabIndex = 5;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Результат:";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(473, 22);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(136, 72);
            pictureBoxFormula.TabIndex = 6;
            pictureBoxFormula.TabStop = false;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(574, 400);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(115, 29);
            buttonDone.TabIndex = 7;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(538, 400);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(30, 29);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(pictureBoxFormula);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 7 | Долганов А. В.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxResult;
        private GroupBox groupBoxCondition;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private PictureBox pictureBoxFormula;
        private Label labelCondition;
        private Label labelX;
        private Label label1;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBoxVarX;
    }
}
