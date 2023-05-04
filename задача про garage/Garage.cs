using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
    class Garage
    {
        List<Car> cars;
        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }
        public List<Car> Cars { get { return cars; } }
    }
}
