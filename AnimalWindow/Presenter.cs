namespace AnimalWindow
{
    public class Presenter : IPresenter
    {
        /// <summary>
        /// Экземпляр Viewer из паттерна MVP
        /// </summary>
        public IViewer Viewer { get; set; }

        /// <summary>
        /// Экземпляр Model мз паттерна MVP
        /// </summary>
        public IModel Model { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="viewer"></param>
        public Presenter(IViewer viewer)
        {
            Viewer = viewer;
            Model = new AnimalModel();
        }

        /// <summary>
        /// Получает результат от модели
        /// </summary>
        public void GetResult()
        {
            Model.GetAnimal(Viewer.Request);
            Viewer.Information = Model.ToString();
        }

        /// <summary>
        /// Отправляет информацию на сохранение
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        public void SaveToTxt(string fileName, string content)
        {
            var saver = new SaverTxt(fileName, content);
            saver.SaveFile();
        }

        /// <summary>
        /// Отправляет информацию на сохранение
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        public void SaveToCsv(string fileName, string content)
        {
            var saver = new SaverCsv(fileName, content);
            saver.SaveFile();
        }
    }
}
