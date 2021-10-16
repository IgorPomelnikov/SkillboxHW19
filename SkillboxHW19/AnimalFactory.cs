using System;
using Animals;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHW19One
{
    public static class AnimalFactory
    {
        public static IAnimal GetAnimal(string Animal)
        {
            //Читаем файл библиотеки, ищем там класс, соответствующий описанию, возвращаем
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
