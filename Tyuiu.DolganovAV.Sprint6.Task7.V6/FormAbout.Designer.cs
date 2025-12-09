namespace Tyuiu.DolganovAV.Sprint6.Task7.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            labelInfo_DAV = new Label();
            buttonDone_DAV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 274);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelInfo_DAV
            // 
            labelInfo_DAV.AutoSize = true;
            labelInfo_DAV.Location = new Point(242, 12);
            labelInfo_DAV.Name = "labelInfo_DAV";
            labelInfo_DAV.Size = new Size(197, 40);
            labelInfo_DAV.TabIndex = 2;
            labelInfo_DAV.Text = "Разработчик Долганов А.В.\r\nгруппа ПИНб-25-1";
            // 
            // buttonDone_DAV
            // 
            buttonDone_DAV.Location = new Point(601, 257);
            buttonDone_DAV.Name = "buttonDone_DAV";
            buttonDone_DAV.Size = new Size(94, 29);
            buttonDone_DAV.TabIndex = 3;
            buttonDone_DAV.Text = "OK";
            buttonDone_DAV.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 298);
            Controls.Add(buttonDone_DAV);
            Controls.Add(labelInfo_DAV);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelInfo_DAV;
        private Button buttonDone_DAV;
    }
}