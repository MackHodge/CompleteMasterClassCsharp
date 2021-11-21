using System;

namespace Nullable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double? num1 = null;
            double? num4 = 0.514;
            double num8;
            //int num2 = null; can not sign null to an integer 
            num1 = num4;

            //num8 = num1; // can not convert nullable to double

            num8 = (double) num1;
            //if num4 is empty enter the numer 123.312
            num8 = num4 ?? 123.312;
            num8 = num1 ?? 123.312;

            Console.WriteLine(num8);

        }
    }
}