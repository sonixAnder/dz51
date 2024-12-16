namespace WFL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ReadFileWithProgress(filePath);
                }
            }
        }

        private async void ReadFileWithProgress(string filePath)
        {
            try
            {
                long fileSize = new FileInfo(filePath).Length;
                progressBar.Maximum = 100;
                progressBar.Value = 0;

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                {
                    char[] buffer = new char[1024];
                    int totalRead = 0;
                    int bytesRead;

                    while ((bytesRead = await reader.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        totalRead += bytesRead;
                        int progress = (int)((double)totalRead / fileSize * 100);
                        progressBar.Value = progress;
                        lblStatus.Text = $"Прогресс: {progress}%";
                        await Task.Delay(500);
                    }
                    lblStatus.Text = "Чтение завершено!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}