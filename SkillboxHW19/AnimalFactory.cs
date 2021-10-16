using Animals;
using System;
using System.Reflection;

namespace SkillboxHW19One
{
    public static class AnimalFactory
    {
        public static IAnimal GetAnimal(string Animal)
        {
            //Читаем файл библиотеки, ищем там класс, соответствующий описанию, возвращаем экземпляр класса

            Assembly assembly = Assembly.LoadFrom("Animals.dll");
            try
            {
                return (Activator.CreateInstance(assembly.GetType($"Animals.{Animal}")) as IAnimal);
            }
            catch (Exception)
            {
                return new NullAnimal();
            }

        }

    }
}
