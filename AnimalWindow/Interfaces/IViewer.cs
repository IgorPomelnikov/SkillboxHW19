namespace AnimalWindow
{
    public interface IViewer
    {
        /// <summary>
        /// Информация получаемая от Presenter по запросу Request
        /// </summary>
        public string Information { set; }

        /// <summary>
        /// Запрос на получение информации
        /// </summary>
        public string Request { get; }
    }
}
