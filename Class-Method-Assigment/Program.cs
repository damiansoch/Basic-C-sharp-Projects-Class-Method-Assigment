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

            class1.Div(number);


        }
    }
}
