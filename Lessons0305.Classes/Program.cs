using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0305.Classes
{
    class Program
    {
        //public delegate int PerformCalc(int num1, int num2);

        static void Main(string[] args)
        {
            
            Console.WriteLine("Lesson 0305 Classes\n");
            //int N1;
            //int N2;
            //char OP;
            //string input;
            //string[] substring;
            //Console.WriteLine("Input numbers and opertaion");
            //input = Console.ReadLine();
            //substring = input.Split(' ');
            //N1 = Convert.ToInt32(substring[0]);
            //N2 = Convert.ToInt32(substring[1]);
            //OP = Convert.ToChar(substring[2]);
            ////PerformCalc myDelegate;
            //Func<int, int, int>  myDelegate;
            //switch (OP)
            //{
            //    case '+':
            //        myDelegate = Add;
            //        break;
            //    case '-':
            //        myDelegate = Subtr;
            //        break;
            //    case '*':
            //        myDelegate = Mult;
            //        break;
            //    case '/':
            //        myDelegate = Div;
            //        break;
            //    default:
            //        myDelegate = null;
            //        break;

            //}
            //Console.WriteLine(myDelegate(N1, N2));
            Console.ReadLine();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtr(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
