namespace WFL3
{
    partial class Form1
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
            btnSelectFile = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            label1 = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 56);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(99, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Выбрать файл";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 27);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(268, 23);
            progressBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(12, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Статус";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 60);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 3;
            label1.Text = "Поддерживается только  .txt";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 85);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(99, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выйти ";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(308, 123);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Прогресс чтения из файла";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private ProgressBar progressBar;
        private Label lblStatus;
        private Label label1;
        private Button exitButton;
    }
}