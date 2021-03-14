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
            // Implicit conversion.
            int num = 1234567890;
            long bugNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // Explicit conversion.
            // Cast double to int;
            myInt = (int)myDouble; // "13"
            
            // Type conversion.
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString(); // "13.37"
            
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myFloatString);
            Console.Read();
        }
    }
}