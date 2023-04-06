using System;
using System.Linq;
using System.Collections.Generic;
using university;

class Program
{
    static void Main(string[] args)
    {
        List<Teacher> listteacher = new List<Teacher>();
        List<Students> liststud = new List<Students>();
        List<Manager> listman = new List<Manager>();
        List<Laws> laws = new List<Laws>();
        List<Cleaner> listclear = new List<Cleaner>();
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1) Заполнить данные");
        Console.WriteLine("2) Выборка по предмету(список должников)");
        Console.WriteLine("3) Выборка по приказам");
        Console.WriteLine("4) Выборка по фамилии препода(список должников)");
        Console.WriteLine("5) Exit");
        while (true)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Сколько учителей?");
                    int n = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Введите ФИО");
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string middle = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения");
                        string databirt = Console.ReadLine();
                        Console.WriteLine("Введите кафедру");
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
                    Console.WriteLine("Сколько студентов?");
                    int count = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Введите ФИО");
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string middle = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения");
                        string databirt = Console.ReadLine();
                        Console.WriteLine("Введите группу");
                        string kaf = Console.ReadLine();
                        Console.WriteLine("Сколько дисциплин?");
                        int k = Int32.Parse(Console.ReadLine());
                        Dictionary<string, int> lessons = new Dictionary<string, int>();
                        Console.WriteLine("Ввведите сначала название, потом оценку");
                        for (int j = 0; j < k; j++)
                        {
                            lessons.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                        }
                        Students student = new Students(first, second, middle, databirt, kaf, lessons);
                        liststud.Add(student);
                    }
                    Console.WriteLine("Сколько управляющих?");
                    int p = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < p; i++)
                    {
                        Console.WriteLine("Введите ФИО");
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string middle = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения");
                        string databirt = Console.ReadLine();
                        Console.WriteLine("Введите должность");
                        string levels = Console.ReadLine();
                        Console.WriteLine("Сколько приказов");
                        int k = Int32.Parse(Console.ReadLine());
                        for (int j = 0; j < k; j++)
                        {
                            Console.WriteLine("Введите префикс (p1-для всех, p2-для студентов, p3-для учителей, p4-для вспомогательного состава");
                            string prefix = Console.ReadLine();
                            Console.WriteLine("Введите номер");
                            string number = Console.ReadLine();
                            Console.WriteLine("Введите название");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите содержание приказа");
                            string content = Console.ReadLine();
                            Laws law = new Laws(prefix, number, name, content);
                            laws.Add(law);
                        }
                        Manager manager = new Manager(first, second, middle, databirt, levels, laws);
                        listman.Add(manager);
                    }
                    Console.WriteLine("Кол-во вспомогательного состава");
                    int l = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < l; i++)
                    {
                        Console.WriteLine("Введите ФИО");
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string middle = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения");
                        string databirt = Console.ReadLine();
                        Cleaner cleaners = new Cleaner(first, second, middle, databirt);
                        listclear.Add(cleaners);
                    }
                    Console.WriteLine("Выберите опцию:");
                    break;
                case "2":
                    Console.WriteLine("Введите название дисциплины");
                    string lesson = Console.ReadLine();
                    foreach (Students student in liststud)
                    {
                        Console.WriteLine($"{student.Firstname} {student.Lastname} {student.Middlename} {student.Group}");
                    }
                    break;
                case "3":
                    Console.WriteLine("1)Для всех");
                    Console.WriteLine("2)Для студентов");
                    Console.WriteLine("3)Для учителей");
                    Console.WriteLine("4)Для вспомогательного состава");

                    switch (Console.ReadLine())
                    {
                        case "1":
                        Console.WriteLine("Для всех:");
                            foreach (Manager manager1 in listman)
                            {
                                foreach (Laws law in laws)
                                {
                                    if (law.Prefix == "p1")
                                    {
                                        Console.WriteLine($"{law.Name} {law.Number}");
                                    }
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("Для студентов:");
                            foreach (Manager manager1 in listman)
                            {
                                foreach (Laws law in laws)
                                {
                                    if (law.Prefix == "p2")
                                    {
                                        Console.WriteLine($"{law.Name} {law.Number}");
                                    }
                                }
                            }
                            break;
                        case "3":
                            Console.WriteLine("Для учителей:");
                            foreach (Manager manager1 in listman)
                            {
                                foreach (Laws law in laws)
                                {
                                    if (law.Prefix == "p3")
                                    {
                                        Console.WriteLine($"{law.Name} {law.Number}");
                                    }
                                }
                            }
                            break;
                        case "4":
                            Console.WriteLine("Для вспомогательного состава:");
                            foreach (Manager manager1 in listman)
                            {
                                foreach (Laws law in laws)
                                {
                                    if (law.Prefix == "p4")
                                    {
                                        Console.WriteLine($"{law.Name} {law.Number}");
                                    }
                                }
                            }
                            break;
                    }
                    Console.WriteLine("Выберите опцию:");
                    break;
                case "4":
                    Console.WriteLine("Введите фамилию препода");
                    string text=Console.ReadLine();
                    foreach(Teacher teacher in listteacher)
                    {
                        if (text == teacher.Firstname)
                        {
                            foreach(string les in teacher.Lessons)
                            {
                                foreach(Students student in liststud)
                                {
                                    if(student.Marks().ContainsKey(les) && student.Marks().ContainsValue(2))
                                    {
                                        Console.WriteLine($"{student.Firstname} {student.Lastname} {student.Middlename} {student.Group} {les}");
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine("Выберите опцию:");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
        
      

//        Console.WriteLine("Для всех");
//        foreach(Manager manager1 in listman)
//        {
//            foreach(Laws law in laws)
//            {
//                if (law.Prefix == "p1")
//                {
//                    Console.WriteLine($"{law.Name} {law.Number}");
//                }
//            }
//        }
//        Console.WriteLine("Для студентов");
//        foreach (Laws law in laws)
//        {
//            if (law.Prefix == "p2")
//            {
//                Console.WriteLine($"{law.Name} {law.Number}");
//            }
//        }
//        Console.WriteLine("Для учителей");
//        foreach (Laws law in laws)
//        {
//            if (law.Prefix == "p3")
//            {
//                Console.WriteLine($"{law.Name} {law.Number}");
//            }
//        }
//        Console.WriteLine("Для вспомогательного состава");
//        foreach (Laws law in laws)
//        {
//            if (law.Prefix == "p4")
//            {
//                Console.WriteLine($"{law.Name} {law.Number}");
//            }
//        }
//        Console.ReadKey();
//    }
//}

