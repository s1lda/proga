using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

class SimpQuery
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 0, 4, 5,7,9,8,-11,-23,123 ,10};


        var posNums = from n in nums
                      where n > 0
                      select n;
        var sumotr = (from n in nums
                      where n < 0
                      select n).Sum();
        var del5 = (from n in nums
                    where n % 5 == 0 && n != 0
                    select n).Count();
        Console.Write("Положительные значения из массива nums: ");
        foreach (int i in posNums)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма отрицательных:");
        Console.WriteLine(sumotr);
        Console.WriteLine("Числа, кратные 5");
        Console.WriteLine(del5);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                nums[i] = default;
            }
        }
        Console.WriteLine("После того, как удалили четные элементы");
        Console.Write("Положительные значения из массива nums: ");
        foreach (int i in posNums)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма отрицательных:");
        var sumotr2 = (from n in nums
                      where n < 0
                      select n).Sum();
        Console.WriteLine(sumotr2);
        Console.WriteLine("Числа, кратные 5");
        var del55 = (from n in nums
                    where n % 5 == 0 && n != 0
                    select n).Count();
        Console.WriteLine(del55);
        Console.ReadKey();
    }
}