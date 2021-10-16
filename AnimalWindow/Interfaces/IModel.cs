using Animals;

namespace AnimalWindow
{
    public interface IModel
    {
        /// <summary>
        /// Экземляр животного
        /// </summary>
        public IAnimal Animal { get; set; }

        /// <summary>
        /// Получает экземпляр животного
        /// </summary>
        /// <param name="request"></param>
        public void GetAnimal(string request);
    }
}
