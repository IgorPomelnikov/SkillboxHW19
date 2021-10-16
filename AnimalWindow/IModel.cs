using System;
using System.Collections.Generic;
using System.Linq;
using Animals;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWindow
{
    public interface IModel
    {
        public IAnimal Animal { get; set; }
        public void GetAnimal(string request);
    }
}
