using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.ApplicationServices;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            lstUsers.SelectedIndexChanged += LstUsers_SelectedIndexChanged;
            btnExportTxt.Click += BtnExportTxt_Click;
            btnImportTxt.Click += BtnImportTxt_Click;
            btnExportXml.Click += BtnExportXml_Click;
            btnImportXml.Click += BtnImportXml_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            User user = new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            users.Add(user);
            UpdateUserList();
            ClearInputs();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex == -1) return;

            users.RemoveAt(lstUsers.SelectedIndex);
            UpdateUserList();
        }

        private void LstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex == -1) return;

            User selectedUser = users[lstUsers.SelectedIndex];
            txtFirstName.Text = selectedUser.FirstName;
            txtLastName.Text = selectedUser.LastName;
            txtEmail.Text = selectedUser.Email;
            txtPhone.Text = selectedUser.Phone;
        }

        private void BtnExportTxt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, users.ConvertAll(u => u.ToString()));
                }
            }
        }

        private void BtnImportTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    users.Clear();
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 4)
                        {
                            users.Add(new User
                            {
                                FirstName = parts[0],
                                LastName = parts[1],
                                Email = parts[2],
                                Phone = parts[3]
                            });
                        }
                    }
                    UpdateUserList();
                }
            }
        }

        private void BtnExportXml_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, users);
                    }
                }
            }
        }

        private void BtnImportXml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        users = (List<User>)serializer.Deserialize(fs);
                    }
                    UpdateUserList();
                }
            }
        }

        private void UpdateUserList()
        {
            lstUsers.Items.Clear();
            foreach (var user in users)
            {
                lstUsers.Items.Add(user);
            }
        }

        private void ClearInputs()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtPhone.Text = string.Empty;
        }
    }

    [Serializable]
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{FirstName};{LastName};{Email};{Phone}";
        }
    }
}