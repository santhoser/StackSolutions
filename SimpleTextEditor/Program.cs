using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        Stack<string> stateOfS = new Stack<string>();
        string s = string.Empty;
        int Q = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < Q; i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int op = Convert.ToInt32(arr_temp[0]);
            switch (op)
            {
                case 1:
                    stateOfS.Push(s);
                    s = s + arr_temp[1];
                    break;
                case 2:
                    stateOfS.Push(s);

                    s = s.Remove(s.Length - Convert.ToInt32(arr_temp[1]), Convert.ToInt32(arr_temp[1]));
                    break;
                case 3:
                    Console.WriteLine(s.Substring(Convert.ToInt32(arr_temp[1]) - 1, 1));
                    break;
                case 4:
                    s = stateOfS.Pop();
                    break;
            }
        }
        Console.ReadKey();
    }
}