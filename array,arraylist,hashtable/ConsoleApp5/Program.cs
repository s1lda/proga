﻿using System.Data;
using System.Diagnostics.Contracts;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
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
            Console.WriteLine("1) Array methods");
            Console.WriteLine("2) ArrayList methods");
            Console.WriteLine("3) Hash methods");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1) reverse");
                    Console.WriteLine("2) length");
                    Console.WriteLine("3) rank");
                    Console.WriteLine("4) clear");
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
                            ReverseString();
                            return true;
                        case "2":
                            length();
                            return true;
                        case "3":
                            rank();
                            return true;
                        case "4":
                            clear();
                            return true;
                        case "5":
                            sort();
                            return true;
                        case "6":
                            copy();
                            return true;
                        case "7":
                            indexof();
                            return true;
                        case "8":
                            set();
                            return true;
                        case "9":
                            binanrnysearch();
                            return true;
                        case "10":
                            getvalue();
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
                            reverse();
                            return true;
                        case "2":
                            removeat();
                            return true;
                        case "3":
                            indexoflist();
                            return true;
                        case "4":
                            sortlist();
                            return true;
                        case "5":
                            insert();
                            return true;
                        case "6":
                            remove();
                            return true;
                        case "7":
                            contains();
                            return true;
                        case "8":
                            clearlist();
                            return true;
                        case "9":
                            count();
                            return true;
                        case "10":
                            copyto();
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
                            containskey();
                            return true;
                        case "2":
                            containsvalue();
                            return true;
                        case "3":
                            add();
                            return true;
                        case "4":
                            key();
                            return true;
                        case "5":
                            value();
                            return true;
                        case "6":
                            cleartable();
                            return true;
                        case "7":
                            removetable();
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
        private static Hashtable filltable()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Введите кол-во пар");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Сначала вводим ключ, потом его значение(через Enter)");
            for (int i = 0; i < n; i++)
            {
                ht.Add(Console.ReadLine(), Console.ReadLine());
            }
            return ht;
        }
        private static void containskey()
        {
            Console.Clear();
            Console.WriteLine("ContainsKey");
            Hashtable ht = filltable();
            Console.WriteLine("Введите ключ, чтобы определить его на наличие");
            string text = Console.ReadLine();
            if (ht.ContainsKey(text))
            {
                DisplayResult("Такой ключ есть");
            }
            else
            {
                DisplayResult("Такого ключа нет");
            }
        }
        private static void containsvalue()
        {
            Console.Clear();
            Console.WriteLine("ContainsValue");
            Hashtable ht = filltable();
            Console.WriteLine("Введите значение, чтобы определить его на наличие");
            string text = Console.ReadLine();
            if (ht.ContainsValue(text))
            {
                DisplayResult("Такое значение есть");
            }
            else
            {
                DisplayResult("Такого значения нет");
            }
        }
        private static void add()
        {
            Console.Clear();
            Console.WriteLine("Add");
            Hashtable ht = filltable();
            Console.WriteLine("Введите новый ключ и новое значение(через Enter)");
            ht.Add(Console.ReadLine(), Console.ReadLine());
            ICollection c= ht.Keys;
            string b = "";
            foreach(var str in c)
            {
                b += str + ":" + ht[str]+"\n";
            }
            DisplayResult(b);
        }
        private static void key()
        {
            Console.Clear();
            Console.WriteLine("Keys");
            Hashtable ht = filltable();
            ICollection c= ht.Keys;
            Console.WriteLine("Только ключи");
            string b = "";
            foreach(var str in c)
            {
                b += Convert.ToString(str)+'\n';
            }
            DisplayResult(b);
        }
        private static void value()
        {
            Console.Clear();
            Console.WriteLine("values");
            Hashtable ht = filltable();
            ICollection c = ht.Values;
            Console.WriteLine("Только значения");
            string b = "";
            foreach (var str in c)
            {
                b += Convert.ToString(str) + '\n';
            }
            DisplayResult(b);
        }
        private static void cleartable()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            Hashtable ht = filltable();
            ht.Clear();
            ICollection c = ht.Keys;
            string b = "";
            foreach (var str in c)
            {
                b += str + ":" + ht[str] + "\n";
            }
            if (b == "")
            {
                DisplayResult("Таблица пустая)");
            }
            else
            {
                DisplayResult("Что-то пошло не так)");
            }

        }
        private static void removetable()
        {
            Console.Clear();
            Console.WriteLine("Remove");
            Hashtable ht = filltable();
            Console.WriteLine("Введите ключ, который хотите удалить ");
            string text = Console.ReadLine();
            ht.Remove(text);
            ICollection c = ht.Keys;
            string b = "";
            foreach (var str in c)
            {
                b += str + ":" + ht[str] + "\n";
            }
            DisplayResult(b);
        }
        private static ArrayList filllist()
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Введите размерность массива");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            return list;
        }
        private static void reverse()
        {
            Console.Clear();
            Console.WriteLine("Reverse");
            ArrayList list = filllist();
            list.Reverse();
            string b = "";
            foreach (var i in list)
            {
                b+=i.ToString();
            }
            DisplayResult(b);
        }
        private static void removeat()
        {
            Console.Clear();
            Console.WriteLine("RemoveAt");
            ArrayList list = filllist();
            Console.WriteLine("Введите индекс элемента, который хотите удалить");
            int n = Int32.Parse(Console.ReadLine());
            list.RemoveAt(n);
            string b = "";
            foreach (var i in list)
            {
                b += i.ToString();
            }
            DisplayResult(b);
        }
        private static void indexoflist()
        {
            Console.Clear();
            Console.WriteLine("IndexOf");
            ArrayList list = filllist();
            Console.WriteLine("Введите элемент, чтобы узнать его индекс");
            string text = Console.ReadLine();
            DisplayResult( Convert.ToString(list.IndexOf(text)));
        }
        private static void sortlist()
        {
            Console.Clear();
            Console.WriteLine("Sort");
            ArrayList list = filllist();
            list.Sort();
            string b = "";
            foreach (var i in list)
            {
                b += i.ToString();
            }
            DisplayResult(b);
        }
        private static void insert()
        {
            Console.Clear();
            Console.WriteLine("Insert");
            ArrayList list = filllist();
            Console.WriteLine("Введите индекс нового элемента");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите новый элемент");
            string text= Console.ReadLine();
            list.Insert(n, text);
            string b = "";
            foreach (var i in list)
            {
                b += i.ToString();
            }
            DisplayResult(b);
        }
        private static void remove()
        {
            Console.Clear();
            Console.WriteLine("Remove");
            ArrayList list = filllist();
            Console.WriteLine("Введите элемент, который хотите удалить");
            string text=Console.ReadLine();
            list.Remove(text);
            string b = "";
            foreach (var i in list)
            {
                b += i.ToString();
            }
            DisplayResult(b);
        }
        private static void contains()
        {
            Console.Clear();
            Console.WriteLine("Contains");
            ArrayList list = filllist();
            Console.WriteLine("Введите элемент, который хотите проверить на наличие");
            string text = Console.ReadLine();
            if (list.Contains(text))
            {
                DisplayResult("Такой элемент есть в ArrayList");
            }
            else
            {
                DisplayResult("Такого элемента нет");
            }
        }
        private static void clearlist()
        {
            Console.Clear();
            Console.WriteLine("Clear");
            ArrayList list = filllist();
            list.Clear();
            string b = "";
            foreach (var i in list)
            {
                b += i.ToString();
            }
            if (b == "")
            {
                DisplayResult("Он пустой)");
            }
            else
            {
                DisplayResult("Он никогда не сработает");
            }
        }
        private static void count()
        {
            Console.Clear();
            Console.WriteLine("Count");
            ArrayList list = filllist();
            DisplayResult($"Кол-во элементов={Convert.ToString(list.Count)}");
        }
        private static void copyto()
        {
            Console.Clear();
            Console.WriteLine("Count");
            ArrayList list = filllist();
            Array array = Array.CreateInstance(typeof(string),list.Count);
            list.CopyTo(array);
            Console.WriteLine("Теперь у нас все элементы сохранены в Array, а не в ArrayList");
            string b = "";
            foreach (string a in array)
            {
                b += a;
            }
            DisplayResult(b);

        }
        private static Array fillmas()
        {
            Console.WriteLine("Введите размерность");
            int n = Int32.Parse(Console.ReadLine());
            Array array = Array.CreateInstance(typeof(string), n);
            for (int i = 0; i < n; i++)
            {
                array.SetValue(Console.ReadLine(), i);
            }
            return array;

        }
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("reverse");
            Array array = fillmas();
            Array.Reverse(array);
            string b = "";
            foreach (string a in array)
            {
                b += a;
            }
            DisplayResult(b);
        }
        private static void length()
        {
            Console.Clear();
            Console.WriteLine("length");
            Array array = fillmas();
            DisplayResult(Convert.ToString(array.Length));
        }
        private static void rank()
        {
            Console.Clear();
            Console.WriteLine("rank");
            Array array = fillmas();
            DisplayResult(Convert.ToString(array.Rank));
        }
        private static void clear()
        {
            Console.Clear();
            Console.WriteLine("clear");
            Array array = fillmas();
            Console.WriteLine("напишите индекс элемента");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("напишите кол-во элементов, которые нужно удалить, начиная с этого индекса");
            int m = Int32.Parse(Console.ReadLine());
            Array.Clear(array, n, m);
            string b = "";
            foreach (string a in array)
            {
                b += a;
            }
            DisplayResult(b);
        }
        private static void sort()
        {
            Console.Clear();
            Console.WriteLine("sort");
            Array array = fillmas();
            Array.Sort(array);
            string b = "";
            foreach (string a in array)
            {
                b += a;
            }
            DisplayResult(b);
        }
        private static void copy()
        {
            Console.Clear();
            Console.WriteLine("copy");
            Array array1 = fillmas();
            Array array2 = fillmas();
            Console.WriteLine("Количество копируемых элементов ");
            int n = Int32.Parse(Console.ReadLine());
            Array.Copy(array1, array2, n);
            string b = "";
            foreach (string a in array2)
            {
                b += a;
            }
            DisplayResult(b);
        }
        private static void indexof()
        {
            Console.Clear();
            Console.WriteLine("indexof");
            Array array = fillmas();
            Console.WriteLine("введите элемент");
            string text = Console.ReadLine();
            DisplayResult(Convert.ToString(Array.IndexOf(array, text) + 1));
        }
        private static void set()
        {
            Console.Clear();
            Console.WriteLine("fillmas");
            Array array1 = fillmas();
            Console.WriteLine("введите индекс элемента, который хотите изменить");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите элемент");
            string text = Console.ReadLine();
            array1.SetValue(text, n);
            string b = "";
            foreach (string a in array1)
            {
                b += a;
            }
            DisplayResult(b);
        }
        private static void binanrnysearch()
        {
            Console.Clear();
            Console.WriteLine("binanrnysearch");
            Array array = fillmas();
            Array.Sort(array);
            string b = "";
            foreach (string a in array)
            {
                b += a;
            }
            Console.WriteLine($"Отсортированный массив: {b}");
            Console.WriteLine("Введите элемент");
            string text = Console.ReadLine();
            Console.WriteLine("Индекс");
            DisplayResult(Convert.ToString(Array.BinarySearch(array, text)));

        }
        private static void getvalue()
        {
            Console.Clear();
            Console.WriteLine("getvalue");
            Array array = fillmas();
            Console.WriteLine("Введите индекс элемента");
            int n = Int32.Parse(Console.ReadLine());
            DisplayResult(Convert.ToString(array.GetValue(n)));
        }
        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
            Console.Write("Нажмите Enter,чтобы вернуться ");
            Console.ReadLine();
        }

    }
}