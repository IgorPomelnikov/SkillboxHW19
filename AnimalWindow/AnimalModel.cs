using Animals;
using System;
using SkillboxHW19One;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWindow
{
    public class AnimalModel : IModel
    {
        public IAnimal Animal { get; set; }

        public void GetAnimal(string request)
        {
            Animal = AnimalFactory.GetAnimal(request);
        }
    }
}
