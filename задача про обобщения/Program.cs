using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace oboshnenie
{
    public class MyArray<T>
    {
        private T[] mas;
        public MyArray(int size)
        {
            mas = new T[size];
        }

        public void Add(T element, int index)
        {
            mas[index] = element;
        }

        public T GetByIndex(int index)
        {

            return mas[index];
        }

        public void delete(int index)
        {
            mas[index] = default(T);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Кол-во элементов ");
            int n = Convert.ToInt32(Console.ReadLine());
            // string массив
            MyArray<string> stringMas = new MyArray<string>(n);
            // double массив
            MyArray<double> doubleMas = new MyArray<double>(n);
            // string add
            Console.WriteLine("Сколько добавить элементов(string)");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                stringMas.Add(Console.ReadLine(), i);
            }
            // double add
            Console.WriteLine("Сколько добавить элементов(double)");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                doubleMas.Add(Convert.ToDouble(Console.ReadLine()), i);
            }
            // string index
            Console.WriteLine("Введите индекс(string)");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringMas.GetByIndex(index));
            // double index
            Console.WriteLine("Введите индекс(double)");
            int index2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(doubleMas.GetByIndex(index2));
            //string delete
            Console.WriteLine("Введите индекс, который хотите удалить(string)");
            int index3 = Convert.ToInt32(Console.ReadLine());
            stringMas.delete(index3);
            // double delete
            Console.WriteLine("Введите индекс, который хотите удалить(double)");
            int index4 = Convert.ToInt32(Console.ReadLine());
            doubleMas.delete(index4);
            Console.ReadKey();
        }
    }
}