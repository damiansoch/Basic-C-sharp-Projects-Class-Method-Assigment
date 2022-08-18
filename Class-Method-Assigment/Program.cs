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

            double result;
            int resultM1;
            int resultM2;

            class1.Div(number, out result);
            class1.Multi(number, out resultM1);
            class1.Multi(number, 3, out resultM2);


            Console.WriteLine("Result of the method1 (user input / 2) = {0}", result);
            Console.WriteLine("Result of the method2 (input * 2[default but we can assign different value]))= {0}", resultM1);
            Console.WriteLine("Result of the method3 (overloaded method to method 2 ) = {0}", resultM2 + "\n");


            StaticClass.Write();

            Console.ReadLine();
        }
    }
}
