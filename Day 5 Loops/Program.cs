using System;

namespace Day_5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }
    }
}
