using System;

namespace Week_6
{
    class Program
    {
        static void Main(string[] args)
        /* {
             Console.WriteLine("Enter a whole number: ");
             int num = Convert.ToInt32(Console.ReadLine());

             int result = 1;
             int i = num;

             while ( i > 0){
                 result *= i;

                 i--;
             }

             Console.WriteLine("Factorial of " + num + " is " + result);
         } */

        {
            int x = 0;
            while (x <= 100)
            {
                x++;
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }

        }
    }
}
