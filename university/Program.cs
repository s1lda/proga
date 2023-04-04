using System;
using System.Linq;
using System.Collections.Generic;
using university;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {  
        List<Teacher> listteacher = new List<Teacher>();
        Console.WriteLine("Сколько учителей?");
        int n=Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string middle = Console.ReadLine();
          string databirt = Console.ReadLine();
            string kaf = Console.ReadLine();
           Console.WriteLine("Сколько дисциплин?");
            int k = Int32.Parse(Console.ReadLine());
            List<string> lessons = new List<string>();
            for (int j = 0; j < k; j++)
            {
                lessons.Add(Console.ReadLine());
            }

            Teacher teacher = new Teacher(first, second, middle, databirt, kaf, lessons);
            listteacher.Add(teacher);
        }
        List<Students> liststud = new List<Students>();
        Console.WriteLine("Сколько студентов?");
        int count = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string middle = Console.ReadLine();
            string databirt = Console.ReadLine();
            string kaf = Console.ReadLine();
            Console.WriteLine("Сколько дисциплин?");
            int k = Int32.Parse(Console.ReadLine());
            Dictionary<string, int> lessons = new Dictionary<string, int>();
            for(int j = 0; j < k; j++)
            {
                lessons.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            }
            Students student = new Students(first, second, middle, databirt, kaf, lessons);
            liststud.Add(student);
        }
        List<Manager> listman = new List<Manager>();
        Console.WriteLine("Сколько управляющих?");
        int n2 = Int32.Parse(Console.ReadLine());
        List<Laws> laws = new List<Laws>();
        for (int i = 0; i < n2; i++)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string middle = Console.ReadLine();
            string databirt = Console.ReadLine();
            string levels = Console.ReadLine();
            Console.WriteLine("Сколько приказов");
            int k = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < k; j++)
            {
                string prefix = Console.ReadLine();
                string number = Console.ReadLine();
                string name = Console.ReadLine();
                string content = Console.ReadLine();
                Laws law=new Laws(prefix, number, name, content);
                laws.Add(law);
            }
            Manager manager = new Manager(first, second, middle, databirt, levels,laws);
            listman.Add(manager);
        }
        List<Cleaner> listclear = new List<Cleaner>();
        Console.WriteLine("Кол-во вспомогательного состава");
        int n3 = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n3; i++)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string middle = Console.ReadLine();
            string databirt = Console.ReadLine();
            Cleaner cleaners = new Cleaner(first, second, middle, databirt);
            listclear.Add(cleaners);
        }
        Console.WriteLine("Введите название дисциплины");
        string lesson = Console.ReadLine();
        foreach(Students student in liststud)
        {
            if (student.Marks.ContainsKey(lesson) && student.Marks.ContainsValue(2)) 
            {
                Console.WriteLine(student.Firstname);
            }
        }
        Console.WriteLine("Для всех");
        foreach(Manager manager1 in listman)
        {
            foreach(Laws law in laws)
            {
                if (law.Prefix == "p1")
                {
                    Console.WriteLine($"{law.Name} {law.Number}");
                }
            }
        }
        Console.WriteLine("Для студентов");
        foreach (Laws law in laws)
        {
            if (law.Prefix == "p2")
            {
                Console.WriteLine($"{law.Name} {law.Number}");
            }
        }
        Console.WriteLine("Для учителей");
        foreach (Laws law in laws)
        {
            if (law.Prefix == "p3")
            {
                Console.WriteLine($"{law.Name} {law.Number}");
            }
        }
        Console.WriteLine("Для вспомогательного состава");
        foreach (Laws law in laws)
        {
            if (law.Prefix == "p4")
            {
                Console.WriteLine($"{law.Name} {law.Number}");
            }
        }
        Console.ReadKey();
    }
}

