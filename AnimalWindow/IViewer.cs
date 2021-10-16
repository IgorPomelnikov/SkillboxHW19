using System;
using System.Collections.Generic;
using System.Linq;
using Animals;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWindow
{
    public interface IViewer
    {
        public IPresenter Presenter { get; set; }
        public IAnimal Animal { get; set; }
    }
}
