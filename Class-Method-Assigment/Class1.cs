using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_Assigment
{
    public class Class1

    {

        public void Div(int number, out double result)
        {
            result = number / 2.00;

            Console.WriteLine("1/2 of {0}" + " is {1}", number, result);
        }

        public void Div(double number, out double dResult)
        {
            dResult = number / 2.00;

            Console.WriteLine("1/2 of {0}" + " is {1}", number, dResult);
        }


    }
}
