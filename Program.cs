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
            // These are integers.
            int num1 = 32;
            int num2 = 5;
            int sum1 = num1 + num2;
            int myInt1;
            int myInt2;
            
            // These are doubles.
            double d1 = 3.5;
            double d2 = 1.337;
            double sum2 = d1 + d2;
            
            // These are floats.
            float f1 = 3.5F;
            float f2 = 3.2F;
            float sum3 = f1 + f2;
            
            // These are strings.
            string myName = "Max";
            string yourName;
            
            // Explicit conversion.
            // Cast double to int.
            myInt1 = (int)d2;
            myInt2 = (int)sum2;
            
            Console.WriteLine(myInt1);
            Console.WriteLine(myInt2);
            
            // Implicit conversion.
            // Cast int to long.
            int num3 = 123456789;
            long bigNum = num3;

            // Cast blah blah too tired. Going to sleep..
            float f3 = 13.37F;
            double d3 = f3;
            
            
            
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum1 + ".");
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sum2 + ".");
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + sum3 + ".");
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I am " + num1 + " years old.");
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered " + readInput);

            Console.Write("Enter a character: ");
            int asciiValue = Console.Read();
            Console.WriteLine("\nASCII value is " + asciiValue);
        }
    }
}