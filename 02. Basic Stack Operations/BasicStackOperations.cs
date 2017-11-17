using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BasicStackOperations
{
    public static void Main()
    {
        var inputArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var n = inputArgs[0];
        var s = inputArgs[1];
        var x = inputArgs[2];

        var stack = new Stack<int>();

        var inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach (var num in inputNums)
        {
            stack.Push(num);
        }

        for (int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        Console.WriteLine(stack.Contains(x) ? "true" : stack.Count > 0 ? stack.Min().ToString() : "0");
            }
}

