using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Calculator
    {
       public static double Task1(double A, double B)
        {
            double result;
            if (A < B)
            {
                result = A + B;

            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }

            return result;
        }

       public static string Task2(double X, double Y)
        {
            string quarter;

            if (X > 0)
            {
                if (Y > 0)
                {
                    quarter = "first";
                }
                else
                {
                    quarter = "fourth";
                }
            }
            else
            {
                if (Y > 0)
                {
                    quarter = "second";
                }
                else
                {
                    quarter = "third";
                }
            }
            return quarter;
        }

       public static (int, int, int) Task3(int A, int B, int C)
        {
            if (A > B)
            {
                Swap(ref A, ref B);
            }
            if (A > C)
            {
                Swap(ref A, ref C);
            }
            if (B > C)
            {
                Swap(ref B, ref C);
            }

            return (A, B, C);
        }

       public static string Task4(double A, double B, double C)
        {
            double determinanta = B * B - 4 * A * C;
            if (determinanta < 0)
            {
                return "No intersection";
            }
            else if (determinanta == 0)
            {
                double result = (-1) * B / (2 * A);
                return result.ToString(); 
            }
            else
            {
                double result1 = ((-1) * B + Math.Sqrt(determinanta)) / (2 * A);
                double result2 = ((-1) * B - Math.Sqrt(determinanta)) / (2 * A);
                return result1.ToString()+ "," + result2.ToString(); 
            }

        }

       public static string Task5(int A)
        {
            int tensInt = A / 10;
            int onesInt = A % 10;
            if (tensInt == 1)
            {
                return teenConverter(A);
            }
            else 
            {
                string ones = onesConverter(onesInt);
                string tens = tensConverter(tensInt);
                return tens + " " + ones;
            }
            

            
        }

       private static string onesConverter(int tensInt)
        {
            string ones = "";
            switch (tensInt)
            {
                case 0:
                    ones = "";
                    break;
                case 1:
                    ones = "one";
                    break;
                case 2:
                    ones = "two";
                    break;
                case 3:
                    ones = "three";
                    break;
                case 4:
                    ones = "four";
                    break;
                case 5:
                    ones = "five";
                    break;
                case 6:
                    ones = "six";
                    break;
                case 7:
                    ones = "seven";
                    break;
                case 8:
                    ones = "eight";
                    break;
                case 9:
                    ones = "nine";
                    break;
            }
            return ones;
        }

       private static string tensConverter(int tensInt)
        {
            string tens = "";
            switch (tensInt)
            {
                case 2:
                    tens = "twenty";
                    break;
                case 3:
                    tens = "thirty";
                    break;
                case 4:
                    tens = "fourty";
                    break;
                case 5:
                    tens = "fifty";
                    break;
                case 6:
                    tens = "sixty";
                    break;
                case 7:
                    tens = "seventy";
                    break;
                case 8:
                    tens = "eighty";
                    break;
                case 9:
                    tens = "ninety";
                    break;
            }
            return tens;
        }

       private static string teenConverter(int number)
        {
            string teen ="";
            switch (number)
            {
                case 10:
                    teen = "ten";
                    break;
                case 11:
                    teen = "eleven";
                    break;
                case 12:
                    teen = "twelve";
                    break;
                case 13:
                    teen = "thirteen";
                    break;
                case 14:
                    teen = "fourteen";
                    break;
                case 15:
                    teen = "fifteen";
                    break;
                case 16:
                    teen = "sixteen";
                    break;
                case 17:
                    teen = "seventeen";
                    break;
                case 18:
                    teen = "eighteen";
                    break;
                case 19:
                    teen = "nineteen";
                    break;       
            }
            return teen;
        }
       private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
