using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte firstValue = 2;
            sbyte secondValue = 3;
            double thirdValue = 10;
            decimal forthValue = 5;
            sbyte absoluteValue = Math.Abs(firstValue);
            sbyte maxValue = Math.Max(firstValue, secondValue);
            double sqrtValue = Math.Sqrt(thirdValue);
            decimal truncateValue = Math.Truncate(forthValue);

            Console.WriteLine($"{absoluteValue}, {maxValue}, {sqrtValue}, {truncateValue}");

            double degrees = 60;
            double cosinusValue = 0.5;
            double cos = Math.Round(Math.Cos(degrees),1);
            Console.WriteLine(cos);
            if (cosinusValue == cos)
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }
        }
    }
}
