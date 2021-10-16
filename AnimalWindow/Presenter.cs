using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWindow
{
    public class Presenter : IPresenter
    {
        public IViewer Viewer { get; set; }
        public IModel Model { get; set; }

        public Presenter(IViewer viewer)
        {
            Viewer = viewer;
            Model = new AnimalModel();
        }
    }
}
