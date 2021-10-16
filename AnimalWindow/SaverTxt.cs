using System;
using System.IO;

namespace AnimalWindow
{
    public class SaverTxt : ISaver
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
        public SaverTxt(string fileName, string content)
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
            File.WriteAllText($"{Path}\\{FileName}-{DateTime.Now:yyyy.MM.dd.HH-mm-ss}.txt", Content);
        }
    }
}
