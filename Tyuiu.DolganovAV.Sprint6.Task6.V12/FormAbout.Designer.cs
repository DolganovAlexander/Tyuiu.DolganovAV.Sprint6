namespace Tyuiu.DolganovAV.Sprint6.Task6.V12
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxAvatar_DAV = new PictureBox();
            labelInfo_DAV = new Label();
            buttonDone_DAV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DAV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_DAV
            // 
            pictureBoxAvatar_DAV.Location = new Point(12, 12);
            pictureBoxAvatar_DAV.Name = "pictureBoxAvatar_DAV";
            pictureBoxAvatar_DAV.Size = new Size(166, 256);
            pictureBoxAvatar_DAV.TabIndex = 0;
            pictureBoxAvatar_DAV.TabStop = false;
            // 
            // labelInfo_DAV
            // 
            labelInfo_DAV.AutoSize = true;
            labelInfo_DAV.Location = new Point(184, 12);
            labelInfo_DAV.Name = "labelInfo_DAV";
            labelInfo_DAV.Size = new Size(197, 40);
            labelInfo_DAV.TabIndex = 1;
            labelInfo_DAV.Text = "Разработчик Долганов А.В.\r\nгруппа ПИНб-25-1";
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Location = new Point(445, 239);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(94, 29);
            buttonDone_DAV.TabIndex = 2;
            buttonDone_DAV.Text = "Ok";
            buttonDone_DAV.UseVisualStyleBackColor = true;
            buttonDone_DAV.Click += buttonDone_DAV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 280);
            Controls.Add(buttonDone_DAV);
            Controls.Add(labelInfo_DAV);
            Controls.Add(pictureBoxAvatar_DAV);
            Name = "FormAbout";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_DAV;
        private Label labelInfo_DAV;
        private Button buttonDone_DAV;
    }
}