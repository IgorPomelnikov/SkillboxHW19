using System;
using System.IO;
using System.Text;

namespace AnimalWindow
{
    public class SaverCsv : ISaver
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { set; get; }

        /// <summary>
        /// Путь к сохраняемому файлу
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// Информация для сохранения
        /// </summary>
        public string Content { set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        public SaverCsv(string fileName, string content)
        {
            Content = content;
            if (String.IsNullOrWhiteSpace(fileName)) FileName = "EmptyRequest";
            else FileName = fileName;
            Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        /// <summary>
        /// Создаёт файл и записывает в него информацию
        /// </summary>
        public void SaveFile()
        {
            File.WriteAllText($"{Path}\\{FileName}-{DateTime.Now:yyyy.MM.dd.HH-mm-ss}.csv", Content, Encoding.Unicode);
        }
    }
}
