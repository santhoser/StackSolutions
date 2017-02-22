using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Stack<int> stack = new Stack<int>();
        Stack<int> maxStack = new Stack<int>();
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] element = Array.ConvertAll(arr_temp, Int32.Parse);
            switch (element[0])
            {
                case 1:
                    stack.Push(element[1]);
                    if (maxStack.Count > 0)
                    {
                        if (element[1] >= maxStack.Peek())
                        {
                            maxStack.Push(element[1]);
                        }
                        else
                        {
                            int temp = maxStack.Pop();
                            maxStack.Push(element[1]);
                            maxStack.Push(temp);
                        }
                    }
                    else
                    {
                        maxStack.Push(element[1]);
                    }
                    break;
                case 2:
                    if (stack.Count > 0)
                    {
                        int pop = stack.Pop();
                        if (maxStack.Count > 0)
                        {
                            if (pop < maxStack.Peek())
                            {
                                int temp = maxStack.Pop();
                                maxStack.Pop();
                                maxStack.Push(temp);
                            }
                            else
                            {
                                maxStack.Pop();
                            }
                        }
                    }

                    break;
                case 3:
                    Console.WriteLine(maxStack.Peek());
                    break;
            }
        }
        Console.ReadKey();
    }
}