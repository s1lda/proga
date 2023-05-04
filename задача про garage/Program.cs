using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
    delegate void Washer(Car car); 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во машин");
            int n = Int32.Parse(Console.ReadLine());
            List<Car> cars=new List<Car>(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите название");
                string name = Console.ReadLine();
                Console.WriteLine("Введите id машины");
                int id = Int32.Parse(Console.ReadLine());
                cars.Add(new Car(name,id));
            }
            Garage garage = new Garage(cars);

            Wash wash = new Wash();
            Washer washi = new Washer(wash.WashCar);


            foreach (Car car in garage.Cars)
            {

                washi(car);
            }
            Console.ReadKey();
        }
    }
}
