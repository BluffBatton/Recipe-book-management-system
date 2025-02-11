using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var sumResult = MathSanek.Sum(a, b);
            var multResult = MathSanek.Multiplication(a, b);
            Console.WriteLine($"Sum of two integers: {sumResult}");
            Console.WriteLine($"Result of multiplication: {multResult}");
        }
    }
    public class MathSanek 
    {
        public static int Sum(int a, int b) 
        {
            return a + b;
        }

        public static int Multiplication(int a, int b) 
        {
            return a * b;
        }
    }
}
