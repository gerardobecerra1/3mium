using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número entero: ");
            int num = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Su factorial es: {0}", Factorial(num));
        }
        public static long Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
