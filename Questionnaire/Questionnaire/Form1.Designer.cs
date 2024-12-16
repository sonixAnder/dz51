namespace Questionnaire
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
            txtFirstName = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExportTxt = new Button();
            btnImportTxt = new Button();
            btnExportXml = new Button();
            btnImportXml = new Button();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstUsers = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 37);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(99, 21);
            txtFirstName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(6, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(120, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExportTxt
            // 
            btnExportTxt.ForeColor = Color.Black;
            btnExportTxt.Location = new Point(6, 187);
            btnExportTxt.Name = "btnExportTxt";
            btnExportTxt.Size = new Size(99, 23);
            btnExportTxt.TabIndex = 3;
            btnExportTxt.Text = "Экспорт в .txt";
            btnExportTxt.UseVisualStyleBackColor = true;
            // 
            // btnImportTxt
            // 
            btnImportTxt.ForeColor = Color.Black;
            btnImportTxt.Location = new Point(120, 187);
            btnImportTxt.Name = "btnImportTxt";
            btnImportTxt.Size = new Size(99, 23);
            btnImportTxt.TabIndex = 4;
            btnImportTxt.Text = "Импорт в .txt";
            btnImportTxt.UseVisualStyleBackColor = true;
            // 
            // btnExportXml
            // 
            btnExportXml.ForeColor = Color.Black;
            btnExportXml.Location = new Point(6, 216);
            btnExportXml.Name = "btnExportXml";
            btnExportXml.Size = new Size(99, 23);
            btnExportXml.TabIndex = 5;
            btnExportXml.Text = "Экспорт в .xml";
            btnExportXml.UseVisualStyleBackColor = true;
            // 
            // btnImportXml
            // 
            btnImportXml.ForeColor = Color.Black;
            btnImportXml.Location = new Point(120, 216);
            btnImportXml.Name = "btnImportXml";
            btnImportXml.Size = new Size(99, 23);
            btnImportXml.TabIndex = 6;
            btnImportXml.Text = "Импорт в .xml";
            btnImportXml.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 37);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(99, 21);
            txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 77);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 21);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(6, 119);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(213, 21);
            txtPhone.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 10;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 19);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 59);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 12;
            label3.Text = "Имейл";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 13;
            label4.Text = "Номер телефона";
            // 
            // lstUsers
            // 
            lstUsers.BackColor = Color.FromArgb(64, 64, 64);
            lstUsers.BorderStyle = BorderStyle.None;
            lstUsers.ForeColor = Color.White;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(6, 19);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(508, 210);
            lstUsers.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnExportTxt);
            groupBox1.Controls.Add(btnImportTxt);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(btnExportXml);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnImportXml);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 246);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstUsers);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(249, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 246);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пользователи";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(783, 274);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Анкета";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFirstName;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExportTxt;
        private Button btnImportTxt;
        private Button btnExportXml;
        private Button btnImportXml;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstUsers;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}