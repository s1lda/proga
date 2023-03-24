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
            Console.WriteLine("2) Queue methods");
            Console.WriteLine("3) Dictionary methods");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) Contains");
                    Console.WriteLine("2) Pop");
                    Console.WriteLine("3) Peek");
                    Console.WriteLine("4) Clear");
                    Console.WriteLine("5) ToArray");
                    Console.WriteLine("6) Push");
                    Console.WriteLine("7) Exit");
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
                            toarray();
                            return true;
                        case "6":
                            push();
                            return true;
                        case "7":
                            return false;
                        default:
                            return true;
                    }
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) Dequeue");
                    Console.WriteLine("2) Enqueue");
                    Console.WriteLine("3) Peek");
                    Console.WriteLine("4) Contains");
                    Console.WriteLine("5) Clear");
                    Console.WriteLine("6) ToArray");
                    Console.WriteLine("7) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            deque();
                            return true;
                        case "2":
                            enque();
                            return true;
                        case "3":
                            pek();
                            return true;
                        case "4":
                            con();
                            return true;
                        case "5":
                            cl();
                            return true;
                        case "6":
                            toar();
                            return true;
                        case "7":
                            return false;
                    }
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) ContainsKey");
                    Console.WriteLine("2) ContainsValue");
                    Console.WriteLine("3) Remove");
                    Console.WriteLine("4) Keys");
                    Console.WriteLine("5) Values");
                    Console.WriteLine("6) Add");
                    Console.WriteLine("7) Clear");
                    Console.WriteLine("8) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            ContainsKey();
                            return true;
                        case "2":
                            ContainsValue();
                            return true;
                        case "3":
                            remove();
                            return true;
                        case "4":
                            key();
                            return true;
                        case "5":
                            value();
                            return true;
                        case "6":
                            dob();
                            return true;
                        case "7":
                            ochist();
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
        private static Dictionary<string,string> filldic()
        {
            Console.WriteLine("Введите кол-во пар");
            int n = Convert.ToInt32(Console.ReadLine());
            var people=new Dictionary<string,string>(n);
            Console.WriteLine("Введите сначала ключ, потом значение");
            for (int i = 0; i < n; i++)
            {
                people.Add(Console.ReadLine(), Console.ReadLine());
            }
            return people;
        }
        private static void ContainsKey()
        {
            Console.Clear();
            Console.WriteLine("ContainsKey");
            var people = filldic();
            Console.WriteLine("Введите ключ, который хотите проверить на наличие");
            string text = Console.ReadLine();
            if (people.ContainsKey(text))
            {
                DisplayResult("Такой элемент есть");
            }
            else
            {
                DisplayResult("Такого нет");
            }
        }
        private static void ContainsValue()
        {
            Console.Clear();
            Console.WriteLine("ContainsValue");
            var people = filldic();
            Console.WriteLine("Введите значение, которое хотите проверить на наличие");
            string text = Console.ReadLine();
            if (people.ContainsValue(text))
            {
                DisplayResult("Такой элемент есть");
            }
            else
            {
                DisplayResult("Такого нет");
            }
        }
        private static void remove()
        {
            Console.Clear();
            Console.WriteLine("Remove");
            var people = filldic();
            Console.WriteLine("Введите ключ, который хотите удалить");
            string text = Console.ReadLine();
            people.Remove(text);
            string b = "";
            foreach (var item in people)
            {
                b += item+"\n";
            }
            DisplayResult(b);
        }
        private static void value()
        {
            Console.Clear();
            Console.WriteLine("Values");
            var people = filldic();
            Console.WriteLine("Выводим все ключи");
            ICollection c = people.Values;
            string b = "";
            foreach (var str in c)
            {
                b += Convert.ToString(str) + '\n';
            }
            DisplayResult(b);
        }
        private static void key()
        {
            Console.Clear();
            Console.WriteLine("Keys");
            var people = filldic();
            Console.WriteLine("Выводим все ключи");
            ICollection c = people.Keys;
            string b = "";
            foreach (var str in c)
            {
                b += Convert.ToString(str) + '\n';
            }
            DisplayResult(b);
        }
        private static void dob()
        {
            Console.Clear();
            Console.WriteLine("Add");
            var people = filldic();
            Console.WriteLine("Введите новый элемент и ключ");
            people.Add(Console.ReadLine(), Console.ReadLine());
            string b = "";
            foreach (var item in people)
            {
                b += item + "\n";
            }
            DisplayResult(b);
        }
        private static void ochist()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            var mas = filldic();
            mas.Clear();
            Console.WriteLine("Произошло удаление словаря");
            string b = "";
            foreach (var item in mas)
            {
                b += item;
            }
            if (b == "")
            {
                DisplayResult("Он пустой(");
            }
            else
            {
                DisplayResult("Он никогда не сработает");
            }
        } 

        private static Queue fillqueue()
        {
            Console.WriteLine("Введите размерность очереди");
            int n = Int32.Parse(Console.ReadLine());
            Queue mas = new Queue(n);
            for (int i = 0; i < n; i++)
            {
                mas.Enqueue(Console.ReadLine());
            }
            return mas;
        }
        private static void deque()
        {
            Console.Clear();
            Console.WriteLine("Dequeue");
            Queue mas = fillqueue();
            mas.Dequeue();
            Console.WriteLine("Удаляем из начала");
            string b = "";
            foreach (var item in mas)
            {
                b += item;
            }
            DisplayResult(b);
        }
        private static void enque()
        {
            Console.Clear();
            Console.WriteLine("Enqueue");
            Queue mas = fillqueue();
            Console.WriteLine("Введите новый элемент");
            mas.Enqueue(Console.ReadLine());
            string b = "";
            foreach (var item in mas)
            {
                b += item;
            }
            DisplayResult(b);
        }
        private static void pek()
        {
            Console.Clear();
            Console.WriteLine("Peek");
            Queue mas = fillqueue();
            DisplayResult(String.Concat(mas.Peek()));
        }
        private static void con()
        {
            Console.Clear();
            Console.WriteLine("Contains");
            Queue mas = fillqueue();
            Console.WriteLine("Введите элемент, который хотите сравнить");
            string text = Console.ReadLine();
            if (mas.Contains(text))
            {
                DisplayResult("Такой элемент есть");
            }
            else
            {
                DisplayResult("Такого элемента нет");
            }
        }
        private static void cl()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            Queue mas = fillqueue();
            mas.Clear();
            Console.WriteLine("Произошло удаление очереди");
            string b = "";
            foreach (var item in mas)
            {
                b += item;
            }
            if (b == "")
            {
                DisplayResult("Он пустой(");
            }
            else
            {
                DisplayResult("Он никогда не сработает");
            }
        }
        private static void toar()
        {
            Console.Clear();
            Console.WriteLine("ToArray");
            Queue mas= fillqueue();
            Array mas2 = mas.ToArray();
            Console.WriteLine("Теперь у нас стэк превратился в array");
            string b = "";
            foreach (var item in mas2)
            {
                b += item;
            }
            DisplayResult(b);
        }
        private static Stack<string> fillstack()
        {
            Console.WriteLine("Введите размерность стэка");
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<string> people = new Stack<string>(n);
            for (int i = 0; i < n; i++)
            {
                people.Push(Console.ReadLine());
            }
            return people;
        }
        private static void contains()
        {
            Console.Clear();
            Console.WriteLine("Contains");
            Stack<string> people = fillstack();
            Console.WriteLine("Введите элемент");
            string text = Console.ReadLine();
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
            Console.WriteLine("Pop");
            Stack<string> people = fillstack();
            people.Pop();
            string b = "";
            foreach (var item in people)
            {
                b += item;
            }
            DisplayResult(b);
        }
        private static void peek()
        {
            Console.Clear();
            Console.WriteLine("Peek");
            Stack<string> people = fillstack();
            DisplayResult(people.Peek());
        }
        private static void clear()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            Stack<string> people = fillstack();
            people.Clear();
            Console.WriteLine("Произошло удаление стэка");
            string b = "";
            foreach (var item in people)
            {
                b += item;
            }
            if (b == "")
            {
                DisplayResult("Он пустой(");
            }
            else
            {
                DisplayResult("Он никогда не сработает");
            }
        }
        private static void toarray()
        {
            Console.Clear();
            Console.WriteLine("ToArray");
            Stack<string> people = fillstack();
            Array mas = people.ToArray();
            Console.WriteLine("Теперь у нас стэк превратился в array");
            string b = "";
            foreach (var item in mas)
            {
                b += item;
            }
            DisplayResult(b);
        }
        private static void push()
        {
            Console.Clear();
            Console.WriteLine("Push");
            Stack<string> people = fillstack();
            Console.WriteLine("Введите элемент, который хотите добавить");
            people.Push(Console.ReadLine());
            DisplayResult(String.Concat(people));

        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
            Console.Write("Нажмите Enter,чтобы вернуться ");
            Console.ReadLine();
        }

    }
}