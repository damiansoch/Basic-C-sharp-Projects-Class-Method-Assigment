using System;

namespace Class_Method_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("Please enter the whole number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the decimal number (number that consists of a whole number and a fractional part)");

            double dNumber = Convert.ToDouble(Console.ReadLine());

            double result;
            double dResult;

            class1.Div(number, out result);
            class1.Div(dNumber, out dResult);


            Console.WriteLine("Result of the function1 = {0}", result);
            Console.WriteLine("Result of the function2 = {0}", dResult);


        }
    }
}
