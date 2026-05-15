namespace IndicationsTranfer
{
    public partial class MainForm : Form
    {
        SimpleFileClient fileClient;
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveParams_Click(object sender, EventArgs e)
        {
            if (fileClient == null)
            {
                fileClient = new SimpleFileClient(serverIP.Text, savePath.Text);
            }
            else
            {
                if (string.IsNullOrEmpty(serverIP.Text) || string.IsNullOrEmpty(savePath.Text))
                {
                    MessageBox.Show("Неверно задан IP сервера или путь к папке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fileClient.SetSaveFolder(savePath.Text);
                fileClient.SetServerIP(serverIP.Text);
            }
        }

        async private void GetFilesList_Click(object sender, EventArgs e)
        {
            List<string> files = await fileClient.GetFileListAsync();

            if (files == null)
            {
                MessageBox.Show("Ошибка получения списка файлов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (files.Count == 0)
            {
                MessageBox.Show("На сервере не найдено файлов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridViewFiles.Rows.Clear();

            foreach (string file in files)
            {
                dataGridViewFiles.Rows.Add(file);
            }
        }

        async private void ReceiveFiles_Click(object sender, EventArgs e)
        {
            try
            {
                await fileClient.DownloadAllFilesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void GraphMode_Button_Click(object sender, EventArgs e)
        {
            List<string> selectedFiles = new List<string>();

            foreach (DataGridViewCell cell in dataGridViewFiles.SelectedCells)
            {
                selectedFiles.Add(cell.Value.ToString());
            }

            string filePath = savePath.Text;

            List<string> filesPath = selectedFiles.Select(file => Path.Combine(filePath, file)).ToList();

            if (filesPath.All(file => File.Exists(file)))
            {
                GraphicsForm graphicsForm = new GraphicsForm(filesPath);

                graphicsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Сначала необходимо получите файлы с сервера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
