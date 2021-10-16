namespace AnimalWindow
{
    public interface IPresenter
    {
        /// <summary>
        /// Ссылка на Viewer из паттерна MVP
        /// </summary>
        public IViewer Viewer { get; set; }

        /// <summary>
        /// Ссылка на Model из паттерна MVP
        /// </summary>
        public IModel Model { get; set; }
    }
}
