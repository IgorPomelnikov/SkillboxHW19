using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Mammals : IAnimal
    {
        public bool WaterArea { get; set; }
        public int MiddleWeight { get; set; }
        public string Kingdom { get ; set; }
        public Mammals()
        {
            SetValues(false, 80, "Примат");
        }
        public void SetValues(bool waterArea, int middleWeight, string kingdom)
        {
            WaterArea = waterArea;
            MiddleWeight = middleWeight;
            Kingdom = kingdom;
        }
    }
}
