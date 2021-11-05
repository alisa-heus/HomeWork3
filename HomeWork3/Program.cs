using System;
using HomeWork3;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            
        }

       static void Task1()
        {
            Console.WriteLine("Enter a number");
            var A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number");
            var B = Convert.ToDouble(Console.ReadLine());

            double result = Calculator.Task1(A, B);
            Console.WriteLine(result);
        }
        static void Task2()
        {
            Console.WriteLine("Type number X");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type number Y");
            double Y = Convert.ToDouble(Console.ReadLine());

            string result = Calculator.Task2(X, Y);
            Console.WriteLine(result);
        }

        static void Task3()
        {
            Console.WriteLine("Type number A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type number B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type number C");
            int C = Convert.ToInt32(Console.ReadLine());

            (int X, int Y, int Z) = Calculator.Task3(A, B, C);
            Console.WriteLine($"Ascending numbers are {X}, {Y} and {Z}");    
        }

        static void Task4()
        {
            Console.WriteLine("Type number A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type number B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type number C");
            double C = Convert.ToDouble(Console.ReadLine());

            string result = Calculator.Task4(A, B, C);
            Console.WriteLine(result);
        }

        static void Task5()
        {
                Console.WriteLine("Type two-digit number");
                int A = Convert.ToInt32(Console.ReadLine());

                string result = Calculator.Task5(A);
                Console.WriteLine(result);
        }

    }
}
