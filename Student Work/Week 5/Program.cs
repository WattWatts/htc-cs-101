using System;

namespace Week_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int returnValue = 0;


            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
        
        
            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation to perform?");
            string operation = Console.ReadLine();

            if(operation == "+") {
               returnValue =  AddNumbers(a, b);
            }
            if(operation == "-") {
               returnValue =  SubNumbers(a, b);
            }
            if(operation == "*") {
               returnValue =  MultiNumbers(a, b);
            }
            if(operation == "/") {
               returnValue =  DivNumbers(a, b);
            }

            Console.WriteLine(returnValue);

        }

        public static int AddNumbers(int integer1, int integer2) 
        {
            return integer1 + integer2;
        }
        
        public static int SubNumbers(int integer1, int integer2) 
        {
            return integer1 - integer2;
        }
        public static int MultiNumbers(int integer1, int integer2) 
        {
            return integer1 * integer2;
        }
        public static int DivNumbers(int integer1, int integer2) 
        {
            return integer1 / integer2;
        }
    }
}

