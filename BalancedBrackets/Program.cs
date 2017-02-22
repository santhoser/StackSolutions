using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        string[] result = new string[t];
        char[] closing = { '}', ')', ']' };
        for (int a0 = 0; a0 < t; a0++)
        {
            bool ans = true;
            string s = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count > 0 && IsMatching(stack.Peek(), c))
                {
                    stack.Pop();
                }
                else
                {
                    if (Array.IndexOf(closing, c) > -1)
                    {
                        ans = false;
                        break;
                    }
                    else
                    {
                        stack.Push(c);
                    }

                }
            }
            if (ans)
            {
                result[a0] = stack.Count == 0 ? "YES" : "NO";
            }
            else
            {
                result[a0] = "NO";
            }

        }
        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

    public static bool IsMatching(char a, char b)
    {
        return ((a == '{' && b == '}') || (a == '[' && b == ']') || (a == '(' && b == ')'));
    }
}
