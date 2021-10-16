namespace Animals
{
    public interface IAnimal
    {
        /// <summary>
        /// Указывает на то, может ли животное жить в воде
        /// </summary>
        public bool WaterArea { get; set; }

        /// <summary>
        /// Указывает на возможный вес представителя этого типа животных
        /// </summary>
        public int MiddleWeight { get; set; }

        /// <summary>
        /// Пример животного
        /// </summary>
        public string Kingdom { get; set; }

        /// <summary>
        /// Присваивает значения полям
        /// </summary>
        /// <param name="waterArea">Возможность жизни в воде</param>
        /// <param name="middleWeight">Средний вес в классе</param>
        /// <param name="kingdom">Любое описание</param>
        void SetValues(bool waterArea, int middleWeight, string kingdom);
    }
}
