using System;

// This is the HelloWorld name space.
namespace HelloWorld
{
    // This is the Program class.
    class Program
    {
        // This is where the strings go or something.
        static void Main(string[] args)
        {
            // This is an integer
            int num1 = 32;
            int num2 = 5;
            int sum1 = num1 + num2;
            
            // This is a double.
            double d1 = 3.5;
            double d2 = 1.337;
            double sum2 = d1 + d2;
            
            // This is a float.
            float f1 = 3.5F;
            float f2 = 3.2F;
            float sum3 = f1 + f2;
            
            // This is a string.
            string myname = "Max";
            
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum1 + ".");
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sum2 + ".");
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + sum3 + ".");
            Console.WriteLine("My name is " + myname);
            Console.WriteLine("I am " + num1 + " years old.");
            Console.Read();
        }
    }
}