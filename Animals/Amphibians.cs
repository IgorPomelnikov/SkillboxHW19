using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Amphibians :IAnimal
    {
        public bool WaterArea { get; set; }
        public int MiddleWeight { get; set; }
        public string Kingdom { get; set; }
        public Amphibians()
        {
            SetValues(true, 20, "Амфибия");
        }
        public void SetValues(bool waterArea, int middleWeight, string kingdom)
        {
            WaterArea = waterArea;
            MiddleWeight = middleWeight;
            Kingdom = kingdom;
        }
    }
}
