using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWindow
{
    public interface IPresenter
    {
        public IViewer Viewer { get; set; }
        public IModel Model { get; set; }
    }
}
