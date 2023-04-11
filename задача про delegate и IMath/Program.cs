using System;
using System.Security.Cryptography.X509Certificates;
// Объявить тип делегата.
delegate double MathOp(double a, double b);
interface IMath
{
    // Сумма.
    static double sum(double a, double b)
    {
        return a+b;
    }
    // Минус.
    static double minus(double a, double b)
    {
        return a - b;
    }
    // Произведение.
    static double multi(double a, double b)
    {
        return a * b;
    }
    //Деление
    static double del(double a, double b)
    {
        return a / b;
    }
    static void Main()
    {
        // Сконструировать делегат.
        double str;
        // Вызвать методы с помощью делегата.
        Console.WriteLine("Введите два числа");
        double a = Int32.Parse(Console.ReadLine());
        double b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите операцию, которую хотите посчитать(+ , - , * , /");
        string text = Console.ReadLine();
        if (text == "+")
        {
            MathOp math = new MathOp(sum);
            str = math(a, b);
            Console.WriteLine($"Сумма равна = {str}");
        }
        else if (text == "-")
        {
            MathOp math = new MathOp(minus);
            str = math(a, b);
            Console.WriteLine($"Разность равна = {str}");
        }
        else if (text== "*")
        {
            MathOp math = new MathOp(multi);
            str = math(a, b);
            Console.WriteLine($"Произведение равно = {str}");
        }
        else if (text== "/")
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                MathOp math = new MathOp(del);
                str = math(a, b);
                Console.WriteLine($"Деление равно = {str}");
            }
        }
        else
        {
            Console.WriteLine("Неправильно введен знак операции");
        }
    }
}
