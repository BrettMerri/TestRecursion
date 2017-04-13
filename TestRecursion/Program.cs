using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
            Console.WriteLine(FactRecursion(5));
            //FibonacciSeries(50);
        }
        public static int Fact(int input)
        {
            int Result = 1;
            for (int i = 1; i <= input; i++)
            {
                Result = Result * i;
            }
            return Result;
        }
        public static int FactRecursion(int input)
        {
            if (input == 0)
                return 1;
            else
                return input * FactRecursion(input - 1);
        }
        //public static int FibonacciSeries(int input)
        //{
        //    if (input == 0)
        //    {
        //        return 0;
        //    }
        //    if (input == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        Console.WriteLine(input);
        //        return FactRecursion(input - 1) + FactRecursion(input - 2);
        //    }
        }
    }
}
