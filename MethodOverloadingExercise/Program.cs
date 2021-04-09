using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(12.45, 45.012));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isValid)
        {
            var sum = x + y;
            if (isValid == true)
            {
                if (sum == 1)
                    return "1 dollar";
                else return $"{sum} dollars";
            }
            else
                return $"{sum}";

            //use below code if parameter was asking for strings
            //var num1 = int.TryParse(x, out int numX);
            //var num2 = int.TryParse(y, out int numY);
            
        }
    }
}
