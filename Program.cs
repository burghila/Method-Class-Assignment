using System;

namespace MyConsoleApp
{
    // Class containing methods for mathematical operations
    class MathOperations
    {
        // This method performs an addition on 'a' and displays 'b'
        public void PerformOperation(int a, int b)
        {
            int result = a + 1; // Add 1 to 'a'
            Console.WriteLine("The value of b is: " + b); // Display 'b'
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method with positional arguments
            mathOps.PerformOperation(5, 10);

            // Call the method with named arguments
            mathOps.PerformOperation(a: 5, b: 10);
        }
    }
}
