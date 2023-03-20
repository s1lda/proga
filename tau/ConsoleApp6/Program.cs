using System;

namespace Tau
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите фразу: ");
            string[] text = Console.ReadLine().Split(' ');
            string[] tmp = new string[text.Length];

            int k = text.Length / 2;
            for (int i = 0; i < text.Length; i++)
            {
                k += Convert.ToInt32(Math.Pow(-1, i) * i);
                tmp[i] = Convert_Word(text[k]);
            }
            Console.WriteLine(String.Join(" ", tmp));
            Console.ReadKey();
        }
        static string Convert_Word(string word)
        {
            char[] tmp = new char[word.Length];
            int k = word.Length / 2;
            for (int i = 0; i < word.Length; i++)
            {
                k += Convert.ToInt32(Math.Pow(-1, i) * i);
                tmp[i] = word[k];
            }
            return new string(tmp);
        }
    }
}