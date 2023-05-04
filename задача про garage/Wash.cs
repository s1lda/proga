using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using garage;
delegate string Washer(Car car); 
namespace garage
{
    class Wash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine("Машина c id " + car.Id + " и именем " + car.Name + " помыта");
        }
    }
}
