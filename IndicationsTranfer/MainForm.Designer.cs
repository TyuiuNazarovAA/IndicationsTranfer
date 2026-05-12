namespace IndicationsTranfer
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
            savePath = new TextBox();
            label1 = new Label();
            serverIP = new TextBox();
            label2 = new Label();
            GetFilesList = new Button();
            ReceiveFiles = new Button();
            saveParams = new Button();
            dataGridViewFiles = new DataGridView();
            FileList = new DataGridViewTextBoxColumn();
            GraphMode_Button = new Button();
            SelectedFile_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).BeginInit();
            SuspendLayout();
            // 
            // savePath
            // 
            savePath.Location = new Point(23, 50);
            savePath.Name = "savePath";
            savePath.Size = new Size(249, 27);
            savePath.TabIndex = 0;
            savePath.Text = "C:\\Users\\epiccipe\\Desktop\\FilesTo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Куда сохранять";
            // 
            // serverIP
            // 
            serverIP.Location = new Point(23, 111);
            serverIP.Name = "serverIP";
            serverIP.Size = new Size(125, 27);
            serverIP.TabIndex = 0;
            serverIP.Text = "192.168.0.180";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "IP сервера";
            // 
            // GetFilesList
            // 
            GetFilesList.Location = new Point(23, 310);
            GetFilesList.Name = "GetFilesList";
            GetFilesList.Size = new Size(157, 56);
            GetFilesList.TabIndex = 2;
            GetFilesList.Text = "Список файлов";
            GetFilesList.UseVisualStyleBackColor = true;
            GetFilesList.Click += GetFilesList_Click;
            // 
            // ReceiveFiles
            // 
            ReceiveFiles.Location = new Point(23, 372);
            ReceiveFiles.Name = "ReceiveFiles";
            ReceiveFiles.Size = new Size(157, 56);
            ReceiveFiles.TabIndex = 2;
            ReceiveFiles.Text = "Получить файлы";
            ReceiveFiles.UseVisualStyleBackColor = true;
            ReceiveFiles.Click += ReceiveFiles_Click;
            // 
            // saveParams
            // 
            saveParams.Location = new Point(23, 161);
            saveParams.Name = "saveParams";
            saveParams.Size = new Size(132, 48);
            saveParams.TabIndex = 2;
            saveParams.Text = "Сохранить";
            saveParams.UseVisualStyleBackColor = true;
            saveParams.Click += saveParams_Click;
            // 
            // dataGridViewFiles
            // 
            dataGridViewFiles.AllowUserToAddRows = false;
            dataGridViewFiles.AllowUserToDeleteRows = false;
            dataGridViewFiles.AllowUserToResizeColumns = false;
            dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiles.Columns.AddRange(new DataGridViewColumn[] { FileList });
            dataGridViewFiles.Location = new Point(326, 50);
            dataGridViewFiles.Name = "dataGridViewFiles";
            dataGridViewFiles.ReadOnly = true;
            dataGridViewFiles.RowHeadersVisible = false;
            dataGridViewFiles.RowHeadersWidth = 51;
            dataGridViewFiles.Size = new Size(256, 345);
            dataGridViewFiles.TabIndex = 4;
            // 
            // FileList
            // 
            FileList.HeaderText = "Список файлов";
            FileList.MinimumWidth = 6;
            FileList.Name = "FileList";
            FileList.ReadOnly = true;
            FileList.Width = 250;
            // 
            // GraphMode_Button
            // 
            GraphMode_Button.Location = new Point(612, 98);
            GraphMode_Button.Name = "GraphMode_Button";
            GraphMode_Button.Size = new Size(116, 52);
            GraphMode_Button.TabIndex = 5;
            GraphMode_Button.Text = "График";
            GraphMode_Button.UseVisualStyleBackColor = true;
            GraphMode_Button.Click += GraphMode_Button_Click;
            // 
            // SelectedFile_Label
            // 
            SelectedFile_Label.AutoSize = true;
            SelectedFile_Label.Location = new Point(612, 57);
            SelectedFile_Label.Name = "SelectedFile_Label";
            SelectedFile_Label.Size = new Size(116, 20);
            SelectedFile_Label.TabIndex = 6;
            SelectedFile_Label.Text = "Выбран файл: -";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 450);
            Controls.Add(SelectedFile_Label);
            Controls.Add(GraphMode_Button);
            Controls.Add(dataGridViewFiles);
            Controls.Add(ReceiveFiles);
            Controls.Add(saveParams);
            Controls.Add(GetFilesList);
            Controls.Add(label2);
            Controls.Add(serverIP);
            Controls.Add(label1);
            Controls.Add(savePath);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox savePath;
        private Label label1;
        private TextBox serverIP;
        private Label label2;
        private Button GetFilesList;
        private Button ReceiveFiles;
        private Button saveParams;
        private DataGridView dataGridViewFiles;
        private DataGridViewTextBoxColumn FileList;
        private Button GraphMode_Button;
        private Label SelectedFile_Label;
    }
}
