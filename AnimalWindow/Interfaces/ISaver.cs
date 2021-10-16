namespace AnimalWindow
{
    public interface ISaver
    {


        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { set; }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// Содежимое файла
        /// </summary>
        public string Content { set; }

        /// <summary>
        /// Записывает содержимое в файл
        /// </summary>
        public void SaveFile();
    }
}
