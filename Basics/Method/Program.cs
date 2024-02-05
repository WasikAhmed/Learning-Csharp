using System;

namespace Method
{
    internal class Program
    {
        // Method declaration
        // access-modifier return-type method-name([param-list]) {
        // Code Block    
        //}
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        
    public static void Main(string[] args)
        {
            // Print the sum of 10 and 20
            int result = sum(10, 20);
            Console.WriteLine(result);
            
            // Print the sum of 50 and 30
            result = sum(50, 30);
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    }
}