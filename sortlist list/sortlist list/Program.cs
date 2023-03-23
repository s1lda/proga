using System.Data;
using System.Diagnostics.Contracts;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1)Stack methods");
            Console.WriteLine("2) ArrayList methods");
            Console.WriteLine("3) Hash methods");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) Contains");
                    Console.WriteLine("2) Pop");
                    Console.WriteLine("3) Peek");
                    Console.WriteLine("4) Clear");
                    Console.WriteLine("5) sort");
                    Console.WriteLine("6) copy");
                    Console.WriteLine("7) indexof");
                    Console.WriteLine("8) setvalue");
                    Console.WriteLine("9) binanrnysearch");
                    Console.WriteLine("10) getvalue");
                    Console.WriteLine("11) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            contains();
                            return true;
                        case "2":
                            pop();
                            return true;
                        case "3":
                            peek();
                            return true;
                        case "4":
                            clear();
                            return true;
                        case "5":
                            return true;
                        case "6":
                            return true;
                        case "7":
                            return true;
                        case "8":
                            return true;
                        case "9":
                            return true;
                        case "10":
                            return true;
                        case "11":
                            return false;
                        default:
                            return true;
                    }
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) Reverse");
                    Console.WriteLine("2) RemoveAt");
                    Console.WriteLine("3) IndexOf");
                    Console.WriteLine("4) Sort");
                    Console.WriteLine("5) Insert");
                    Console.WriteLine("6) Remove");
                    Console.WriteLine("7) Contains");
                    Console.WriteLine("8) Clear");
                    Console.WriteLine("9) Count");
                    Console.WriteLine("10) CopyTo");
                    Console.WriteLine("11) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return true;
                        case "3":
                            return true;
                        case "4":
                            return true;
                        case "5":
                            return true;
                        case "6":
                            return true;
                        case "7":
                            return true;
                        case "8":
                            return true;
                        case "9":
                            return true;
                        case "10":
                            return true;
                        case "11":
                            return false;
                    }
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) ContainsKey");
                    Console.WriteLine("2) ContainsValue");
                    Console.WriteLine("3) Add");
                    Console.WriteLine("4) Keys");
                    Console.WriteLine("5) Values");
                    Console.WriteLine("6) Clear");
                    Console.WriteLine("7) Remove");
                    Console.WriteLine("8) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return true;
                        case "3":
                            return true;
                        case "4":
                            return true;
                        case "5":
                            return true;
                        case "6":
                            return true;
                        case "7":
                            return true;
                        case "8":
                            return false;
                    }
                    return true;
                default:
                    Console.WriteLine("Такой опции нет");
                    return true;
            }
        }
        private static Stack<string> fillstack()
        {
            Console.WriteLine("Введите размерность стэка");
            int n= Convert.ToInt32(Console.ReadLine());
            Stack <string> people = new Stack<string>(n);
            for (int i = 0; i < n; i++)
			{
			    people.Push(Console.ReadLine());
			}
            return people;
        }
        private static void contains()
        {
            Console.Clear();
            Stack<string> people=fillstack();
            Console.WriteLine("Введите элемент");
            string text=Console.ReadLine();
            if (people.Contains(text))
            {
                DisplayResult("Такой элемент есть");
            }
            else
            {
                DisplayResult("Такого элемента нет");
            }
        }
        private static void pop()
        {
            Console.Clear();
            Stack<string> people = fillstack();
            people.Pop();
            string b="";
            foreach (var item in people)
            {
                b += item;
            }
            DisplayResult(b);
        }
        private static void peek()
        {
            Console.Clear();
            Stack<string> people = fillstack();
            DisplayResult(people.Peek());
        }
        private static void clear()
        {
            Console.Clear();
            Stack<string> people = fillstack();
            people.Clear();
            Console.WriteLine("Произошло удаление стэка");
            if (people == null)
            {
                DisplayResult("Он пустой)");
            }
            else
            {
                DisplayResult("Он не сработает никогда в жизни");
            }
        } 
            
        
        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
            Console.Write("Нажмите Enter,чтобы вернуться ");
            Console.ReadLine();
        }

    }
}