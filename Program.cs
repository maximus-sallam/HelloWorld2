using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum1 = num1 + num2;
            //this is a change

            double d1 = 3.5;
            double d2 = 1.337;
            double sum2 = d1 + d2;
            
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum1 + ".");
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sum2 + ".");
            
            Console.WriteLine(num1);
            Console.Read();
        }
    }
}