using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IAnimal
    { 
        public bool WaterArea { get; set; }
        public int MiddleWeight { get; set; }
        public string Kingdom { get; set; }

        /// <summary>
        /// Присваивает значения полям
        /// </summary>
        /// <param name="waterArea">Возможность жизни в воде</param>
        /// <param name="middleWeight">Средний вес в классе</param>
        /// <param name="kingdom">Любое описание</param>
        void SetValues(bool waterArea, int middleWeight, string kingdom);
    }
}
