using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class SimpleFileClient
{
    private string serverIP;
    private int port = 27015;
    private string saveFolder;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="serverIP">IP адрес сервера</param>
    /// <param name="saveFolder">Папка для сохранения файлов</param>
    public SimpleFileClient(string serverIP, string saveFolder)
    {
        this.serverIP = serverIP;
        this.saveFolder = saveFolder;

        // Создаем папку, если её нет
        if (!Directory.Exists(saveFolder))
            Directory.CreateDirectory(saveFolder);
    }
    public void SetServerIP(string serverIP)
    {
        if (!string.IsNullOrEmpty(serverIP))
            this.serverIP = serverIP;
    }
    public void SetSaveFolder(string saveFolder)
    {
        if (!string.IsNullOrEmpty(saveFolder))
            this.saveFolder = saveFolder;
    }
    public string GetSaveFilePath()
    {
        return saveFolder;
    }
    /// <summary>
    /// Получить список файлов на сервере
    /// </summary>
    /// <returns>Список имен файлов</returns>
    public async Task<List<string>> GetFileListAsync()
    {
        try
        {
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(serverIP, port);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream);
                StreamReader reader = new StreamReader(stream);

                // Отправляем команду LIST
                await writer.WriteLineAsync("LIST");
                await writer.FlushAsync();

                // Читаем количество файлов
                int count = int.Parse(await reader.ReadLineAsync());
                List<string> files = new List<string>();

                // Читаем имена файлов
                for (int i = 0; i < count; i++)
                {
                    string fileName = await reader.ReadLineAsync();
                    files.Add(fileName);
                }

                return files;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    /// <summary>
    /// Скачать все файлы с сервера
    /// </summary>
    public async Task DownloadAllFilesAsync()
    {
        // Получаем список файлов
        List<string> files = await GetFileListAsync();

        // Скачиваем каждый файл
        foreach (string fileName in files)
        {
            await DownloadFileAsync(fileName);
        }

        Console.WriteLine("Все файлы скачаны!");
    }

    /// <summary>
    /// Скачать конкретный файл
    /// </summary>
    /// <param name="fileName">Имя файла</param>
    private async Task DownloadFileAsync(string fileName)
    {
        try
        {
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(serverIP, port);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream);
                StreamReader reader = new StreamReader(stream);

                // Отправляем команду GET с именем файла
                await writer.WriteLineAsync($"GET|{fileName}");
                await writer.FlushAsync();

                // Читаем размер файла
                long fileSize = long.Parse(await reader.ReadLineAsync());

                if (fileSize == -1)
                {
                    Console.WriteLine($"Файл {fileName} не найден на сервере");
                    return;
                }

                // Читаем данные файла
                byte[] fileData = new byte[fileSize];
                int bytesRead = 0;
                while (bytesRead < fileSize)
                {
                    bytesRead += await stream.ReadAsync(fileData, bytesRead,
                        (int)Math.Min(8192, fileSize - bytesRead));
                }

                // Сохраняем файл
                string savePath = Path.Combine(saveFolder, fileName);

                // Если файл существует, добавляем номер
                int counter = 1;
                string originalPath = savePath;
                while (File.Exists(savePath))
                {
                    string nameWithoutExt = Path.GetFileNameWithoutExtension(originalPath);
                    string ext = Path.GetExtension(originalPath);
                    savePath = Path.Combine(saveFolder, $"{nameWithoutExt}_{counter}{ext}");
                    counter++;
                }

                File.WriteAllBytes(savePath, fileData);
                Console.WriteLine($"Скачан: {fileName} -> {Path.GetFileName(savePath)}");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка скачивания {fileName}: {ex.Message}");
        }
    }
}