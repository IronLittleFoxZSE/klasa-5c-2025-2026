namespace NotepadWinFormsApp
{
    partial class AboutForm
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
            labelAbout = new Label();
            buttonClose = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Location = new Point(310, 35);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(213, 15);
            labelAbout.TabIndex = 0;
            labelAbout.Text = "To jest program pisany w ramach zajęć.";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonClose.Location = new Point(282, 337);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(265, 81);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Zamknij";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.iron_little_fox_logo;
            pictureBox.Location = new Point(214, 64);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(402, 248);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(buttonClose);
            Controls.Add(labelAbout);
            Name = "AboutForm";
            Text = "O programie";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout;
        private Button buttonClose;
        private PictureBox pictureBox;
    }
}