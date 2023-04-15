using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
 

delegate double Incr(double v,double b,double a);

class SimpleLambdaDemo 
{
    static void Main() 
    {
        Incr max = (x,y,z) =>
        {
            double[] mas=new double[3];
            mas[0]=x;
            mas[1]=y;
            mas[2]=z;
            double l = mas.Max();
            return l;  
        };
        Incr min=(x,y,z) =>
        {
            double[] mas = new double[3];
            mas[0]=x;
            mas[1]=y;
            mas[2]=z;
            double l = mas.Min();
            return l; 
        };
        Incr sum = (x, y, z) =>
        {
            return x + y + z;
        };
        Incr multi=(x,y,z) =>
        {
            return x*y*z;
        };
        Incr srdzna = (x, y, z) =>
        {
            return (x + y + z) / 3;
        };
        Console.WriteLine("Введите 3 числа");
        double a = Int32.Parse(Console.ReadLine());
        double b = Int32.Parse(Console.ReadLine());
        double c = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Максимальное:");
        Console.WriteLine(max(a, b, c));
        Console.WriteLine("Минимальное:");
        Console.WriteLine(min(a, b, c));
        Console.WriteLine("Сумма:");

        Console.WriteLine(sum(a, b, c));
        Console.WriteLine("Произведение:");
        Console.WriteLine(multi(a, b, c));
        Console.WriteLine("Среднее значение:");
        Console.WriteLine(srdzna(a, b, c));
        Console.ReadKey();
    }
}

