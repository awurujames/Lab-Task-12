using System;

namespace MulticastDelegateApp
{
    public delegate void AddTwoNum(int first, int second);
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNum addNum = Plus;
            addNum += Minus;

            Console.Write("Please enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            addNum(num1, num2);

        }

        static void Plus(int a, int b)
        {
            Console.WriteLine($"The sum of num1 and num2 is: {a + b}");
        }

        static void Minus(int a, int b)
        {
            Console.WriteLine($"The Multiple of num1 and num2 is: {a * b}");
        }

    }
}
