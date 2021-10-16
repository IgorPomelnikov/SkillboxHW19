using Animals;
using SkillboxHW19One;

namespace AnimalWindow
{
    public class AnimalModel : IModel
    {
        /// <summary>
        /// Животное
        /// </summary>
        public IAnimal Animal { get; set; }

        /// <summary>
        /// Возвращает экземпляр животного
        /// </summary>
        /// <param name="request"></param>
        public void GetAnimal(string request)
        {
            Animal = AnimalFactory.GetAnimal(request);
        }

        /// <summary>
        /// Выводит информацию о животном в строковом представлении
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Animal is NullAnimal) return "404\nИзвините, но в программе нет таких животных";
            else return $"Например, это {Animal.Kingdom}, " +
                        $"вес бывает {Animal.MiddleWeight}кг, " +
                        $"способность жить в воде - {Animal.WaterArea}";
        }
    }
}
