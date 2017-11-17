using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ReverseNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse);

        var reverseNumbers = new Stack<double>(input);

        reverseNumbers.Reverse();

        var reverse = string.Empty.Trim();
        foreach (var numbers in reverseNumbers)
        {
            reverse += (numbers + " ");
        }
        Console.WriteLine(reverse);
    }
}

