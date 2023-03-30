using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main()
        {
            string text=Console.ReadLine().Replace(" ","");
            Stack <char> stack = new Stack<char>();
            bool check = true;
            foreach(var item in text)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (stack.Count != 0)
                {
                    if (item == ')' && stack.Peek() != '(')
                    {
                        check = false;
                    }
                    if (item == '}' && stack.Peek() != '{')
                    {
                        check = false;
                    }
                    if (item == ']' && stack.Peek() != '[')
                    {
                        check = false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}