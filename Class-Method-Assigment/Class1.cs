using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Assigment
{
    public class Class1
    {
        public void Div(int number)
        {
            double result = number / 2.00;

            Console.WriteLine("1/2 of {0}" + " is {1}", number, result);
        }

        public double Div2(int number)
        {
            double result = number / 2.00;

            return result;
        }

        public double Div2(int numberOne, int numberTwo)
        {
            double result = numberOne / numberTwo;

            return result;
        }
    }
}
