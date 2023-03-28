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
using System.ComponentModel.DataAnnotations;

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
            Console.WriteLine("4) List methods");
            Console.WriteLine("5) SortedList methods");
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
                case "4":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) Add");
                    Console.WriteLine("2) Contains");
                    Console.WriteLine("3) IndexOf");
                    Console.WriteLine("4) Remove");
                    Console.WriteLine("5) Clear");
                    Console.WriteLine("6) Binarnysearch");
                    Console.WriteLine("7) Insert");
                    Console.WriteLine("8) Reverse");
                    Console.WriteLine("9) Find");
                    Console.WriteLine("10) Exists");
                    Console.WriteLine("11) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            addlist();
                            return true;
                        case "2":
                            containslist();
                            return true;
                        case "3":
                            indexof();
                            return true;
                        case "4":
                            removelist();
                            return true;
                        case "5":
                            clearlist();
                            return true;
                        case "6":
                            binarnysearch();
                            return true;
                        case "7":
                            insert();
                            return true;
                        case "8":
                            reverse();
                            return true;
                        case "9":
                            findall();
                            return true;
                        case "10":
                            exists();
                            return true;
                        case "11":
                            return false;
                    }
                    return true;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) Add");
                    Console.WriteLine("2) ContainsKey");
                    Console.WriteLine("3) Remove");
                    Console.WriteLine("4) IndexOfKey");
                    Console.WriteLine("5) Clear");
                    Console.WriteLine("6) GetKeys");
                    Console.WriteLine("7) ContainsValue");
                    Console.WriteLine("8) GetByIndex");
                    Console.WriteLine("9) GetKey(Int32)");
                    Console.WriteLine("10) Exit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            addsorted();
                            return true;
                        case "2":
                            Containssorted();
                            return true;
                        case "3":
                            removesorted();
                            return true;
                        case "4":
                            indexofkey();
                            return true;
                        case "5":
                            clearsorted();
                            return true;
                        case "6":
                            getkey();
                            return true;
                        case "7":
                            ContainsValuesorted();
                            return true;
                        case "8":
                            getbyindex();
                            return true;
                        case "9":
                            getkeybyindex();
                            return true;
                        case "10":
                            return false;
                    }
                    return true;
                default:
                    Console.WriteLine("Такой опции нет");
                    return true;
            }
        }
        private static SortedList fillsorted()
        {
            Console.WriteLine("Введите размерность sortedlist");
            int n = Int32.Parse(Console.ReadLine());
            SortedList list = new SortedList(n);
            Console.WriteLine("Введите сначала ключ, потом значение");
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine(), Console.ReadLine());
            }
            return list;
        }
        private static void addsorted()
        {
            Console.Clear();
            Console.WriteLine("Add");
            SortedList list=fillsorted();
            Console.WriteLine("Введите новый ключи и значение");
            list.Add(Console.ReadLine(), Console.ReadLine());
            string b = "";
            ICollection c = list.Keys;
            foreach (var item in c)
            {
                b +=  item + ":" + list[item] + "\n";
            }
            DisplayResult(b);
        }
        private static void Containssorted()
        {
            Console.Clear();
            Console.WriteLine("ContainsKey");
            SortedList list = fillsorted();
            Console.WriteLine("Введите ключ, который хотите проверить на наличие");
            string text = Console.ReadLine();
            if (list.ContainsKey(text))
            {
                DisplayResult("Такой ключ есть");
            }
            else
            {
                DisplayResult("Такого ключа нет");
            }
        }
        private static void removesorted()
        {
            Console.Clear();
            Console.WriteLine("Remove");
            SortedList list = fillsorted();
            Console.WriteLine("Введите ключ, который хотите удалить");
            string text = Console.ReadLine();
            list.Remove(text);
            string b = "";
            ICollection c = list.Keys;
            foreach (var item in c)
            {
                b += item + ":" + list[item] + "\n";
            }
            DisplayResult(b);
        }
        private static void indexofkey()
        {
            Console.Clear();
            Console.WriteLine("IndexOfKey");
            SortedList list = fillsorted();
            Console.WriteLine("Введите ключ, чтобы узнать его индекс");
            string text = Console.ReadLine();
            DisplayResult(Convert.ToString(list.IndexOfKey(text)));
        }
        private static void clearsorted()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            SortedList list = fillsorted();
            Console.WriteLine("Происходит удаление sortedlist");
            list.Clear();
            string b = "";
            ICollection c = list.Keys;
            foreach (var item in c)
            {
                b += item + ":" + list[item] + "\n";
            }
            if (b == "")
            {
                DisplayResult("Он пустой");
            }
        }
        private static void getkey()
        {
            Console.Clear();
            Console.WriteLine("GetKey");
            SortedList list = fillsorted();
            Console.WriteLine("Все ключи:");
            IList myKeyList = list.GetKeyList();
            string b = "";
            foreach (var item in myKeyList)
            {
                b += item + " ";
            }
            DisplayResult(b);
        }
        private static void ContainsValuesorted()
        {
            Console.Clear();
            Console.WriteLine("ContainsValue");
            SortedList list = fillsorted();
            Console.WriteLine("Введите значение, которое будем проверять на наличие");
            string text = Console.ReadLine();
            if (list.ContainsValue(text))
            {
                DisplayResult("Такое значение есть");
            }
            else
            {
                DisplayResult("Такого значения нет");
            }
        }
        private static void getbyindex()
        {
            Console.Clear();
            Console.WriteLine("GetByIndex");
            SortedList list = fillsorted();
            Console.WriteLine("Введите индекс ключа, чтобы узнать его значение");
            int n = Int32.Parse(Console.ReadLine());
            DisplayResult(String.Concat(list.GetByIndex(n)));
        }
        private static void getkeybyindex()
        {
            Console.Clear();
            Console.WriteLine("GetKey");
            SortedList list = fillsorted();
            Console.WriteLine("Введите индекс ключа");
            int n = Int32.Parse(Console.ReadLine());
            DisplayResult(String.Concat(list.GetKey(n)));
        }
        private static List<string> filllist()
        {
            Console.WriteLine("Введите размерность листа");
            int n = Int32.Parse(Console.ReadLine());
            List<string> list = new List<string>(n);
            Console.WriteLine("Введите элементы");
            for (int i = 0; i <n; i++)
            {
                list.Add(Console.ReadLine());
            }
            return list;
        }
        private static void addlist()
        {
            Console.Clear();
            Console.WriteLine("Add");
            var list = filllist();
            Console.WriteLine("Введите новый элемент");
            string text = Console.ReadLine();
            list.Add(text);
            DisplayResult(String.Concat(list));
        }
        private static void containslist()
        {
            Console.Clear();
            Console.WriteLine("Contains");
            var list = filllist();
            Console.WriteLine("Введите элемент, который хотите проверить");
            string text = Console.ReadLine();
            if (list.Contains(text))
            {
                DisplayResult("Такой элемент есть");
            }
            else
            {
                DisplayResult("Такого элемента нет");
            }
        }
        private static void indexof()
        {
            Console.Clear();
            Console.WriteLine("IndexOf");
            var list = filllist();
            Console.WriteLine("Введите элемент, чтобы узнать его индекс");
            string text = Console.ReadLine();
            if (list.Contains(text))
            {
                DisplayResult(String.Concat(list.IndexOf(text)));
            }
            else
            {
                DisplayResult("Такого элемента нет");
            }
        }
        private static void removelist()
        {
            Console.Clear();
            Console.WriteLine("Remove");
            var list = filllist();
            Console.WriteLine("Введите  элемент, который хотите удалить");
            string text = Console.ReadLine();
            list.Remove(text);
            DisplayResult(String.Concat(list));
        }
        private static void clearlist()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            var list = filllist();
            Console.WriteLine("Происходит удаление листа");
            list.Clear();
            string b = "";
            foreach (var item in list)
            {
                b+=item;
            }
            if (b == "")
            {
                DisplayResult("Он пустой)");
            }
        }
        private static void binarnysearch()
        {
            Console.Clear();
            Console.WriteLine("Binarnysearch");
            var list = filllist();
            Console.WriteLine("Происходит сортировка листо");
            list.Sort();
            Console.WriteLine(String.Concat(list));
            Console.WriteLine("Введите элемент, чтобы узнать его индекс");
            string text = Console.ReadLine();
            if (list.Contains(text))
            {
                DisplayResult(String.Concat(list.BinarySearch(text)));
            }
            else
            {
                DisplayResult("Такого элемента нет");
            }
        }
        private static void insert()
        {
            Console.Clear();
            Console.WriteLine("Insert");
            var list = filllist();
            Console.WriteLine("Введите новый элемент и его индекс");
            string text = Console.ReadLine();
            int n = Int32.Parse(Console.ReadLine());
            list.Insert(n, text);
            DisplayResult(String.Concat(list));
        }
        private static void reverse()
        {
            Console.Clear();
            Console.WriteLine("Reverse");
            List<string>  list = filllist();
            Console.WriteLine("Обратный лист:");
            list.Reverse();
            DisplayResult(String.Concat(list));

        }
        private static void findall()
        {
            Console.Clear();
            Console.WriteLine("FindAll");
            Console.WriteLine("Здесь вводить только целые числа");
            Console.WriteLine("Введите размерность листа");
            int n =Int32.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Введите любое число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Все числа больше вашего:");
            DisplayResult(String.Concat(list.FindAll(x => x > y)));
        }
        private static void exists()
        {
            Console.Clear();
            Console.WriteLine("FindAll");
            Console.WriteLine("Здесь вводить только целые числа");
            Console.WriteLine("Введите размерность листа");
            int n = Int32.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Введите любое число, чтобы проверить есть ли числа больше вашего");
            int y = Convert.ToInt32(Console.ReadLine());
            if (list.Exists(x => x > y))
            {
                DisplayResult("Есть числа больше вашего");
            }
            else
            {
                DisplayResult("Нет чисел больше вашего");
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