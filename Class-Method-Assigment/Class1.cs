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

        public void Multi(int number1, out int resultM, int number2 = 2)
        {
            resultM = number1 * number2;
        }

        public void Multi(int number1, int number3, out int resultM, int number2 = 2)
        {
            resultM = number1 * number2 * number3;
        }
    }
}
