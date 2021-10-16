using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Birds : IAnimal
    {
        public bool WaterArea { get; set; }
        public int MiddleWeight { get; set; }
        public string Kingdom { get; set; }
        public Birds()
        {
            SetValues(false, 2, "Птица");
        }
        public void SetValues(bool waterArea, int middleWeight, string kingdom)
        {
            WaterArea = waterArea;
            MiddleWeight = middleWeight;
            Kingdom = kingdom;
        }
    }
}
