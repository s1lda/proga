using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Linq
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Кол-во элементов:");
            int n=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Элементы:");
            for (int i = 0; i < n; i++)
            {
                list.Add(Int32.Parse(Console.ReadLine()));
            }
            int countP = (from k in list
                         where k > 0
                         select k).Count();
            int countO = (from k in list
                          where k < 0
                          select k).Count();
            int sum= (from k in list
                      where k > 0
                      select k).Sum();
            Console.WriteLine($"Пол= {countP} ") ;
            Console.WriteLine($"Отр= {countO} ");
            Console.WriteLine($"Сум= {sum} ");
        }
    }
}