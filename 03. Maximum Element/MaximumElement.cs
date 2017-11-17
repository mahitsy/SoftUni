using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MaximumElement
{
    public static void Main()
    {
        var queriesNumber = int.Parse(Console.ReadLine());
        var stack = new Stack<int>();

        var maxStack = new Stack<int>();
        var max = int.MinValue;

        for (int i = 0; i < queriesNumber; i++)
       {
            var query = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            if (query[0] == 1)
            {
                stack.Push(query[1]);
                if (query[1] > max)
                {
                    max = query[1];
                    maxStack.Push(max);
                }
            }
            else if (query[0] == 2)
            {
                if (stack.Pop() == max)
                {
                    maxStack.Pop();
                    if (maxStack.Count() != 0)
                    {
                        max = maxStack.Peek();
                    }
                    else
                    {
                        max = int.MinValue;
                    }
                }
            }
            else if (query[0] == 3)
            {
                Console.WriteLine(max);
            }
        }

    }
}

