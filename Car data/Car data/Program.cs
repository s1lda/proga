using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<Car> listCar = new List<Car>();

        string choice;
        Console.WriteLine("База данных машин");
        while (true)
        {
            Console.WriteLine("1. Добавить машины\n2. Один владелец\n3. Старше выбранного года\n4. Поиск по модели\n5. Поиск по цвету\n6. Exit");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string text;
                    do
                    {
                        List<Owner> ownerList = new List<Owner>();
                        Console.WriteLine("Напишите 'Стоп',если хотите закончить ввод");
                        Console.WriteLine("Введите марку машины, цвет и год производства(через пробел)");
                        text = Console.ReadLine();
                        if (text != "Стоп")
                        {
                            Console.WriteLine("Введите кол-во владельцев:");
                            int n = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите владельца, год покупки и год продажи(через пробел)");
                            for (int i = 0; i < n; i++)
                            {
                                string[] tags = Console.ReadLine().Split();
                                Owner owner = new Owner(tags[0], tags[1], tags[2]);
                                ownerList.Add(owner);
                            }
                            string[] tag = text.Split();

                            Car car = new Car(tag[0], tag[1], tag[2], ownerList);
                            listCar.Add(car);
                        }
                    } while (text != "Стоп");
                    break;
                case "2":
                    static string OneOw(Car car)
                    {
                        if (car.OwnersLen == 1)
                        {
                            return car.Model + " " + car.Color + " " + car.Year.ToString();
                        }

                        return null;
                    }
                    foreach (var item in listCar)
                    {
                        if (OneOw(item) != null)
                        {
                            Console.WriteLine(OneOw(item));
                        }

                    }
                    break;
                case "3":
                    Console.WriteLine("Введите год");
                    int selYear = Int32.Parse(Console.ReadLine());
                    foreach (var item in listCar)
                    {
                        if (item.Year < selYear)
                        {
                            Console.WriteLine(item.Model + " " + item.Color + " " + item.Year.ToString());
                        }

                    }
                    break;
                case "5":
                    Console.WriteLine("Введите цвет");
                    string color = Console.ReadLine();
                    foreach (var item in listCar)
                    {
                        if (item.Color == color)
                        {
                            Console.WriteLine(item.Model + " " + item.Color + " " + item.Year.ToString());
                        }

                    }
                    break;
                case "4":
                    Console.WriteLine("Введите марку машины");
                    string model = Console.ReadLine();
                    foreach (var item in listCar)
                    {
                        if (item.Model == model)
                        {
                            Console.WriteLine(item.Model + " " + item.Color + " " + item.Year.ToString());
                        }

                    }
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
        }

    }
    public class Car
    {
        string model;
        string color;
        string year;
        List<Owner> owners;

        public Car(string model, string color, string year, List<Owner> owners)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.owners = owners;
        }

        public string Model { get { return model; } }
        public string Color { get { return color; } }
        public int Year { get { return Int32.Parse(year); } }
        public int OwnersLen { get { return owners.ToArray().Length; } }
    }
    internal class Owner
    {
        string name;
        string buy_year;
        string sold_year;

        public Owner(string name, string buy_year, string sold_year)
        {
            this.name = name;
            this.buy_year = buy_year;
            this.sold_year = sold_year;
        }
    }
}

