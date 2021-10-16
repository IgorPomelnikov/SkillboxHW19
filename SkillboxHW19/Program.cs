using Animals;
using System;

namespace SkillboxHW19One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название класса на английском.");
            string animalType = Console.ReadLine();
            IAnimal animal = AnimalFactory.GetAnimal(animalType);

            Console.WriteLine($"Например, это {animal.Kingdom}, " +
                              $"вес бывает {animal.MiddleWeight}кг, " +
                              $"возможна жизнь в воде {animal.WaterArea}");
            Console.ReadLine();
        }
    }
}
