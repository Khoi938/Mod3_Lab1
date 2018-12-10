using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(4, 7);
            int result = Sum2(20, 40);
            Console.WriteLine($"20 + 40 is {result}");
            double result2 = Sum2(Convert.ToInt32(6.8), 40);
            Console.WriteLine($"This one print out double {result2.ToString()}");
              
        }

        static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine(sum);
        }
        //static void Sum(double first, double second)
        //{
        //    double sum = first + second;
        //    Console.WriteLine($"you have {sum}");
        //}
        static double Sum2(double first, double second)
        {
            double sum = first + second +10;
            return sum;
        }
        
        static int Sum2(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Sum2(int one, int two, int three)
        {
            int sum = one + two + three;
            return sum;
        }
    }
}
