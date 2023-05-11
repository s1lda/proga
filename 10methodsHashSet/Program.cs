
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedSet<string> set = new SortedSet<string>();
        bool finished = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Меню ");
            Console.WriteLine("1 Add()");
            Console.WriteLine("2 Clear()");
            Console.WriteLine("3 Contains()");
            Console.WriteLine("4 Reverse()");
            Console.WriteLine("5 Remove()");
            Console.WriteLine("6 GetType()");
            Console.WriteLine("7 GetHashCode()");
            Console.WriteLine("8 TryGetValue()");
            Console.WriteLine("9 Count()");
            Console.WriteLine(" Нажмите ESC, чтобы выйти ");
            Console.WriteLine("Выберите: ");
            ConsoleKeyInfo rab = Console.ReadKey(true);
            switch (rab.Key)
            {
                case ConsoleKey.D1:
                    Add(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.D2:
                    Clear(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.D3:
                    Contains(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.D4:
                    Reverse(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.D5:
                    Remove(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine(set.GetType());
                    finished = nad();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine(set.GetHashCode());
                    finished = nad();
                    break;
                case ConsoleKey.D8:
                    TryGetValue(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.D9:
                    Count(ref set);
                    finished = nad();
                    break;
                case ConsoleKey.Escape:
                    finished = true;
                    break;
                default:
                    Console.Clear();
                    break;
            }
        } while (!finished);
    }
    static bool nad()
    {
        bool finished = false;
        Console.WriteLine("Нажмите любую кнопку чтобы вернуться, чтобы вернуться  ");
        ConsoleKeyInfo re = Console.ReadKey(true);
        if (re.Key == ConsoleKey.Enter)
        {
            finished = false;
        }
        Console.Clear();
        return finished;
    }
    static SortedSet<string> Add(ref SortedSet<string> set)
    {
        Console.Clear();
        string stop;
        do
        {
            Console.WriteLine("Введите элементы");
            set.Add(Console.ReadLine());
            Console.WriteLine("Продолжить?");
            stop = Console.ReadLine();
        } while (stop != "");
        Print(ref set);
        return set;
    }
    static void Print(ref SortedSet<string> set)
    {
        Console.Clear();
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
    static void Clear(ref SortedSet<string> set)
    {
        Console.Clear();
        set.Clear();
        Print(ref set);
    }
    static void Reverse(ref SortedSet<string> set)
    {
        Console.Clear();
        set.Reverse();
        Print(ref set);
    }
    static void Contains(ref SortedSet<string> set)
    {
        Console.Clear();
        Console.WriteLine("Определяет, содержит ли набор указанный элемент.");
        Console.WriteLine("Введите элемент");
        if (set.Contains(Console.ReadLine()))
        {
            Console.WriteLine("Содержит");
        }
        else { Console.WriteLine("Не содержит"); }
    }
    static void Remove(ref SortedSet<string> set)
    {
        Console.Clear();
        Console.WriteLine("Удаляет указанный элемент из набора SortedSet<T>.");
        Console.WriteLine("Укажите элемент");
        set.Remove(Console.ReadLine());
        Print(ref set);
    }
    static void TryGetValue(ref SortedSet<string> set)
    {
        Console.Clear();
        Console.WriteLine("Выполняет поиск указанного значения в наборе и возвращает равное ему значение, если его удалось найти. значение по умолчанию null");
        Console.WriteLine("введите значение");
        string i = Console.ReadLine();
        string g = null;
        Console.WriteLine(set.TryGetValue(i, out g));
    }
    static void Count(ref SortedSet<string> set)
    {
        Console.Clear();
        Console.WriteLine(set.Count);
    }
}