namespace FirstWinFormsApp
{
    partial class MainForm
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
            buttonHello = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            SuspendLayout();
            // 
            // buttonHello
            // 
            buttonHello.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHello.ForeColor = SystemColors.ControlText;
            buttonHello.Location = new Point(99, 199);
            buttonHello.Name = "buttonHello";
            buttonHello.Size = new Size(247, 96);
            buttonHello.TabIndex = 0;
            buttonHello.Text = "Hello";
            buttonHello.UseVisualStyleBackColor = true;
            buttonHello.Click += buttonHello_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 47);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(338, 23);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Jan";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(192, 192, 0);
            labelName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.Maroon;
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(159, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Podaj swoje imię:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 354);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonHello);
            Name = "MainForm";
            Text = "Pierwsza aplikacja desktopowa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHello;
        private TextBox textBoxName;
        private Label labelName;
    }
}