using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathUtil = new MathUtil();
            int result = mathUtil.Add(2, 2);
            Console.WriteLine($"2 + 2 = {result}");
        }
    }
}
